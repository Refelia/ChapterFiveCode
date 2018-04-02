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

namespace Tutorial5_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a variables.
                decimal sales;
                decimal total = 0m;

                //Declare a streamreader variable
                StreamReader inputFile;

                //Open the file and get streamreader object.
                inputFile = File.OpenText("Sales.txt");

                //Read the file's contents.
                while (!inputFile.EndOfStream) 
                {
                    //Gte the sales amount.
                    sales = decimal.Parse(inputFile.ReadLine());

                    //Add the sales amount the total.
                    total += sales;
                }
                //Close the file
                inputFile.Close();

                //Display the total.
                totalLabel.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                //Display default error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close te form.
            this.Close();
        }
    }
}
