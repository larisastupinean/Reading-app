
namespace Reading_app
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBook_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.author_textBox = new System.Windows.Forms.TextBox();
            this.newBook_pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uploadPhoto_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dateStarted_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateStarted_label = new System.Windows.Forms.Label();
            this.progress_label = new System.Windows.Forms.Label();
            this.progress_trackBar = new System.Windows.Forms.TrackBar();
            this.prog_label = new System.Windows.Forms.Label();
            this.addBook_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newBook_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // addBook_label
            // 
            this.addBook_label.AutoSize = true;
            this.addBook_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_label.Location = new System.Drawing.Point(210, 23);
            this.addBook_label.Name = "addBook_label";
            this.addBook_label.Size = new System.Drawing.Size(186, 29);
            this.addBook_label.TabIndex = 0;
            this.addBook_label.Text = "Add a new book";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(58, 121);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(41, 20);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Title";
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_label.Location = new System.Drawing.Point(58, 164);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(58, 20);
            this.author_label.TabIndex = 2;
            this.author_label.Text = "Author";
            // 
            // title_textBox
            // 
            this.title_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_textBox.Location = new System.Drawing.Point(173, 114);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(350, 27);
            this.title_textBox.TabIndex = 3;
            // 
            // author_textBox
            // 
            this.author_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_textBox.Location = new System.Drawing.Point(173, 161);
            this.author_textBox.Name = "author_textBox";
            this.author_textBox.Size = new System.Drawing.Size(350, 27);
            this.author_textBox.TabIndex = 4;
            // 
            // newBook_pictureBox
            // 
            this.newBook_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newBook_pictureBox.Location = new System.Drawing.Point(62, 349);
            this.newBook_pictureBox.Name = "newBook_pictureBox";
            this.newBook_pictureBox.Size = new System.Drawing.Size(217, 271);
            this.newBook_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.newBook_pictureBox.TabIndex = 5;
            this.newBook_pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(333, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Upload photo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uploadPhoto_openFileDialog
            // 
            this.uploadPhoto_openFileDialog.Filter = "\"Image Files (*.jfif;*.jpg;*.jpeg;.*.gif;)|*.jfif;*.jpg;*.jpeg;.*.gif\"";
            this.uploadPhoto_openFileDialog.Title = "Upload photo";
            // 
            // dateStarted_dateTimePicker
            // 
            this.dateStarted_dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStarted_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStarted_dateTimePicker.Location = new System.Drawing.Point(193, 211);
            this.dateStarted_dateTimePicker.Name = "dateStarted_dateTimePicker";
            this.dateStarted_dateTimePicker.Size = new System.Drawing.Size(330, 27);
            this.dateStarted_dateTimePicker.TabIndex = 8;
            // 
            // dateStarted_label
            // 
            this.dateStarted_label.AutoSize = true;
            this.dateStarted_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStarted_label.Location = new System.Drawing.Point(58, 216);
            this.dateStarted_label.Name = "dateStarted_label";
            this.dateStarted_label.Size = new System.Drawing.Size(102, 20);
            this.dateStarted_label.TabIndex = 9;
            this.dateStarted_label.Text = "Date started";
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_label.Location = new System.Drawing.Point(58, 272);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(77, 20);
            this.progress_label.TabIndex = 10;
            this.progress_label.Text = "Progress";
            // 
            // progress_trackBar
            // 
            this.progress_trackBar.Location = new System.Drawing.Point(173, 272);
            this.progress_trackBar.Maximum = 100;
            this.progress_trackBar.Name = "progress_trackBar";
            this.progress_trackBar.Size = new System.Drawing.Size(251, 56);
            this.progress_trackBar.TabIndex = 11;
            this.progress_trackBar.Scroll += new System.EventHandler(this.progress_trackBar_Scroll);
            // 
            // prog_label
            // 
            this.prog_label.AutoSize = true;
            this.prog_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prog_label.Location = new System.Drawing.Point(453, 272);
            this.prog_label.Name = "prog_label";
            this.prog_label.Size = new System.Drawing.Size(0, 20);
            this.prog_label.TabIndex = 12;
            // 
            // addBook_button
            // 
            this.addBook_button.BackColor = System.Drawing.Color.MediumPurple;
            this.addBook_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_button.Location = new System.Drawing.Point(229, 681);
            this.addBook_button.Name = "addBook_button";
            this.addBook_button.Size = new System.Drawing.Size(167, 45);
            this.addBook_button.TabIndex = 13;
            this.addBook_button.Text = "Add book";
            this.addBook_button.UseVisualStyleBackColor = false;
            this.addBook_button.Click += new System.EventHandler(this.addBook_button_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 754);
            this.Controls.Add(this.addBook_button);
            this.Controls.Add(this.prog_label);
            this.Controls.Add(this.progress_trackBar);
            this.Controls.Add(this.progress_label);
            this.Controls.Add(this.dateStarted_label);
            this.Controls.Add(this.dateStarted_dateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newBook_pictureBox);
            this.Controls.Add(this.author_textBox);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.author_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.addBook_label);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.newBook_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addBook_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.TextBox author_textBox;
        private System.Windows.Forms.PictureBox newBook_pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog uploadPhoto_openFileDialog;
        private System.Windows.Forms.DateTimePicker dateStarted_dateTimePicker;
        private System.Windows.Forms.Label dateStarted_label;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.TrackBar progress_trackBar;
        private System.Windows.Forms.Label prog_label;
        private System.Windows.Forms.Button addBook_button;
    }
}