﻿namespace Lecture_3__
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
            this.OrderdateText = new System.Windows.Forms.TextBox();
            this.TotalamountText = new System.Windows.Forms.TextBox();
            this.UserIDBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.CreateBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderdateText
            // 
            this.OrderdateText.Location = new System.Drawing.Point(106, 47);
            this.OrderdateText.Name = "OrderdateText";
            this.OrderdateText.Size = new System.Drawing.Size(100, 20);
            this.OrderdateText.TabIndex = 0;
            // 
            // TotalamountText
            // 
            this.TotalamountText.Location = new System.Drawing.Point(106, 86);
            this.TotalamountText.Name = "TotalamountText";
            this.TotalamountText.Size = new System.Drawing.Size(100, 20);
            this.TotalamountText.TabIndex = 1;
            // 
            // UserIDBox
            // 
            this.UserIDBox.FormattingEnabled = true;
            this.UserIDBox.Location = new System.Drawing.Point(106, 177);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.Size = new System.Drawing.Size(121, 21);
            this.UserIDBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Orderdate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TotalAmount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "UserID";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(59, 240);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 21);
            this.CreateButton.TabIndex = 8;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(106, 133);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(100, 20);
            this.StatusText.TabIndex = 9;
            // 
            // CreateBT
            // 
            this.CreateBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CreateBT.Location = new System.Drawing.Point(150, 240);
            this.CreateBT.Name = "CreateBT";
            this.CreateBT.Size = new System.Drawing.Size(75, 23);
            this.CreateBT.TabIndex = 11;
            this.CreateBT.Text = "CreateBt";
            this.CreateBT.UseVisualStyleBackColor = true;
            this.CreateBT.Click += new System.EventHandler(this.CreateBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 348);
            this.Controls.Add(this.CreateBT);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserIDBox);
            this.Controls.Add(this.TotalamountText);
            this.Controls.Add(this.OrderdateText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrderdateText;
        private System.Windows.Forms.TextBox TotalamountText;
        private System.Windows.Forms.ComboBox UserIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.Button CreateBT;
    }
}

