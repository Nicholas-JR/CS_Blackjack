using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Roach_CPT_185_Final_Project
{

    //This class is used to create a card object with a suit, rank, and value
    internal class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
        public int Value { get; set; }

        public Card(string suit, string rank, int value) //If parameters are ordered wrong, aces will always be 11
        {
            Suit = suit;
            Rank = rank;
            Value = value;
        }

        //Return the cards suit and rank as a string
        public override string ToString()
        {
            return $"{Suit}_{Rank}";
        }
    }
}
