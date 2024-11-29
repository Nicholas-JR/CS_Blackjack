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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //Don't allow the user to resize the form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
