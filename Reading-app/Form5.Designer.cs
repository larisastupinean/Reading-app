
namespace Reading_app
{
    partial class Form5
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
            this.updateProgress_label = new System.Windows.Forms.Label();
            this.updateProg_label = new System.Windows.Forms.Label();
            this.updateProg_trackBar = new System.Windows.Forms.TrackBar();
            this.percentProg_label = new System.Windows.Forms.Label();
            this.or_label = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.bookFinished_linkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.updateProg_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // updateProgress_label
            // 
            this.updateProgress_label.AutoSize = true;
            this.updateProgress_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProgress_label.Location = new System.Drawing.Point(149, 27);
            this.updateProgress_label.Name = "updateProgress_label";
            this.updateProgress_label.Size = new System.Drawing.Size(193, 29);
            this.updateProgress_label.TabIndex = 0;
            this.updateProgress_label.Text = "Update progress";
            // 
            // updateProg_label
            // 
            this.updateProg_label.AutoSize = true;
            this.updateProg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProg_label.Location = new System.Drawing.Point(39, 92);
            this.updateProg_label.Name = "updateProg_label";
            this.updateProg_label.Size = new System.Drawing.Size(77, 20);
            this.updateProg_label.TabIndex = 1;
            this.updateProg_label.Text = "Progress";
            // 
            // updateProg_trackBar
            // 
            this.updateProg_trackBar.Location = new System.Drawing.Point(138, 82);
            this.updateProg_trackBar.Maximum = 100;
            this.updateProg_trackBar.Name = "updateProg_trackBar";
            this.updateProg_trackBar.Size = new System.Drawing.Size(236, 56);
            this.updateProg_trackBar.TabIndex = 2;
            this.updateProg_trackBar.Scroll += new System.EventHandler(this.updateProg_trackBar_Scroll);
            // 
            // percentProg_label
            // 
            this.percentProg_label.AutoSize = true;
            this.percentProg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentProg_label.Location = new System.Drawing.Point(391, 82);
            this.percentProg_label.Name = "percentProg_label";
            this.percentProg_label.Size = new System.Drawing.Size(0, 20);
            this.percentProg_label.TabIndex = 3;
            // 
            // or_label
            // 
            this.or_label.AutoSize = true;
            this.or_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.or_label.Location = new System.Drawing.Point(109, 209);
            this.or_label.Name = "or_label";
            this.or_label.Size = new System.Drawing.Size(28, 20);
            this.or_label.TabIndex = 4;
            this.or_label.Text = "Or";
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(191, 135);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(99, 40);
            this.update_button.TabIndex = 5;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // bookFinished_linkLabel
            // 
            this.bookFinished_linkLabel.AutoSize = true;
            this.bookFinished_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookFinished_linkLabel.Location = new System.Drawing.Point(155, 209);
            this.bookFinished_linkLabel.Name = "bookFinished_linkLabel";
            this.bookFinished_linkLabel.Size = new System.Drawing.Size(219, 20);
            this.bookFinished_linkLabel.TabIndex = 6;
            this.bookFinished_linkLabel.TabStop = true;
            this.bookFinished_linkLabel.Text = "Have you finished the book?";
            this.bookFinished_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bookFinished_linkLabel_LinkClicked);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 269);
            this.Controls.Add(this.bookFinished_linkLabel);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.or_label);
            this.Controls.Add(this.percentProg_label);
            this.Controls.Add(this.updateProg_trackBar);
            this.Controls.Add(this.updateProg_label);
            this.Controls.Add(this.updateProgress_label);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.updateProg_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateProgress_label;
        private System.Windows.Forms.Label updateProg_label;
        private System.Windows.Forms.TrackBar updateProg_trackBar;
        private System.Windows.Forms.Label percentProg_label;
        private System.Windows.Forms.Label or_label;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.LinkLabel bookFinished_linkLabel;
    }
}