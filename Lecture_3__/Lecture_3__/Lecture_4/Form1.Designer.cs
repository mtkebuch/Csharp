﻿using System;

namespace Lecture_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // transactionButton
            // 
            this.transactionButton.Location = new System.Drawing.Point(276, 320);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(285, 23);
            this.transactionButton.TabIndex = 1;
            this.transactionButton.Text = "Execute Transaction";
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(276, 350);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(285, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Add Categories";
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button transactionButton; 
        private System.Windows.Forms.Button createButton; 

        public EventHandler Form1_Load_1 { get; private set; }
    }
}
