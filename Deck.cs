using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Roach_CPT_185_Final_Project
{
    //Logic for the deck of cards, with methods to shuffle and draw cards
    internal class Deck
    {
        private List<Card> cards; //List of cards in the deck
        private readonly Random rng = new Random();// RNG for shuffling

        //Constructor that creates a deck of 52 cards
        public Deck()
        {
            InitializeDeck(); //Call initialize deck method
            Shuffle(); //Shuffle the deck
        }

        //Initialize the deck with 52 cards
        private void InitializeDeck()
        {
            cards = new List<Card>(); //Initialize the list of cards

            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" }; //Array of ranks
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" }; //Array of suits

            //Create a card for each suit and rank
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    //Set value of the card based on the rank, and parse rank to int if not a face card
                    int value = (rank == "J" || rank == "Q" || rank == "K") ? 10 : (rank == "A") ? 11 : int.Parse(rank);

                    cards.Add(new Card(suit, rank, value)); //Add the card to the deck
                }
            }
        }

        //Shuffle deck method
        public void Shuffle()
        {
            cards = cards.OrderBy(x => rng.Next()).ToList(); //Shuffle the list with rng
        }

        //Deal a card from the deck
        public Card DealCard()
        {
            if (!cards.Any()) //Check if the deck is empty
            {
                InitializeDeck(); //Program would throw an error if deck was empty, so reinitialize the deck
                Shuffle(); //Shuffle the deck
            }

            var card = cards.Last(); //Get the top card from the deck
            cards.RemoveAt(cards.Count - 1); //Remove the card from the deck
            return card;
        }
    }
}
