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
    public partial class Form5 : Form
    {
        string user;
        string title;
        public Form5(string user, string title, int progress)
        {
            InitializeComponent();
            this.user = user;
            this.title = title;
            updateProg_trackBar.Minimum = progress;
            percentProg_label.Text = progress + "%";
        }

        private void updateProg_trackBar_Scroll(object sender, EventArgs e)
        {
            percentProg_label.Text = updateProg_trackBar.Value + "%";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string file = user + "_book_data.txt";
            StreamReader streamReader = new StreamReader(path: file);
            string line = string.Empty;
            int index = 0;
            int noLine = 0;
            while ((line = streamReader.ReadLine()) != null)
            {
                noLine++;
                string[] tempArray = line.Split(new char[] { ':' }, 2);
                if (tempArray[0].Equals("Title") && tempArray[1].Equals(this.title))
                    index = noLine;
            }
            streamReader.Close();
            if (index != 0)
            {
                string[] allLines = File.ReadAllLines(file);
                allLines[index + 4] = "Progress: " + updateProg_trackBar.Value;
                File.WriteAllLines(file, allLines);
            }
            MessageBox.Show("Your progress has been saved!", "Update successfull!");
            this.Close();
        }

        private void bookFinished_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 form6 = new Form6(user, title);
            form6.Show();
            this.Close();
        }
    }
}
