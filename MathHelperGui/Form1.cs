namespace MathHelperGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sqr_areacalc = new Form2();
            sqr_areacalc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 rec_areacalc = new Form3();
            rec_areacalc.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 circ_areacalc = new Form4();
            circ_areacalc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 tri_areacalc = new Form5();
            tri_areacalc.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
