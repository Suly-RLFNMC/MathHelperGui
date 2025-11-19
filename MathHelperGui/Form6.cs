using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathHelperGui
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double coneheight;
            double conrad;
            if (!double.TryParse(textBox2.Text, out coneheight))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
            if (!double.TryParse(textBox1.Text, out conrad))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
            double calc = (1.0 / 3.0) * Math.PI * conrad * conrad * coneheight;
            MessageBox.Show($"The answer is {calc}!");
        }
    }
}
