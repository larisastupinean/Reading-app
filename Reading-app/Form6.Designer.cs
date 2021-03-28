
namespace Reading_app
{
    partial class Form6
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
            this.reviewBook_label = new System.Windows.Forms.Label();
            this.dateFinished_label = new System.Windows.Forms.Label();
            this.dateFinished_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rating_label = new System.Windows.Forms.Label();
            this.rating_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comment_label = new System.Windows.Forms.Label();
            this.comment_richTextBox = new System.Windows.Forms.RichTextBox();
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rating_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewBook_label
            // 
            this.reviewBook_label.AutoSize = true;
            this.reviewBook_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewBook_label.Location = new System.Drawing.Point(218, 32);
            this.reviewBook_label.Name = "reviewBook_label";
            this.reviewBook_label.Size = new System.Drawing.Size(153, 29);
            this.reviewBook_label.TabIndex = 0;
            this.reviewBook_label.Text = "Review book";
            // 
            // dateFinished_label
            // 
            this.dateFinished_label.AutoSize = true;
            this.dateFinished_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinished_label.Location = new System.Drawing.Point(48, 115);
            this.dateFinished_label.Name = "dateFinished_label";
            this.dateFinished_label.Size = new System.Drawing.Size(108, 20);
            this.dateFinished_label.TabIndex = 1;
            this.dateFinished_label.Text = "Date finished";
            // 
            // dateFinished_dateTimePicker
            // 
            this.dateFinished_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinished_dateTimePicker.Location = new System.Drawing.Point(201, 108);
            this.dateFinished_dateTimePicker.Name = "dateFinished_dateTimePicker";
            this.dateFinished_dateTimePicker.Size = new System.Drawing.Size(339, 27);
            this.dateFinished_dateTimePicker.TabIndex = 2;
            // 
            // rating_label
            // 
            this.rating_label.AutoSize = true;
            this.rating_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating_label.Location = new System.Drawing.Point(48, 160);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(57, 20);
            this.rating_label.TabIndex = 3;
            this.rating_label.Text = "Rating";
            // 
            // rating_numericUpDown
            // 
            this.rating_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating_numericUpDown.Location = new System.Drawing.Point(201, 154);
            this.rating_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rating_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rating_numericUpDown.Name = "rating_numericUpDown";
            this.rating_numericUpDown.Size = new System.Drawing.Size(51, 30);
            this.rating_numericUpDown.TabIndex = 4;
            this.rating_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rating_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comment_label
            // 
            this.comment_label.AutoSize = true;
            this.comment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_label.Location = new System.Drawing.Point(49, 208);
            this.comment_label.Name = "comment_label";
            this.comment_label.Size = new System.Drawing.Size(81, 20);
            this.comment_label.TabIndex = 5;
            this.comment_label.Text = "Comment";
            // 
            // comment_richTextBox
            // 
            this.comment_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_richTextBox.Location = new System.Drawing.Point(201, 208);
            this.comment_richTextBox.Name = "comment_richTextBox";
            this.comment_richTextBox.Size = new System.Drawing.Size(339, 248);
            this.comment_richTextBox.TabIndex = 6;
            this.comment_richTextBox.Text = "";
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.PaleVioletRed;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(243, 471);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(103, 42);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 535);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.comment_richTextBox);
            this.Controls.Add(this.comment_label);
            this.Controls.Add(this.rating_numericUpDown);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.dateFinished_dateTimePicker);
            this.Controls.Add(this.dateFinished_label);
            this.Controls.Add(this.reviewBook_label);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.rating_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reviewBook_label;
        private System.Windows.Forms.Label dateFinished_label;
        private System.Windows.Forms.DateTimePicker dateFinished_dateTimePicker;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.NumericUpDown rating_numericUpDown;
        private System.Windows.Forms.Label comment_label;
        private System.Windows.Forms.RichTextBox comment_richTextBox;
        private System.Windows.Forms.Button save_button;
    }
}