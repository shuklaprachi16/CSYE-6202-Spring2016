namespace Assignment_win
{
    partial class Welcome
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
            this.form1UserNameLabel = new System.Windows.Forms.Label();
            this.form1PasswordLabel = new System.Windows.Forms.Label();
            this.form1UserNameText = new System.Windows.Forms.TextBox();
            this.form1PasswordText = new System.Windows.Forms.TextBox();
            this.form1SignInButton = new System.Windows.Forms.Button();
            this.form1SignUpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form1UserNameLabel
            // 
            this.form1UserNameLabel.AutoSize = true;
            this.form1UserNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form1UserNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.form1UserNameLabel.Location = new System.Drawing.Point(192, 109);
            this.form1UserNameLabel.Name = "form1UserNameLabel";
            this.form1UserNameLabel.Padding = new System.Windows.Forms.Padding(2);
            this.form1UserNameLabel.Size = new System.Drawing.Size(66, 19);
            this.form1UserNameLabel.TabIndex = 0;
            this.form1UserNameLabel.Text = "User Name";
            // 
            // form1PasswordLabel
            // 
            this.form1PasswordLabel.AutoSize = true;
            this.form1PasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form1PasswordLabel.Location = new System.Drawing.Point(192, 144);
            this.form1PasswordLabel.Name = "form1PasswordLabel";
            this.form1PasswordLabel.Padding = new System.Windows.Forms.Padding(2);
            this.form1PasswordLabel.Size = new System.Drawing.Size(59, 19);
            this.form1PasswordLabel.TabIndex = 1;
            this.form1PasswordLabel.Text = "Password";
            // 
            // form1UserNameText
            // 
            this.form1UserNameText.Location = new System.Drawing.Point(315, 109);
            this.form1UserNameText.Name = "form1UserNameText";
            this.form1UserNameText.Size = new System.Drawing.Size(100, 20);
            this.form1UserNameText.TabIndex = 2;
            // 
            // form1PasswordText
            // 
            this.form1PasswordText.Location = new System.Drawing.Point(315, 144);
            this.form1PasswordText.Name = "form1PasswordText";
            this.form1PasswordText.PasswordChar = '*';
            this.form1PasswordText.Size = new System.Drawing.Size(100, 20);
            this.form1PasswordText.TabIndex = 3;
            // 
            // form1SignInButton
            // 
            this.form1SignInButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.form1SignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.form1SignInButton.Location = new System.Drawing.Point(236, 199);
            this.form1SignInButton.Name = "form1SignInButton";
            this.form1SignInButton.Size = new System.Drawing.Size(118, 37);
            this.form1SignInButton.TabIndex = 4;
            this.form1SignInButton.Text = "Sign In";
            this.form1SignInButton.UseVisualStyleBackColor = false;
            this.form1SignInButton.Click += new System.EventHandler(this.form1SignInButton_Click);
            // 
            // form1SignUpButton
            // 
            this.form1SignUpButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.form1SignUpButton.Location = new System.Drawing.Point(236, 255);
            this.form1SignUpButton.Name = "form1SignUpButton";
            this.form1SignUpButton.Size = new System.Drawing.Size(118, 32);
            this.form1SignUpButton.TabIndex = 5;
            this.form1SignUpButton.Text = "Sign Up";
            this.form1SignUpButton.UseVisualStyleBackColor = false;
            this.form1SignUpButton.Click += new System.EventHandler(this.form1SignUpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(249, 25);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form1SignUpButton);
            this.Controls.Add(this.form1SignInButton);
            this.Controls.Add(this.form1PasswordText);
            this.Controls.Add(this.form1UserNameText);
            this.Controls.Add(this.form1PasswordLabel);
            this.Controls.Add(this.form1UserNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form1UserNameLabel;
        private System.Windows.Forms.Label form1PasswordLabel;
        private System.Windows.Forms.TextBox form1UserNameText;
        private System.Windows.Forms.TextBox form1PasswordText;
        private System.Windows.Forms.Button form1SignInButton;
        private System.Windows.Forms.Button form1SignUpButton;
        private System.Windows.Forms.Label label1;
    }
}