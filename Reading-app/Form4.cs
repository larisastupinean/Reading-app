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
    public partial class Form4 : Form
    {
        string user;
        public Form4(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uploadPhoto_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(Image.FromFile(uploadPhoto_openFileDialog.FileName));
                newBook_pictureBox.Image = new Bitmap(image, new Size(image.Width / 2, image.Height / 2));
            }
        }

        private void progress_trackBar_Scroll(object sender, EventArgs e)
        {
            prog_label.Text = progress_trackBar.Value + "%";
        }

        private void addBook_button_Click(object sender, EventArgs e)
        {
            string file = user + "_book_data.txt";
            StreamWriter streamWriter = new StreamWriter(file, true);
            if (!String.IsNullOrEmpty(title_textBox.Text))
                streamWriter.WriteLine("Title: " + title_textBox.Text);
            else
                MessageBox.Show("Enter the tile of the book!", "Error!");
            if (!String.IsNullOrEmpty(author_textBox.Text))
                streamWriter.WriteLine("Author: " + author_textBox.Text);
            else
                MessageBox.Show("Enter the author of the book!", "Error!");
            if ((!String.IsNullOrEmpty(title_textBox.Text)) && (!String.IsNullOrEmpty(author_textBox.Text)))
            {
                streamWriter.WriteLine("Photo: " + uploadPhoto_openFileDialog.FileName);
                streamWriter.WriteLine("Date started: " + dateStarted_dateTimePicker.Value);
                streamWriter.WriteLine("Date finished: ");
                streamWriter.WriteLine("Progress: " + progress_trackBar.Value);
                streamWriter.WriteLine("Rating: ");
                streamWriter.WriteLine("Comment: ");
                streamWriter.Close();
                MessageBox.Show("Your new book has been successfully added!", "Book added!");
                this.Close();
            }
        }
    }
}
