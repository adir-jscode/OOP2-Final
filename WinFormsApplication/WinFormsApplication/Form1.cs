using Login_Form;
using System.Windows.Forms;
using System;

namespace WinFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                //errorProvider1.Icon = Properties.Resources.error;
                //errorProvider1.SetError(this.textBox1, "Enter your name please!");
                MessageBox.Show("Enter your username please!");
            }
            else
            {
                //errorProvider1.Icon = Properties.Resources.check;
                //errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                //errorProvider2.Icon = Properties.Resources.error;
                //errorProvider2.SetError(this.textBox2, "Enter your salary please!");
                MessageBox.Show("Enter your passsword please!");
            }
            else
            {
                //errorProvider2.Icon = Properties.Resources.check;
                //errorProvider2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Morning");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DB.Get.LoginAuth(textBox1.Text, textBox2.Text);
            MessageBox.Show("Welcome to our System");

            //Register main = new Register();
            //main.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //check null or empty
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                //errorProvider1.Icon = System.Properties.Resources.error;
                errorProvider1.SetError(this.textBox1, "Enter your email please!");
                MessageBox.Show("Enter your email please!");
            }
            else
            {
                //errorProvider1.Icon = Properties.Resources.check;
                errorProvider1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register main = new Register();
            main.Show();
        }
    }
}