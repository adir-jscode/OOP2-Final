using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApplication;

namespace Login_Form
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string Name = textBox1.Text;
            string Email = textBox2.Text;
            string Password = textBox3.Text;
            string Phone = textBox4.Text;

           

            //null or empty
            if (string.IsNullOrEmpty(Name))
            {
                textBox1.Focus();
                MessageBox.Show("Enter your name please!");
            }
            else if (string.IsNullOrEmpty(Email))
            {
                textBox2.Focus();
                MessageBox.Show("Enter your email please!");
            }
            else if (string.IsNullOrEmpty(Password))
            {
                textBox3.Focus();
                MessageBox.Show("Enter your password please!");
            }
            else if (string.IsNullOrEmpty(Phone))
            {
                textBox4.Focus();
                MessageBox.Show("Enter your phone please!");
            }
            else
            {
                
                DB.Get.Register(Name, Email, Password, Phone);

                MessageBox.Show("User Registered Successfully");

                Form1 main = new Form1();
                main.Show();
                // errorProvider1.Icon = Properties.Resources.check;
                errorProvider1.Clear();
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
