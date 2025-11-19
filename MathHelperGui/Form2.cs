using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathHelperGui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double sqrleng;

            if (!double.TryParse(textBox1.Text, out sqrleng))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            double calc = sqrleng * sqrleng;
            MessageBox.Show($"The answer is {calc}!");
        }




    }
}
