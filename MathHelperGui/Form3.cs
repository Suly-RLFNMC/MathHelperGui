using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathHelperGui
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double recleng1;
            double recleng2;

            if (!double.TryParse(textBox1.Text, out recleng1))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
            if (!double.TryParse(textBox2.Text, out recleng2))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            double calc = recleng1 * recleng2;
            MessageBox.Show($"The answer is {calc}!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
