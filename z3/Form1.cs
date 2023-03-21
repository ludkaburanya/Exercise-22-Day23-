namespace z3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox6.Text);
            double c = Convert.ToDouble(textBox7.Text);
            textBox5.Text = "Работу выполнила ст. Беленица Л.А." + Environment.NewLine;

            double x = x0;
            while (x <=(xk + dx / 2))
            {
                double y = (0.01 * (b * c) / x + (Math.Cos(Math.Pow(a, 3)) * x));
                textBox5.Text += "x=" + Convert.ToString(x) + "; y =" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}