using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Roach_CPT_185_Final_Project
{
    internal class Player
    {
        public Hand Hand { get; private set; } //Player hand

        //Player constructor
        public Player()
        {
            Hand = new Hand(); //Create a new hand object
        }
    }
}
