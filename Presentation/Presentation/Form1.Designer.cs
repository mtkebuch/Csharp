using System;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainForm : Form
    {
       
        private void InitializeComponent()
        {
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonInsertProduct = new System.Windows.Forms.Button();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.BackColor = System.Drawing.Color.White;
            this.buttonLoadData.Location = new System.Drawing.Point(12, 250);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(100, 30);
            this.buttonLoadData.TabIndex = 1;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = false;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // buttonInsertProduct
            // 
            this.buttonInsertProduct.BackColor = System.Drawing.Color.White;
            this.buttonInsertProduct.Location = new System.Drawing.Point(120, 250);
            this.buttonInsertProduct.Name = "buttonInsertProduct";
            this.buttonInsertProduct.Size = new System.Drawing.Size(100, 30);
            this.buttonInsertProduct.TabIndex = 2;
            this.buttonInsertProduct.Text = "Insert Product";
            this.buttonInsertProduct.UseVisualStyleBackColor = false;
            this.buttonInsertProduct.Click += new System.EventHandler(this.buttonInsertProduct_Click);
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.BackColor = System.Drawing.Color.White;
            this.buttonUpdateProduct.Location = new System.Drawing.Point(230, 250);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(100, 30);
            this.buttonUpdateProduct.TabIndex = 3;
            this.buttonUpdateProduct.Text = "Update Product";
            this.buttonUpdateProduct.UseVisualStyleBackColor = false;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.White;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(340, 250);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(100, 30);
            this.buttonDeleteProduct.TabIndex = 4;
            this.buttonDeleteProduct.Text = "Delete Product";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxProductID.Location = new System.Drawing.Point(12, 290);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(100, 22);
            this.textBoxProductID.TabIndex = 5;
            this.textBoxProductID.Text = "Product ID";
            this.textBoxProductID.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxProductID.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxProductName.Location = new System.Drawing.Point(120, 290);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 22);
            this.textBoxProductName.TabIndex = 6;
            this.textBoxProductName.Text = "Product Name";
            this.textBoxProductName.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxProductName.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPrice.Location = new System.Drawing.Point(230, 290);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 7;
            this.textBoxPrice.Text = "Price";
            this.textBoxPrice.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxPrice.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxStock
            // 
            this.textBoxStock.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxStock.Location = new System.Drawing.Point(340, 290);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(100, 22);
            this.textBoxStock.TabIndex = 8;
            this.textBoxStock.Text = "Stock";
            this.textBoxStock.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxStock.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxSize
            // 
            this.textBoxSize.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSize.Location = new System.Drawing.Point(450, 290);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxSize.TabIndex = 9;
            this.textBoxSize.Text = "Size";
            this.textBoxSize.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxSize.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxColor
            // 
            this.textBoxColor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxColor.Location = new System.Drawing.Point(560, 290);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 22);
            this.textBoxColor.TabIndex = 10;
            this.textBoxColor.Text = "Color";
            this.textBoxColor.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxColor.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(760, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.buttonInsertProduct);
            this.Controls.Add(this.buttonUpdateProduct);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxColor);
            this.Name = "MainForm";
            this.Text = "Clothing Store App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button buttonInsertProduct;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.DataGridView dataGridView1;

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Text && textBox.ForeColor == System.Drawing.SystemColors.GrayText)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "textBox";
                textBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }
    }
}
