﻿namespace Assignment_win
{
    partial class UserPage
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
            this.userPageSuccessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userPageSuccessLabel
            // 
            this.userPageSuccessLabel.AutoSize = true;
            this.userPageSuccessLabel.Location = new System.Drawing.Point(90, 55);
            this.userPageSuccessLabel.Name = "userPageSuccessLabel";
            this.userPageSuccessLabel.Size = new System.Drawing.Size(48, 13);
            this.userPageSuccessLabel.TabIndex = 0;
            this.userPageSuccessLabel.Text = "Success";
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.userPageSuccessLabel);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.Load += new System.EventHandler(this.UserPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userPageSuccessLabel;
    }
}