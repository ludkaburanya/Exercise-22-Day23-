namespace z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "14,26";
            textBox2.Text = "-1,22";
            textBox3.Text = "0,035";
            textBox4.Text = "0,564849";
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox5.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox5.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox5.Text += Environment.NewLine + "Z = " + z.ToString();
            double t = double.Parse(textBox4.Text);
            textBox5.Text += Environment.NewLine + "t = " + t.ToString();

            double a = 2 * Math.Cos(x - (3.14 / 6));
            double b = 0.5 + Math.Pow(Math.Sin(y), 2);
            double c = 1 + (Math.Pow(z, 2) / 3 - (Math.Pow(z, 2) / 5));

            double u = a / b * c;

            textBox5.Text += Environment.NewLine + "Результат U = " + u.ToString();
        }
    }
}