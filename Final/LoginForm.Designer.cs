using System;

namespace Final
{
    partial class LoginForm
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.authorizationlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(290, 144);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(156, 22);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(290, 198);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(156, 22);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Location = new System.Drawing.Point(259, 275);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(73, 29);
            this.submit.TabIndex = 2;
            this.submit.Text = "Next";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // authorizationlabel
            // 
            this.authorizationlabel.AutoSize = true;
            this.authorizationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorizationlabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.authorizationlabel.Location = new System.Drawing.Point(185, 43);
            this.authorizationlabel.Name = "authorizationlabel";
            this.authorizationlabel.Size = new System.Drawing.Size(249, 42);
            this.authorizationlabel.TabIndex = 3;
            this.authorizationlabel.Text = "Authorization";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.Color.White;
            this.namelabel.Location = new System.Drawing.Point(175, 141);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(64, 25);
            this.namelabel.TabIndex = 4;
            this.namelabel.Text = "Name";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.ForeColor = System.Drawing.Color.White;
            this.passwordlabel.Location = new System.Drawing.Point(175, 196);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(94, 25);
            this.passwordlabel.TabIndex = 5;
            this.passwordlabel.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(619, 362);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.authorizationlabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label authorizationlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label passwordlabel;
    }
}