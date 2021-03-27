
namespace Reading_app
{
    partial class Form1
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.clickHere_linkLabel = new System.Windows.Forms.LinkLabel();
            this.notMember_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Location = new System.Drawing.Point(187, 30);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(121, 29);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome!";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(35, 110);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(86, 20);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(35, 162);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(83, 20);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textBox.Location = new System.Drawing.Point(168, 110);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(290, 27);
            this.username_textBox.TabIndex = 3;
            this.username_textBox.Text = "Enter username or email address";
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(168, 162);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(290, 27);
            this.password_textBox.TabIndex = 4;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // clickHere_linkLabel
            // 
            this.clickHere_linkLabel.AutoSize = true;
            this.clickHere_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickHere_linkLabel.Location = new System.Drawing.Point(272, 294);
            this.clickHere_linkLabel.Name = "clickHere_linkLabel";
            this.clickHere_linkLabel.Size = new System.Drawing.Size(84, 20);
            this.clickHere_linkLabel.TabIndex = 5;
            this.clickHere_linkLabel.TabStop = true;
            this.clickHere_linkLabel.Text = "Click here";
            this.clickHere_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clickHere_linkLabel_LinkClicked);
            // 
            // notMember_label
            // 
            this.notMember_label.AutoSize = true;
            this.notMember_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notMember_label.Location = new System.Drawing.Point(127, 294);
            this.notMember_label.Name = "notMember_label";
            this.notMember_label.Size = new System.Drawing.Size(124, 20);
            this.notMember_label.TabIndex = 6;
            this.notMember_label.Text = "Not a member?";
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.LightCoral;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(203, 222);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(93, 42);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 390);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.notMember_label);
            this.Controls.Add(this.clickHere_linkLabel);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.welcome_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.LinkLabel clickHere_linkLabel;
        private System.Windows.Forms.Label notMember_label;
        private System.Windows.Forms.Button login_button;
    }
}

