namespace Assignment_win
{
    partial class SignUp
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
            this.signUpUserNameLabel = new System.Windows.Forms.Label();
            this.SignUpNameLabel = new System.Windows.Forms.Label();
            this.signUpPasswordLabel = new System.Windows.Forms.Label();
            this.signUpUserNameText = new System.Windows.Forms.TextBox();
            this.signUpNameText = new System.Windows.Forms.TextBox();
            this.SignUpPasswordText = new System.Windows.Forms.TextBox();
            this.signUpSignUpButton = new System.Windows.Forms.Button();
            this.userPageBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpUserNameLabel
            // 
            this.signUpUserNameLabel.AutoSize = true;
            this.signUpUserNameLabel.Location = new System.Drawing.Point(159, 105);
            this.signUpUserNameLabel.Name = "signUpUserNameLabel";
            this.signUpUserNameLabel.Size = new System.Drawing.Size(60, 13);
            this.signUpUserNameLabel.TabIndex = 0;
            this.signUpUserNameLabel.Text = "User Name";
            // 
            // SignUpNameLabel
            // 
            this.SignUpNameLabel.AutoSize = true;
            this.SignUpNameLabel.Location = new System.Drawing.Point(159, 149);
            this.SignUpNameLabel.Name = "SignUpNameLabel";
            this.SignUpNameLabel.Size = new System.Drawing.Size(35, 13);
            this.SignUpNameLabel.TabIndex = 1;
            this.SignUpNameLabel.Text = "Name";
            // 
            // signUpPasswordLabel
            // 
            this.signUpPasswordLabel.AutoSize = true;
            this.signUpPasswordLabel.Location = new System.Drawing.Point(159, 190);
            this.signUpPasswordLabel.Name = "signUpPasswordLabel";
            this.signUpPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.signUpPasswordLabel.TabIndex = 2;
            this.signUpPasswordLabel.Text = "Password";
            // 
            // signUpUserNameText
            // 
            this.signUpUserNameText.Location = new System.Drawing.Point(287, 102);
            this.signUpUserNameText.Name = "signUpUserNameText";
            this.signUpUserNameText.Size = new System.Drawing.Size(100, 20);
            this.signUpUserNameText.TabIndex = 3;
            // 
            // signUpNameText
            // 
            this.signUpNameText.Location = new System.Drawing.Point(287, 146);
            this.signUpNameText.Name = "signUpNameText";
            this.signUpNameText.Size = new System.Drawing.Size(100, 20);
            this.signUpNameText.TabIndex = 4;
            // 
            // SignUpPasswordText
            // 
            this.SignUpPasswordText.Location = new System.Drawing.Point(287, 187);
            this.SignUpPasswordText.Name = "SignUpPasswordText";
            this.SignUpPasswordText.PasswordChar = '*';
            this.SignUpPasswordText.Size = new System.Drawing.Size(100, 20);
            this.SignUpPasswordText.TabIndex = 5;
            // 
            // signUpSignUpButton
            // 
            this.signUpSignUpButton.Location = new System.Drawing.Point(228, 225);
            this.signUpSignUpButton.Name = "signUpSignUpButton";
            this.signUpSignUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpSignUpButton.TabIndex = 6;
            this.signUpSignUpButton.Text = "Sign Up";
            this.signUpSignUpButton.UseVisualStyleBackColor = true;
            this.signUpSignUpButton.Click += new System.EventHandler(this.signUpSignUpButton_Click_1);
            // 
            // userPageBackButton
            // 
            this.userPageBackButton.Location = new System.Drawing.Point(228, 264);
            this.userPageBackButton.Name = "userPageBackButton";
            this.userPageBackButton.Size = new System.Drawing.Size(75, 23);
            this.userPageBackButton.TabIndex = 7;
            this.userPageBackButton.Text = "Back";
            this.userPageBackButton.UseVisualStyleBackColor = true;
            this.userPageBackButton.Click += new System.EventHandler(this.userPageBackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Sign Up";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPageBackButton);
            this.Controls.Add(this.signUpSignUpButton);
            this.Controls.Add(this.SignUpPasswordText);
            this.Controls.Add(this.signUpNameText);
            this.Controls.Add(this.signUpUserNameText);
            this.Controls.Add(this.signUpPasswordLabel);
            this.Controls.Add(this.SignUpNameLabel);
            this.Controls.Add(this.signUpUserNameLabel);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signUpUserNameLabel;
        private System.Windows.Forms.Label SignUpNameLabel;
        private System.Windows.Forms.Label signUpPasswordLabel;
        private System.Windows.Forms.TextBox signUpUserNameText;
        private System.Windows.Forms.TextBox signUpNameText;
        private System.Windows.Forms.TextBox SignUpPasswordText;
        private System.Windows.Forms.Button signUpSignUpButton;
        private System.Windows.Forms.Button userPageBackButton;
        private System.Windows.Forms.Label label1;
    }
}