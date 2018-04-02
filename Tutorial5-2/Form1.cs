using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            //Create a constant field.
            const decimal INTEREST_RATE = 0.005m;

            //Declare a local variables for .
            decimal balance;
            int months;
            int count = 1; //This is a loop counter initialized with 1.

            //Get the starting balnce.
            if (decimal.TryParse(startingBalncetextBox.Text, out balance))
            {
                //Get the number of months.
                if (int.TryParse(numberOfMonthsTextBox.Text, out months))
                {
                    //The followin loop calculates  the ending balance.
                    while (count <= months)
                    {
                        //Add this month's interest to the balance.
                        balance = balance + (INTEREST_RATE * balance);

                        //Display the month's ending balance.
                        listBox1.Items.Add("The ending balance" + "for month " + count + " is " + balance.ToString("c"));
                    

                        //Add one to  the loop counter.
                        count = count + 1;

                    }
                    //Display the ending balance.
                    endingBalnceOutputLabel.Text = balance.ToString("c");
                }
                else
                {
                    //Invalid number of months was intered.
                    MessageBox.Show("Ivalid value for months.");
                }
            }
            else
            {
                //Invalid starting balance invalid.
                MessageBox.Show("Ivalid value for starting balance");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear all the inputs.
            startingBalncetextBox.Text = "";
            numberOfMonthsTextBox.Text = "";
            endingBalnceOutputLabel.Text = "";

            //Reset the focus.
            startingBalncetextBox.Focus();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            //Clear all the inputs.
            startingBalncetextBox.Text = "";
            numberOfMonthsTextBox.Text = "";
            endingBalnceOutputLabel.Text = "";
            listBox1.Text = "";

            //Reset the focus.
            startingBlanceLabel.Focus();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
  
