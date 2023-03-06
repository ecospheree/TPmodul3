namespace TPmodul3_1302210049
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            label1.Text = " 안녕하세요 "+ input;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}