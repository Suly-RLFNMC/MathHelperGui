using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathHelperGui
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double baseleng;
            double height;
            if (!double.TryParse(textBox1.Text, out height))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
            if (!double.TryParse(textBox2.Text, out baseleng))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
            double calc = (baseleng * height) / 2;
            MessageBox.Show($"The answer is {calc}!");
        }
    }
}
