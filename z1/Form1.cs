namespace z1
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
            BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }
    }
}