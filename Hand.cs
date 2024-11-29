using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

//This class represents the hand of a player or the dealer
namespace N_Roach_CPT_185_Final_Project
{
    internal class Hand
    {
        private List<Card> cards; //Create a list of cards to represent the hand    

        //Constructor to initialize hand
        public Hand()
        {
            cards = new List<Card>(); //Create a new list of cards
        }

        //Add a card to the hand
        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        //Get total value of the hand based on the cards dealt
        public int GetTotalValue()
        {
            int total = 0; //Total value of hand
            int aces = 0; //Number of aces, used to handle ace value of 1 or 11

            //Use foreach to iterate through each card to sum values
            foreach (var card in cards)
            {
                //Handle ace value of 1 or 11
                if (card.Rank == "A") //Check if card is an ace
                {
                    aces++; //Increment number of aces
                    total += 11;//Initially count ace as 11
                }
                else
                {
                    total += card.Value; //Add value of card to total
                }
            }

            //Adjust for aces if total value exceeds 21
            while (total > 21 && aces > 0)
            {
                total -= 10; //Count ace as 1 instead of 11
                aces--; //Decrement number of aces
            }
            return total; //Return total value of hand
        }

        //Get list of cards in the hand
        public List<Card> GetCards()
        {
            return cards;
        }

        public void ClearCards()
        {
            cards.Clear();
        }
    }
}
