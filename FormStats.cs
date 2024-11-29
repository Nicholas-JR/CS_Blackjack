using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_Roach_CPT_185_Final_Project
{
    public partial class FormStats : Form
    {
        //Constructor that accepts the stats parameters
        public FormStats(int handsPlayed, int handsWon, float rtp,int balanceWagered, int highestBalance)
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //Don't allow the user to resize the form

            //Set the labels to the stats parameters
            handsPlayedLabel.Text = $"{SessionStats.HandsPlayed}";
            handsWonLabel.Text = $"{SessionStats.HandsWon}";
            rtpLabel.Text = $"{SessionStats.RTP:F2}%";
            balanceWageredLabel.Text = $"{SessionStats.BalanceWagered}";
            highestBalanceLabel.Text = $"{SessionStats.HighestBalance}";
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
