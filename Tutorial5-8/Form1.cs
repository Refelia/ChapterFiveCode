using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //Declare a variable to indicate which side is up.
            int sideUp;

            //Create a random object.
            Random rand = new Random();

            //Get the random integer in the range of 0 through 1. 
            //0 means tail up, 1 means head up.
            sideUp = rand.Next(2);

            //Display the side that is up.
            if (sideUp == 0)
            {
                //Display tails up.
                tailPictureBox.Visible = true;
                headPictureBox.Visible = false;
            }
            else
            {
                //Display heads up.
                headPictureBox.Visible = true;
                tailPictureBox.Visible = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
