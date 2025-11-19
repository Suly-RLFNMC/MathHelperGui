using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathHelperGui
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double circrad;
            if (!double.TryParse(textBox1.Text, out circrad))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            double calc = (circrad * circrad) * Math.PI;
            MessageBox.Show($"The answer is {calc}!");
        }
    }
}
