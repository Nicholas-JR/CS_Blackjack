using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Roach_CPT_185_Final_Project
{
    //Session stats class
    internal class SessionStats
    {
        public static int HandsPlayed { get; set; } = 0;
        public static int HandsWon { get; set; } = 0;
        public static int BalanceWagered { get; set; } = 0;
        public static int HighestBalance { get; set; } = 100;
        public static float RTP => HandsPlayed > 0 ? (HandsWon * 100f / HandsPlayed) : 0; //Calculate the RTP (return to player %)
    }
}
