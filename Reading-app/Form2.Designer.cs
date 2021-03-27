
namespace Reading_app
{
    partial class Form2
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
            this.newAccount_label = new System.Windows.Forms.Label();
            this.newEmail_label = new System.Windows.Forms.Label();
            this.newUsername_label = new System.Windows.Forms.Label();
            this.newPass_label = new System.Windows.Forms.Label();
            this.newEmail_textBox = new System.Windows.Forms.TextBox();
            this.newUsername_textBox = new System.Windows.Forms.TextBox();
            this.newPass_textBox = new System.Windows.Forms.TextBox();
            this.signup_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newAccount_label
            // 
            this.newAccount_label.AutoSize = true;
            this.newAccount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccount_label.Location = new System.Drawing.Point(165, 39);
            this.newAccount_label.Name = "newAccount_label";
            this.newAccount_label.Size = new System.Drawing.Size(244, 29);
            this.newAccount_label.TabIndex = 0;
            this.newAccount_label.Text = "Create a new account";
            // 
            // newEmail_label
            // 
            this.newEmail_label.AutoSize = true;
            this.newEmail_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmail_label.Location = new System.Drawing.Point(44, 117);
            this.newEmail_label.Name = "newEmail_label";
            this.newEmail_label.Size = new System.Drawing.Size(116, 20);
            this.newEmail_label.TabIndex = 1;
            this.newEmail_label.Text = "Email address";
            // 
            // newUsername_label
            // 
            this.newUsername_label.AutoSize = true;
            this.newUsername_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUsername_label.Location = new System.Drawing.Point(45, 174);
            this.newUsername_label.Name = "newUsername_label";
            this.newUsername_label.Size = new System.Drawing.Size(86, 20);
            this.newUsername_label.TabIndex = 2;
            this.newUsername_label.Text = "Username";
            // 
            // newPass_label
            // 
            this.newPass_label.AutoSize = true;
            this.newPass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass_label.Location = new System.Drawing.Point(48, 227);
            this.newPass_label.Name = "newPass_label";
            this.newPass_label.Size = new System.Drawing.Size(83, 20);
            this.newPass_label.TabIndex = 3;
            this.newPass_label.Text = "Password";
            // 
            // newEmail_textBox
            // 
            this.newEmail_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmail_textBox.Location = new System.Drawing.Point(219, 114);
            this.newEmail_textBox.Name = "newEmail_textBox";
            this.newEmail_textBox.Size = new System.Drawing.Size(313, 27);
            this.newEmail_textBox.TabIndex = 4;
            // 
            // newUsername_textBox
            // 
            this.newUsername_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUsername_textBox.Location = new System.Drawing.Point(219, 171);
            this.newUsername_textBox.Name = "newUsername_textBox";
            this.newUsername_textBox.Size = new System.Drawing.Size(313, 27);
            this.newUsername_textBox.TabIndex = 5;
            // 
            // newPass_textBox
            // 
            this.newPass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass_textBox.Location = new System.Drawing.Point(219, 227);
            this.newPass_textBox.Name = "newPass_textBox";
            this.newPass_textBox.Size = new System.Drawing.Size(313, 27);
            this.newPass_textBox.TabIndex = 6;
            this.newPass_textBox.UseSystemPasswordChar = true;
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(219, 304);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(132, 45);
            this.signup_button.TabIndex = 7;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 404);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.newPass_textBox);
            this.Controls.Add(this.newUsername_textBox);
            this.Controls.Add(this.newEmail_textBox);
            this.Controls.Add(this.newPass_label);
            this.Controls.Add(this.newUsername_label);
            this.Controls.Add(this.newEmail_label);
            this.Controls.Add(this.newAccount_label);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newAccount_label;
        private System.Windows.Forms.Label newEmail_label;
        private System.Windows.Forms.Label newUsername_label;
        private System.Windows.Forms.Label newPass_label;
        private System.Windows.Forms.TextBox newEmail_textBox;
        private System.Windows.Forms.TextBox newUsername_textBox;
        private System.Windows.Forms.TextBox newPass_textBox;
        private System.Windows.Forms.Button signup_button;
    }
}