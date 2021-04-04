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
    public partial class Form6 : Form
    {
        string user;
        string title;
        public Form6(string user, string title)
        {
            InitializeComponent();
            this.user = user;
            this.title = title;
        }

        private void save_button_Click(object sender, EventArgs e)
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
                allLines[index + 3] = "Date finished: " + dateFinished_dateTimePicker.Value;
                allLines[index + 4] = "Progress: 100";
                allLines[index + 5] = "Rating: " + rating_numericUpDown.Value;
                allLines[index + 6] = "Comment: " + comment_richTextBox.Text;
                File.WriteAllLines(file, allLines);
            }
            MessageBox.Show("Your review has been saved!", "Good job! You finished another book!");
            this.Close();
        }
    }
}
