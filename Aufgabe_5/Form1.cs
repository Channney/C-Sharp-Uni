using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_5
{
    public partial class Form1 : Form
    {
        private object int32;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

                double stunden = Double.Parse(textBox1.Text);
                double sekunden1 = stunden * 3600;

                double minuten = Double.Parse(textBox2.Text);
                double sekunden2 = minuten * 60;

                double sekunden3 = Double.Parse(textBox3.Text);

                double teins = sekunden1 + sekunden2 + sekunden3;


                double stunden1 = Double.Parse(textBox6.Text);
                double sekunden4 = stunden1 * 3600;

                double minuten1 = Double.Parse(textBox5.Text);
                double sekunden5 = minuten1 * 60;

                double sekunden6 = Double.Parse(textBox4.Text);

                double tzwei = sekunden4 + sekunden5 + sekunden6;

            double ergebnis = tzwei - teins;

        
            
            int stundenneu = Convert.ToInt32(ergebnis/3600);
            double rest1 = ergebnis%3600;

            int minutenneu = Convert.ToInt32(rest1/60);
            double rest2  = rest1 % 60;

            textBox9.Text = $"{stundenneu}";
            textBox8.Text = $"{minutenneu}";
            textBox7.Text = $"{rest2}".Replace(",",".");










        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            textBox9.Text = "0";
            textBox8.Text = "0";
            textBox7.Text = "0.000";


        }
    }
}
