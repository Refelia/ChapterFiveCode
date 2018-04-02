using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Constant field.
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;

            //Declare a variables for;
            int kph;
            double mph;

            //Display the table of speeds.
            for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
            {
                //Calculate miles per hour.
                mph = kph * CONVERSION_FACTOR;

                //Display the conversion.
                listBox1.Items.Add(kph + " KPH is the same as " + mph  + " MPH ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close the form.
            this.Close();
        }
    }
}