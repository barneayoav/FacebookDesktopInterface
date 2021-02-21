﻿namespace FacebookDesktopInterface.UI
{
    internal partial class FormLoginScreen
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
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.PictureBoxFacebook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFacebook)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Location = new System.Drawing.Point(145, 170);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(160, 35);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Login To Facebook";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberUser.ForeColor = System.Drawing.Color.Black;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(165, 220);
            this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(119, 21);
            this.checkBoxRememberUser.TabIndex = 2;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            this.checkBoxRememberUser.CheckedChanged += new System.EventHandler(this.checkBoxRememberUser_CheckedChanged);
            // 
            // PictureBoxFacebook
            // 
            this.PictureBoxFacebook.Image = global::FacebookDesktopInterface.Properties.Resources.FacebookLogo;
            this.PictureBoxFacebook.Location = new System.Drawing.Point(-2, 20);
            this.PictureBoxFacebook.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBoxFacebook.Name = "PictureBoxFacebook";
            this.PictureBoxFacebook.Size = new System.Drawing.Size(440, 125);
            this.PictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxFacebook.TabIndex = 1;
            this.PictureBoxFacebook.TabStop = false;
            // 
            // FormLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 281);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.PictureBoxFacebook);
            this.Controls.Add(this.ButtonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Facebook Login";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFacebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.PictureBox PictureBoxFacebook;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
    }
}