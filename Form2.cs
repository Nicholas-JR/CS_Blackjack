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
    //Main screen form
    public partial class mainForm : Form
    {
        private gameForm gameFormInstance; //Instance of the game form
        public mainForm()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //Don't allow the user to resize the form
            gameFormInstance = new gameForm();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
        }

        //Play main game, hide main form
        private void playBtn_Click(object sender, EventArgs e)
        {
            gameFormInstance.Show();
            this.Hide();
        }

        //Show help form
        private void howToPlayBtn_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        //Application close button
        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Show stats form, pass in the session stats
        private void statsBtn_Click(object sender, EventArgs e)
        {
            FormStats statsForm = new FormStats(
                SessionStats.HandsPlayed,
                SessionStats.HandsWon,
                SessionStats.RTP,
                SessionStats.BalanceWagered,
                SessionStats.HighestBalance
            );
            statsForm.ShowDialog();
        }
    }
}
