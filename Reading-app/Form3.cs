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
    public partial class Form3 : Form
    {
        string user;
        int progress;
        public Form3(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void addBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(user);
            form4.Show();
        }

        private void refreshPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yourBooks_comboBox.Items.Clear();
            string file = user + "_book_data.txt";
            if (File.Exists(file))
            {
                StreamReader streamReader = new StreamReader(path: file);
                string line = string.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] tempArray = line.Split(new char[] { ':' }, 2);
                    if (tempArray[0].Equals("Title"))
                        yourBooks_comboBox.Items.Add(tempArray[1]);
                }
                streamReader.Close();
            }
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yourBooks_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBook_panel.Visible = true;
            StreamReader streamReader = new StreamReader(path: user + "_book_data.txt");
            string line = string.Empty;
            int noLine = 0;
            int index = 0;
            while ((line = streamReader.ReadLine()) != null)
            {
                noLine++;
                string[] tempArray = line.Split(new char[] { ':' }, 2);
                if (tempArray[0].Equals("Title") && (tempArray[1].Equals(yourBooks_comboBox.SelectedItem)))
                {
                    index = noLine;
                }
                if ((index != 0) && (noLine == (index + 3)) && (tempArray[0].Equals("Date started")))
                    dateStarted_textBox.Text = tempArray[1];
                if ((index != 0) && (noLine == (index + 4)) && (tempArray[0].Equals("Date finished")))
                    dateFinished_textBox.Text = tempArray[1];
                if ((index != 0) && (noLine == (index + 5)) && (tempArray[0].Equals("Progress")))
                {
                    this.progress = Convert.ToInt32(tempArray[1]);
                    selectedBook_progressBar.Value = Convert.ToInt32(tempArray[1]);
                    selectedBookProg_label.Text = tempArray[1] + '%';
                }
            }
            streamReader.Close();
        }

        private void updateProgressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (yourBooks_comboBox.SelectedItem != null)
            {
                Form5 form5 = new Form5(user, yourBooks_comboBox.SelectedItem.ToString(), this.progress);
                form5.Show();
            }
            else
                MessageBox.Show("Choose a book!", "Error!");
        }

        private void finishedBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (yourBooks_comboBox.SelectedItem != null)
            {
                Form6 form6 = new Form6(user, yourBooks_comboBox.SelectedItem.ToString());
                form6.Show();
            }
            else
                MessageBox.Show("Choose a book!", "Error!");
        }

        private void refreshPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reviewBooks_comboBox.Items.Clear();
            string file = user + "_book_data.txt";
            if (File.Exists(file))
            {
                StreamReader streamReader = new StreamReader(path: file);
                string line = string.Empty;
                string title = string.Empty;
                int noLine = 0;
                int index = 0;
                while ((line = streamReader.ReadLine()) != null)
                {
                    noLine++;
                    string[] tempArray = line.Split(new char[] { ':' }, 2);
                    if (tempArray[0].Equals("Title"))
                    {
                        index = noLine;
                        title = tempArray[1];
                    }

                    if ((index != 0) && (noLine == (index + 5)) && (line.Equals("Progress: 100")))
                        reviewBooks_comboBox.Items.Add(title);
                }
                streamReader.Close();
            }
        }

        private void reviewBooks_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            review_groupBox.Visible = true;
            StreamReader streamReader = new StreamReader(path: user + "_book_data.txt");
            string line = string.Empty;
            int noLine = 0;
            int index = 0;
            while ((line = streamReader.ReadLine()) != null)
            {
                noLine++;
                string[] tempArray = line.Split(new char[] { ':' }, 2);
                if (tempArray[0].Equals("Title") && (tempArray[1].Equals(reviewBooks_comboBox.SelectedItem)))
                {
                    index = noLine;
                    title_textBox.Text = tempArray[1];
                }
                if ((index != 0) && (noLine == (index + 1)) && (tempArray[0].Equals("Author")))
                    author_textBox.Text = tempArray[1];
                if ((index != 0) && (noLine == (index + 2)) && (tempArray[0].Equals("Photo")) && (!tempArray[1].Equals(" ")))
                {
                    Bitmap image = new Bitmap(Image.FromFile(tempArray[1]));
                    reviewBook_pictureBox.Image = new Bitmap(image, new Size(image.Width / 2, image.Height / 2));
                }
                if ((index != 0) && (noLine == (index + 3)) && (tempArray[0].Equals("Date started")))
                    revDateStarted_textBox.Text = tempArray[1];
                if ((index != 0) && (noLine == (index + 4)) && (tempArray[0].Equals("Date finished")))
                    revDateFinished_textBox.Text = tempArray[1];
                if ((index != 0) && (noLine == (index + 6)) && (tempArray[0].Equals("Rating")))
                    valueRating_label.Text = tempArray[1] + "/10";
                if ((index != 0) && (noLine == (index + 7)) && (tempArray[0].Equals("Comment")))
                    comment_richTextBox.Text = tempArray[1];
            }
            streamReader.Close();
        }

        private void closeAppToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
