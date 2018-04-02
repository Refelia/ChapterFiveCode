using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tutorial5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a streamwriter variable.
                StreamWriter outputFile;

                //Create a file and create a streamwriter object.
                outputFile = File.CreateText("Friend.Text");

                //Create the friend's name to the file.
                outputFile.WriteLine(friendsNameTextBox.Text);

                //Close the file.
                outputFile.Close();

                //Let the user know the name was written.
                MessageBox.Show("The anme was written.");
            }
            catch(Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
