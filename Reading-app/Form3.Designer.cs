
namespace Reading_app
{
    partial class Form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.overview_tabPage = new System.Windows.Forms.TabPage();
            this.overBooks_groupBox = new System.Windows.Forms.GroupBox();
            this.yourBooks_comboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProgressToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.finishedBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.review_tabPage = new System.Windows.Forms.TabPage();
            this.selectedBook_panel = new System.Windows.Forms.Panel();
            this.overProg_label = new System.Windows.Forms.Label();
            this.selectedBook_progressBar = new System.Windows.Forms.ProgressBar();
            this.dateStarted_label = new System.Windows.Forms.Label();
            this.dateStarted_textBox = new System.Windows.Forms.TextBox();
            this.dateFinished_label = new System.Windows.Forms.Label();
            this.dateFinished_textBox = new System.Windows.Forms.TextBox();
            this.selectedBookProg_label = new System.Windows.Forms.Label();
            this.reviewBooks_comboBox = new System.Windows.Forms.ComboBox();
            this.chooseBook_label = new System.Windows.Forms.Label();
            this.review_groupBox = new System.Windows.Forms.GroupBox();
            this.title_label = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            this.reviewBook_pictureBox = new System.Windows.Forms.PictureBox();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.author_textBox = new System.Windows.Forms.TextBox();
            this.revDateStarted_label = new System.Windows.Forms.Label();
            this.revDateFinished_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.revDateStarted_textBox = new System.Windows.Forms.TextBox();
            this.revDateFinished_textBox = new System.Windows.Forms.TextBox();
            this.valueRating_label = new System.Windows.Forms.Label();
            this.comment_label = new System.Windows.Forms.Label();
            this.comment_richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshPageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAppToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.overview_tabPage.SuspendLayout();
            this.overBooks_groupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.review_tabPage.SuspendLayout();
            this.selectedBook_panel.SuspendLayout();
            this.review_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBook_pictureBox)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.overview_tabPage);
            this.tabControl1.Controls.Add(this.review_tabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 723);
            this.tabControl1.TabIndex = 0;
            // 
            // overview_tabPage
            // 
            this.overview_tabPage.Controls.Add(this.overBooks_groupBox);
            this.overview_tabPage.Controls.Add(this.menuStrip1);
            this.overview_tabPage.Location = new System.Drawing.Point(4, 29);
            this.overview_tabPage.Name = "overview_tabPage";
            this.overview_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.overview_tabPage.Size = new System.Drawing.Size(754, 690);
            this.overview_tabPage.TabIndex = 0;
            this.overview_tabPage.Text = "Overview";
            this.overview_tabPage.UseVisualStyleBackColor = true;
            // 
            // overBooks_groupBox
            // 
            this.overBooks_groupBox.Controls.Add(this.selectedBook_panel);
            this.overBooks_groupBox.Controls.Add(this.yourBooks_comboBox);
            this.overBooks_groupBox.Location = new System.Drawing.Point(77, 89);
            this.overBooks_groupBox.Name = "overBooks_groupBox";
            this.overBooks_groupBox.Size = new System.Drawing.Size(584, 371);
            this.overBooks_groupBox.TabIndex = 1;
            this.overBooks_groupBox.TabStop = false;
            this.overBooks_groupBox.Text = "Your books";
            // 
            // yourBooks_comboBox
            // 
            this.yourBooks_comboBox.BackColor = System.Drawing.SystemColors.Control;
            this.yourBooks_comboBox.FormattingEnabled = true;
            this.yourBooks_comboBox.Location = new System.Drawing.Point(25, 46);
            this.yourBooks_comboBox.Name = "yourBooks_comboBox";
            this.yourBooks_comboBox.Size = new System.Drawing.Size(524, 28);
            this.yourBooks_comboBox.Sorted = true;
            this.yourBooks_comboBox.TabIndex = 0;
            this.yourBooks_comboBox.SelectedIndexChanged += new System.EventHandler(this.yourBooks_comboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "overview_menuStrip";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.refreshPageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem1,
            this.updateProgressToolStripMenuItem1,
            this.finishedBookToolStripMenuItem1});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addBookToolStripMenuItem1
            // 
            this.addBookToolStripMenuItem1.Name = "addBookToolStripMenuItem1";
            this.addBookToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.addBookToolStripMenuItem1.Text = "Add book";
            this.addBookToolStripMenuItem1.Click += new System.EventHandler(this.addBookToolStripMenuItem1_Click);
            // 
            // updateProgressToolStripMenuItem1
            // 
            this.updateProgressToolStripMenuItem1.Name = "updateProgressToolStripMenuItem1";
            this.updateProgressToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.updateProgressToolStripMenuItem1.Text = "Update progress";
            this.updateProgressToolStripMenuItem1.Click += new System.EventHandler(this.updateProgressToolStripMenuItem1_Click);
            // 
            // finishedBookToolStripMenuItem1
            // 
            this.finishedBookToolStripMenuItem1.Name = "finishedBookToolStripMenuItem1";
            this.finishedBookToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.finishedBookToolStripMenuItem1.Text = "Finished book";
            this.finishedBookToolStripMenuItem1.Click += new System.EventHandler(this.finishedBookToolStripMenuItem1_Click);
            // 
            // refreshPageToolStripMenuItem
            // 
            this.refreshPageToolStripMenuItem.Name = "refreshPageToolStripMenuItem";
            this.refreshPageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.refreshPageToolStripMenuItem.Text = "Refresh page";
            this.refreshPageToolStripMenuItem.Click += new System.EventHandler(this.refreshPageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAppToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // closeAppToolStripMenuItem
            // 
            this.closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            this.closeAppToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeAppToolStripMenuItem.Text = "Close app";
            this.closeAppToolStripMenuItem.Click += new System.EventHandler(this.closeAppToolStripMenuItem_Click);
            // 
            // review_tabPage
            // 
            this.review_tabPage.Controls.Add(this.review_groupBox);
            this.review_tabPage.Controls.Add(this.chooseBook_label);
            this.review_tabPage.Controls.Add(this.reviewBooks_comboBox);
            this.review_tabPage.Controls.Add(this.menuStrip2);
            this.review_tabPage.Location = new System.Drawing.Point(4, 29);
            this.review_tabPage.Name = "review_tabPage";
            this.review_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.review_tabPage.Size = new System.Drawing.Size(754, 690);
            this.review_tabPage.TabIndex = 1;
            this.review_tabPage.Text = "Review";
            this.review_tabPage.UseVisualStyleBackColor = true;
            // 
            // selectedBook_panel
            // 
            this.selectedBook_panel.Controls.Add(this.selectedBookProg_label);
            this.selectedBook_panel.Controls.Add(this.dateFinished_textBox);
            this.selectedBook_panel.Controls.Add(this.dateFinished_label);
            this.selectedBook_panel.Controls.Add(this.dateStarted_textBox);
            this.selectedBook_panel.Controls.Add(this.dateStarted_label);
            this.selectedBook_panel.Controls.Add(this.selectedBook_progressBar);
            this.selectedBook_panel.Controls.Add(this.overProg_label);
            this.selectedBook_panel.Location = new System.Drawing.Point(25, 125);
            this.selectedBook_panel.Name = "selectedBook_panel";
            this.selectedBook_panel.Size = new System.Drawing.Size(524, 199);
            this.selectedBook_panel.TabIndex = 1;
            this.selectedBook_panel.Visible = false;
            // 
            // overProg_label
            // 
            this.overProg_label.AutoSize = true;
            this.overProg_label.Location = new System.Drawing.Point(41, 32);
            this.overProg_label.Name = "overProg_label";
            this.overProg_label.Size = new System.Drawing.Size(77, 20);
            this.overProg_label.TabIndex = 0;
            this.overProg_label.Text = "Progress";
            // 
            // selectedBook_progressBar
            // 
            this.selectedBook_progressBar.Location = new System.Drawing.Point(179, 29);
            this.selectedBook_progressBar.Name = "selectedBook_progressBar";
            this.selectedBook_progressBar.Size = new System.Drawing.Size(221, 23);
            this.selectedBook_progressBar.TabIndex = 1;
            // 
            // dateStarted_label
            // 
            this.dateStarted_label.AutoSize = true;
            this.dateStarted_label.Location = new System.Drawing.Point(41, 84);
            this.dateStarted_label.Name = "dateStarted_label";
            this.dateStarted_label.Size = new System.Drawing.Size(102, 20);
            this.dateStarted_label.TabIndex = 2;
            this.dateStarted_label.Text = "Date started";
            // 
            // dateStarted_textBox
            // 
            this.dateStarted_textBox.Location = new System.Drawing.Point(179, 81);
            this.dateStarted_textBox.Name = "dateStarted_textBox";
            this.dateStarted_textBox.ReadOnly = true;
            this.dateStarted_textBox.Size = new System.Drawing.Size(293, 27);
            this.dateStarted_textBox.TabIndex = 3;
            // 
            // dateFinished_label
            // 
            this.dateFinished_label.AutoSize = true;
            this.dateFinished_label.Location = new System.Drawing.Point(41, 137);
            this.dateFinished_label.Name = "dateFinished_label";
            this.dateFinished_label.Size = new System.Drawing.Size(108, 20);
            this.dateFinished_label.TabIndex = 4;
            this.dateFinished_label.Text = "Date finished";
            // 
            // dateFinished_textBox
            // 
            this.dateFinished_textBox.Location = new System.Drawing.Point(179, 134);
            this.dateFinished_textBox.Name = "dateFinished_textBox";
            this.dateFinished_textBox.ReadOnly = true;
            this.dateFinished_textBox.Size = new System.Drawing.Size(293, 27);
            this.dateFinished_textBox.TabIndex = 5;
            // 
            // selectedBookProg_label
            // 
            this.selectedBookProg_label.AutoSize = true;
            this.selectedBookProg_label.Location = new System.Drawing.Point(419, 32);
            this.selectedBookProg_label.Name = "selectedBookProg_label";
            this.selectedBookProg_label.Size = new System.Drawing.Size(0, 20);
            this.selectedBookProg_label.TabIndex = 6;
            // 
            // reviewBooks_comboBox
            // 
            this.reviewBooks_comboBox.FormattingEnabled = true;
            this.reviewBooks_comboBox.Location = new System.Drawing.Point(244, 64);
            this.reviewBooks_comboBox.Name = "reviewBooks_comboBox";
            this.reviewBooks_comboBox.Size = new System.Drawing.Size(407, 28);
            this.reviewBooks_comboBox.TabIndex = 0;
            this.reviewBooks_comboBox.SelectedIndexChanged += new System.EventHandler(this.reviewBooks_comboBox_SelectedIndexChanged);
            // 
            // chooseBook_label
            // 
            this.chooseBook_label.AutoSize = true;
            this.chooseBook_label.Location = new System.Drawing.Point(90, 67);
            this.chooseBook_label.Name = "chooseBook_label";
            this.chooseBook_label.Size = new System.Drawing.Size(106, 20);
            this.chooseBook_label.TabIndex = 1;
            this.chooseBook_label.Text = "Choose book";
            // 
            // review_groupBox
            // 
            this.review_groupBox.Controls.Add(this.comment_richTextBox);
            this.review_groupBox.Controls.Add(this.comment_label);
            this.review_groupBox.Controls.Add(this.valueRating_label);
            this.review_groupBox.Controls.Add(this.revDateFinished_textBox);
            this.review_groupBox.Controls.Add(this.revDateStarted_textBox);
            this.review_groupBox.Controls.Add(this.rating_label);
            this.review_groupBox.Controls.Add(this.revDateFinished_label);
            this.review_groupBox.Controls.Add(this.revDateStarted_label);
            this.review_groupBox.Controls.Add(this.author_textBox);
            this.review_groupBox.Controls.Add(this.title_textBox);
            this.review_groupBox.Controls.Add(this.reviewBook_pictureBox);
            this.review_groupBox.Controls.Add(this.author_label);
            this.review_groupBox.Controls.Add(this.title_label);
            this.review_groupBox.Location = new System.Drawing.Point(31, 117);
            this.review_groupBox.Name = "review_groupBox";
            this.review_groupBox.Size = new System.Drawing.Size(708, 567);
            this.review_groupBox.TabIndex = 2;
            this.review_groupBox.TabStop = false;
            this.review_groupBox.Text = "Your review";
            this.review_groupBox.Visible = false;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(31, 39);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(41, 20);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Title";
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Location = new System.Drawing.Point(31, 98);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(58, 20);
            this.author_label.TabIndex = 1;
            this.author_label.Text = "Author";
            // 
            // reviewBook_pictureBox
            // 
            this.reviewBook_pictureBox.Location = new System.Drawing.Point(476, 26);
            this.reviewBook_pictureBox.Name = "reviewBook_pictureBox";
            this.reviewBook_pictureBox.Size = new System.Drawing.Size(217, 271);
            this.reviewBook_pictureBox.TabIndex = 2;
            this.reviewBook_pictureBox.TabStop = false;
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(107, 32);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.ReadOnly = true;
            this.title_textBox.Size = new System.Drawing.Size(350, 27);
            this.title_textBox.TabIndex = 3;
            // 
            // author_textBox
            // 
            this.author_textBox.Location = new System.Drawing.Point(107, 91);
            this.author_textBox.Name = "author_textBox";
            this.author_textBox.ReadOnly = true;
            this.author_textBox.Size = new System.Drawing.Size(350, 27);
            this.author_textBox.TabIndex = 4;
            // 
            // revDateStarted_label
            // 
            this.revDateStarted_label.AutoSize = true;
            this.revDateStarted_label.Location = new System.Drawing.Point(31, 158);
            this.revDateStarted_label.Name = "revDateStarted_label";
            this.revDateStarted_label.Size = new System.Drawing.Size(102, 20);
            this.revDateStarted_label.TabIndex = 5;
            this.revDateStarted_label.Text = "Date started";
            // 
            // revDateFinished_label
            // 
            this.revDateFinished_label.AutoSize = true;
            this.revDateFinished_label.Location = new System.Drawing.Point(31, 215);
            this.revDateFinished_label.Name = "revDateFinished_label";
            this.revDateFinished_label.Size = new System.Drawing.Size(108, 20);
            this.revDateFinished_label.TabIndex = 6;
            this.revDateFinished_label.Text = "Date finished";
            // 
            // rating_label
            // 
            this.rating_label.AutoSize = true;
            this.rating_label.Location = new System.Drawing.Point(31, 277);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(57, 20);
            this.rating_label.TabIndex = 7;
            this.rating_label.Text = "Rating";
            // 
            // revDateStarted_textBox
            // 
            this.revDateStarted_textBox.Location = new System.Drawing.Point(158, 151);
            this.revDateStarted_textBox.Name = "revDateStarted_textBox";
            this.revDateStarted_textBox.ReadOnly = true;
            this.revDateStarted_textBox.Size = new System.Drawing.Size(299, 27);
            this.revDateStarted_textBox.TabIndex = 8;
            // 
            // revDateFinished_textBox
            // 
            this.revDateFinished_textBox.Location = new System.Drawing.Point(158, 212);
            this.revDateFinished_textBox.Name = "revDateFinished_textBox";
            this.revDateFinished_textBox.ReadOnly = true;
            this.revDateFinished_textBox.Size = new System.Drawing.Size(299, 27);
            this.revDateFinished_textBox.TabIndex = 9;
            // 
            // valueRating_label
            // 
            this.valueRating_label.AutoSize = true;
            this.valueRating_label.Location = new System.Drawing.Point(154, 277);
            this.valueRating_label.Name = "valueRating_label";
            this.valueRating_label.Size = new System.Drawing.Size(0, 20);
            this.valueRating_label.TabIndex = 10;
            // 
            // comment_label
            // 
            this.comment_label.AutoSize = true;
            this.comment_label.Location = new System.Drawing.Point(35, 341);
            this.comment_label.Name = "comment_label";
            this.comment_label.Size = new System.Drawing.Size(81, 20);
            this.comment_label.TabIndex = 11;
            this.comment_label.Text = "Comment";
            // 
            // comment_richTextBox
            // 
            this.comment_richTextBox.Location = new System.Drawing.Point(158, 341);
            this.comment_richTextBox.Name = "comment_richTextBox";
            this.comment_richTextBox.ReadOnly = true;
            this.comment_richTextBox.Size = new System.Drawing.Size(535, 212);
            this.comment_richTextBox.TabIndex = 12;
            this.comment_richTextBox.Text = "";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(748, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshPageToolStripMenuItem1});
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // refreshPageToolStripMenuItem1
            // 
            this.refreshPageToolStripMenuItem1.Name = "refreshPageToolStripMenuItem1";
            this.refreshPageToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.refreshPageToolStripMenuItem1.Text = "Refresh page";
            this.refreshPageToolStripMenuItem1.Click += new System.EventHandler(this.refreshPageToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAppToolStripMenuItem1});
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // closeAppToolStripMenuItem1
            // 
            this.closeAppToolStripMenuItem1.Name = "closeAppToolStripMenuItem1";
            this.closeAppToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.closeAppToolStripMenuItem1.Text = "Close app";
            this.closeAppToolStripMenuItem1.Click += new System.EventHandler(this.closeAppToolStripMenuItem1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 747);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.tabControl1.ResumeLayout(false);
            this.overview_tabPage.ResumeLayout(false);
            this.overview_tabPage.PerformLayout();
            this.overBooks_groupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.review_tabPage.ResumeLayout(false);
            this.review_tabPage.PerformLayout();
            this.selectedBook_panel.ResumeLayout(false);
            this.selectedBook_panel.PerformLayout();
            this.review_groupBox.ResumeLayout(false);
            this.review_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBook_pictureBox)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage overview_tabPage;
        private System.Windows.Forms.GroupBox overBooks_groupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAppToolStripMenuItem;
        private System.Windows.Forms.TabPage review_tabPage;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateProgressToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finishedBookToolStripMenuItem1;
        private System.Windows.Forms.Panel selectedBook_panel;
        private System.Windows.Forms.TextBox dateFinished_textBox;
        private System.Windows.Forms.Label dateFinished_label;
        private System.Windows.Forms.TextBox dateStarted_textBox;
        private System.Windows.Forms.Label dateStarted_label;
        private System.Windows.Forms.ProgressBar selectedBook_progressBar;
        private System.Windows.Forms.Label overProg_label;
        private System.Windows.Forms.Label selectedBookProg_label;
        private System.Windows.Forms.ComboBox yourBooks_comboBox;
        private System.Windows.Forms.Label chooseBook_label;
        private System.Windows.Forms.ComboBox reviewBooks_comboBox;
        private System.Windows.Forms.GroupBox review_groupBox;
        private System.Windows.Forms.PictureBox reviewBook_pictureBox;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.RichTextBox comment_richTextBox;
        private System.Windows.Forms.Label comment_label;
        private System.Windows.Forms.Label valueRating_label;
        private System.Windows.Forms.TextBox revDateFinished_textBox;
        private System.Windows.Forms.TextBox revDateStarted_textBox;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.Label revDateFinished_label;
        private System.Windows.Forms.Label revDateStarted_label;
        private System.Windows.Forms.TextBox author_textBox;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshPageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeAppToolStripMenuItem1;
    }
}