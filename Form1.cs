using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_Roach_CPT_185_Final_Project
{
    public partial class gameForm : Form
    {
        //Initialize variables
        private Panel tablePanel;
        private int playerBalance = 100;
        private int currentBet;
        private Player player;
        private Dealer dealer;
        private Deck deck;
        private bool revealDealerSecondCard = false;

        public gameForm()
        {
            //Initialize starting components
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            hitBtn.Visible = false;
            standBtn.Visible = false;
            balanceLabel.Text = "Balance: $" + playerBalance;
            doubleBtn.Visible = false;
            stimulusBtn.Visible = false;

            string imagePath = @"Resources\table.jpg";
            tablePanel = new Panel();
            tablePanel.Dock = DockStyle.Fill;
            tablePanel.BackgroundImage = Image.FromFile(imagePath);
            tablePanel.BackgroundImageLayout = ImageLayout.Stretch;

            Controls.Add(tablePanel);

            player = new Player();
            dealer = new Dealer();
            deck = new Deck();
        }

        //Method to display cards in the player and dealer panels
        private void DisplayCards()
        {
            ClearCards(); //Clear the cards from the previous game

            //Display player cards, with respective images
            foreach (var card in player.Hand.GetCards())
            {
                PictureBox cardPic = new PictureBox()
                {
                    Image = Image.FromFile($@"Resources\{card.ToString()}.png"), //Retrieve image from resources folder
                    SizeMode = PictureBoxSizeMode.StretchImage, //Stretch image to make sure image fits in the picture box
                    Size = new Size(100, 150), //Size of the card image
                    Margin = new Padding(10) //Margin between cards
                };
                playerCardsPanel.Controls.Add(cardPic);
            }

            //Display dealer cards
            for (int i = 0; i < dealer.Hand.GetCards().Count; i++)
            {
                var card = dealer.Hand.GetCards()[i];
                string imagePath;

                if (i == 1 && !revealDealerSecondCard) //Check if the dealers second card should be revealed
                {
                    //Show back of card to hide the second dealer card
                    imagePath = @"Resources\cardBack.png";
                }
                else
                {
                    //Show the actual card when revealSecondCard is true
                    imagePath = $@"Resources\{card.ToString()}.png";
                }

                PictureBox cardPic = new PictureBox()
                {
                    //Same method as player cards in dealer panel
                    Image = Image.FromFile(imagePath),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(100, 150),
                    Margin = new Padding(10)
                };
                dealerCardsPanel.Controls.Add(cardPic);
            }
        }

        //Clear cards method, simply clears the cards from the player and dealer panels
        private void ClearCards()
        {
            playerCardsPanel.Controls.Clear();
            dealerCardsPanel.Controls.Clear();
        }

        //Hit button click logic
        private async void button1_Click(object sender, EventArgs e)
        {
            hitBtn.Enabled = false; //Disable hit button to prevent spamming

            //Prevented stand button because of issue with standing during hit cooldown
            standBtn.Enabled = false;

            doubleBtn.Visible = false; //Cannot double after player has already hit, so hide button
            player.Hand.AddCard(deck.DealCard()); //Deal a card to the player

            DisplayCards(); //Update the cards displayed

            //Loss condition for player
            int playerTotal = player.Hand.GetTotalValue();
            if (playerTotal > 21)
            {
                MessageBox.Show("You busted, Dealer wins.");
                balanceLabel.Text = "Balance:" + "\n" + "$" + playerBalance;

                //Check if player is out of balance, reveal stimulus button
                if (playerBalance == 0)
                {
                    stimulusBtn.Visible = true;
                }

                ResetGame();
            }
            //If player gets blackjack, force stand
            else if (playerTotal == 21)
            {
                standBtn_Click(sender, e);
            }
            else
            {
                //Allow player to continue drawing or stand
            }
            //Hit cooldown to prevent spamming
            await Task.Delay(1000);
            hitBtn.Enabled = true;
            standBtn.Enabled = true;
        }

        private async void standBtn_Click(object sender, EventArgs e)
        {
            //Disable buttons to prevent spamming and breaking the game
            doubleBtn.Enabled = false;
            standBtn.Enabled = false;
            hitBtn.Enabled = false;
            revealDealerSecondCard = true;

            DisplayCards();

            await DealerDrawAsync();

            //Determine who wins after dealer draws
            int playerTotal = player.Hand.GetTotalValue();
            int dealerTotal = dealer.Hand.GetTotalValue();

            //Determine win conditions
            if (dealerTotal > 21)
            {
                MessageBox.Show("Dealer busts. You win!");
                playerBalance += currentBet * 2;
                SessionStats.HandsWon++;
            }
            else if (playerTotal > dealerTotal)
            {
                MessageBox.Show("You Win!");
                playerBalance += currentBet * 2;
                SessionStats.HandsWon++;
            }
            else if (playerTotal < dealerTotal)
            {
                MessageBox.Show("Dealer Wins!");
            }
            else
            {
                MessageBox.Show("You tied, push!");
                playerBalance += currentBet;
            }

            //Update stats
            if (playerBalance > SessionStats.HighestBalance)
            {
                SessionStats.HighestBalance = playerBalance;
            }

            balanceLabel.Text = "Balance:" + "\n" + "$" + playerBalance;

            //If player is out of balance, reveal stimulus button
            if (playerBalance == 0)
            {
                stimulusBtn.Visible = true;
            }

            ResetGame();
        }

        //Dealer draws cards until total is 17 or higher
        private async Task DealerDrawAsync()
        {
            var secondCardPic = dealerCardsPanel.Controls.OfType<PictureBox>().ElementAtOrDefault(1);

            if (secondCardPic != null && secondCardPic.ImageLocation == null)
            {
                secondCardPic.Image = Image.FromFile($@"Resources\{dealer.Hand.GetCards().ElementAt(1).ToString()}.png");
                await Task.Delay(1000);
            }

            int dealerTotal = dealer.Hand.GetTotalValue();

            while (dealer.Hand.GetTotalValue() < 17)
            {
                dealer.Hand.AddCard(deck.DealCard());
                DisplayCards();
                dealerTotal = dealer.Hand.GetTotalValue();
                await Task.Delay(1000);

                if (dealerTotal > 21)
                {
                    dealerTotal = dealer.Hand.GetTotalValue(); //Recalculate after adjusting for aces
                }
            }
            int playerTotal = player.Hand.GetTotalValue();
            Console.WriteLine($"Player hand value: {playerTotal}"); //Player and dealer hand values for debugging
            Console.WriteLine($"Dealer hand value: {dealerTotal}");
        }

        //Deal button click logic
        private void dealBtn_Click(object sender, EventArgs e)
        {
            //Disable deal button to prevent spamming
            dealBtn.Enabled = false;

            //Initialize bet amount
            int betAmount;
            SessionStats.HandsPlayed++; //Update hands played stat

            //Validate bet amount
            if (!int.TryParse(betAmountTextBox.Text, out betAmount) || betAmount <= 0 || betAmount > playerBalance)
            {
                MessageBox.Show("Invalid bet amount.");
                dealBtn.Enabled = true;
                return;
            }

            currentBet = betAmount; //Assign the bet amount to currentBet
            playerBalance -= betAmount;
            SessionStats.BalanceWagered += currentBet; //Update the balance wagered stat
            balanceLabel.Text = "Balance:" + "\n" + "$" + playerBalance;

            //Clear cards from previous game
            player.Hand.ClearCards();
            dealer.Hand.ClearCards();

            //Deal 2 cards to player and 2 cards to dealer
            player.Hand.AddCard(deck.DealCard());
            player.Hand.AddCard(deck.DealCard());
            dealer.Hand.AddCard(deck.DealCard());
            dealer.Hand.AddCard(deck.DealCard());

            //Reset revealDealerSecondCard to false for a new game
            revealDealerSecondCard = false;

            //Display the cards in their respective panels 
            DisplayCards();

            //Check if the player immediately gets blackjack for a win
            if (player.Hand.GetTotalValue() == 21)
            {
                MessageBox.Show("Blackjack! You win!");
                playerBalance += (int)(betAmount + betAmount * 1.5);
                SessionStats.HandsWon++;
                balanceLabel.Text = "Balance:" + "\n" + "$" + playerBalance;

                //Update highest session balance stat
                if (playerBalance > SessionStats.HighestBalance)
                {
                    SessionStats.HighestBalance = playerBalance;
                }

                ResetGame();
                return;
            }

            //Reveal the hit, double and stand buttons
            hitBtn.Visible = true;
            standBtn.Visible = true;
            doubleBtn.Visible = true;

            //Disable the deal button
            dealBtn.Visible = false;

            //Hide the bet amount text box and label
            betAmountTextBox.Visible = false;
            betAmountLabel.Visible = false;
        }

        //Return to menu with the quit button, saving game state
        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide the game form, don't close as to save game state
            var mainForm = Application.OpenForms.OfType<mainForm>().FirstOrDefault(); //Find the main page form
            mainForm?.Show(); //Re-show the main form
        }

        //Reset game method to clear cards and reset game state
        private void ResetGame()
        {
            revealDealerSecondCard = true;
            DisplayCards();

            player.Hand.ClearCards();
            dealer.Hand.ClearCards();
            hitBtn.Visible = false;
            standBtn.Visible = false;
            dealBtn.Visible = true;
            betAmountTextBox.Visible = true;
            betAmountLabel.Visible = true;
            doubleBtn.Visible = false;
            hitBtn.Enabled = true;
            standBtn.Enabled = true;
            dealBtn.Enabled = true;
            doubleBtn.Enabled = true;

            revealDealerSecondCard = false;
        }

        //Double button click logic
        private void doubleBtn_Click(object sender, EventArgs e)
        {
            doubleBtn.Enabled = false; //Disable double button to prevent spamming

            //Validate balance for doubling
            if (playerBalance < currentBet)
            {
                MessageBox.Show("You do not have enough balance to double your bet.");
                doubleBtn.Enabled = true;
                return;
            }

            //Double bet, remove double current bet from balance
            playerBalance -= currentBet;
            currentBet *= 2;
            balanceLabel.Text = "Balance:" + "\n" + "$" + playerBalance;

            player.Hand.AddCard(deck.DealCard());
            DisplayCards();

            //Loss condition for doubling
            int playerTotal = player.Hand.GetTotalValue();
            if (playerTotal > 21)
            {
                MessageBox.Show("You busted, Dealer wins.");
                balanceLabel.Text = "Balance:" + "\n" + "$" + playerBalance;

                if (playerBalance == 0)
                {
                    stimulusBtn.Visible = true;
                }

                ResetGame();
            }
            else
            {
                standBtn_Click(sender, e); //Force stand after doubling
            }
        }

        //Stimulus button click logic, simply add $50 to balance and hide the button
        private void button1_Click_1(object sender, EventArgs e)
        {
            playerBalance += 50;
            balanceLabel.Text = "Balance: $" + playerBalance;
            stimulusBtn.Visible = false;

            //Highest balance stat check
            if (playerBalance > SessionStats.HighestBalance)
            {
                SessionStats.HighestBalance = playerBalance;
            }
        }

        private void gameForm_Load(object sender, EventArgs e)
        {
        }
    }
}
