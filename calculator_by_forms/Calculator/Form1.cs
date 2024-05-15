namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button4.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button9.Text;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button0.Text;
        }
    }
}
