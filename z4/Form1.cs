namespace z4
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            textBox6.Text += Environment.NewLine + "Фамилия: " + x;
            string y = textBox2.Text;
            textBox6.Text += Environment.NewLine + "Имя: " + y;
            string z = textBox3.Text;
            textBox6.Text += Environment.NewLine + "Отчество: " + z;

            if(radioButton1.Checked)
            {
                textBox6.Text += Environment.NewLine + "Пол: " + radioButton1.Text;
            }
            if(radioButton2.Checked)
            {
                textBox6.Text += Environment.NewLine + "Пол: " + radioButton2.Text;
            }
            textBox6.Text += Environment.NewLine + "Дата рождения ";
            textBox6.Text += Environment.NewLine + "День: " + comboBox3.Text;
            textBox6.Text += Environment.NewLine + "Месяц: " + comboBox2.Text;
            textBox6.Text += Environment.NewLine + "Год: " + comboBox1.Text;
            textBox6.Text += Environment.NewLine + "Место проживания: " + comboBox4.Text;
            textBox6.Text += Environment.NewLine + "Адрес электронной почты: " + textBox4.Text;
            textBox6.Text += Environment.NewLine + "Мобильный телефон: " + textBox5.Text + comboBox5.Text;

            if (radioButton3.Checked)
            {
                textBox6.Text += Environment.NewLine + "Опыть работы: " + radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                textBox6.Text += Environment.NewLine + "Опыть работы: " + radioButton4.Text;
            }
            if (radioButton5.Checked)
            {
                textBox6.Text += Environment.NewLine + "Опыть работы: " + radioButton5.Text;
            }
            if (radioButton6.Checked)
            {
                textBox6.Text += Environment.NewLine + "Опыть работы: " + radioButton6.Text;
            }
            if (radioButton7.Checked)
            {
                textBox6.Text += Environment.NewLine + "Опыть работы: " + radioButton7.Text;
            }

            textBox6.Text += Environment.NewLine + "Другие сведенья";

            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox1.Text;
                textBox6.Text += Environment.NewLine + checkBox2.Text;
            }
            if (checkBox1.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox2.Text;

            }
            if (checkBox3.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox4.Text;
            }
            if (checkBox5.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox5.Text;
            }
            if (checkBox6.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox6.Text;
            }

            textBox6.Text += Environment.NewLine + "Объем заработной платы: От " + domainUpDown2.Text + " До " + domainUpDown1.Text;
            textBox6.Text += Environment.NewLine + "Предпочитаемый график: ";
            if (radioButton8.Checked)
            {
                textBox6.Text += radioButton8.Text + Environment.NewLine;
            }
            if (radioButton9.Checked)
            {
                textBox6.Text += radioButton9.Text + Environment.NewLine;
            }
            if (radioButton10.Checked)
            {
                textBox6.Text += radioButton10.Text + Environment.NewLine;
            }
            if (radioButton11.Checked)
            {
                textBox6.Text += radioButton11.Text + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}