using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reading_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("user_data.txt", true);
            if (!String.IsNullOrEmpty(newEmail_textBox.Text))
                streamWriter.WriteLine("Email: " + newEmail_textBox.Text);
            else
                MessageBox.Show("Enter your email address!", "Error!");
            if (!String.IsNullOrEmpty(newUsername_textBox.Text))
                streamWriter.WriteLine("Username: " + newUsername_textBox.Text);
            else
                MessageBox.Show("Enter a username!", "Error!");
            if (!String.IsNullOrEmpty(newPass_textBox.Text))
                streamWriter.WriteLine("Password: " + newPass_textBox.Text);
            else
                MessageBox.Show("Enter a password!", "Error!");
            if ((!String.IsNullOrEmpty(newEmail_textBox.Text)) && (!String.IsNullOrEmpty(newUsername_textBox.Text)) && (!String.IsNullOrEmpty(newPass_textBox.Text)))
            {
                MessageBox.Show("Your new account was created successfully! Now you can log in and begin your magical reading journey!",
                    "Welcome " + newUsername_textBox.Text + "!");
                streamWriter.Close();
                this.Close();
            }
        }
    }
}
