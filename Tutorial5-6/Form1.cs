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

namespace Tutorial5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a variable to hold the Countries name.
                string CountryName;

                //Declare a treamreader variable.
                StreamReader inputFile;

                //Open the file and get the streamreader  object.
                inputFile = File.OpenText("Countries.txt");

                //Clear anything currently in the listbox.
                listBox1.Items.Clear();

                //Read the file contents,
                while(!inputFile.EndOfStream)
                {
                    //Get  a Country name.
                    CountryName = inputFile.ReadLine();

                    //Add the Country name to the listBox
                    listBox1.Items.Add(CountryName);

                }
                //Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //Dispaly the default error message.
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
