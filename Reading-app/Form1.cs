﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickHere_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Boolean username = false;
            Boolean password = false;
            string user = string.Empty;
            if (File.Exists("user_data.txt"))
            {
                StreamReader streamReader = new StreamReader(path: "user_data.txt");
                string line = string.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] tempArray = line.Split(' ');
                    if ((tempArray[0].Equals("Username:")) && (tempArray[1].Equals(username_textBox.Text)))
                    {
                        username = true;
                        user = tempArray[1];
                    }
                    if ((tempArray[0].Equals("Password:")) && (tempArray[1].Equals(password_textBox.Text)))
                        password = true;
                }
                if (!String.IsNullOrEmpty(username_textBox.Text) && !String.IsNullOrEmpty(password_textBox.Text))
                {
                    if (username && password)
                    {
                        this.Visible = false;
                        Form3 form3 = new Form3(user);
                        form3.Show();
                    }
                    else
                        MessageBox.Show("Invalid username or password!", "Error!");
                }
                else if (String.IsNullOrEmpty(username_textBox.Text))
                    MessageBox.Show("Enter username!", "Error!");
                else if (String.IsNullOrEmpty(password_textBox.Text))
                    MessageBox.Show("Enter password!", "Error!");
            }
            else if (String.IsNullOrEmpty(username_textBox.Text))
                MessageBox.Show("Enter username!", "Error!");
            else if (String.IsNullOrEmpty(password_textBox.Text))
                MessageBox.Show("Enter password!", "Error!");
            else
                MessageBox.Show("Invalid username or password!", "Error!");
        }
    }
}
