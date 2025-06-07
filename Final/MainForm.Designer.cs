using System;
using System.Windows.Forms;

namespace Final
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Orders = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOrderProduct = new System.Windows.Forms.ComboBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.comboBoxOrderCategories = new System.Windows.Forms.ComboBox();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblOrderCategory = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblOrderProduct = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Orders
            // 
            this.Orders.AutoSize = true;
            this.Orders.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders.Location = new System.Drawing.Point(1544, 360);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(61, 22);
            this.Orders.TabIndex = 41;
            this.Orders.Text = "Orders";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1124, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Orders";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblFromDate);
            this.panel2.Controls.Add(this.lblCustomerName);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.lblPageNumber);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.dgvOrders);
            this.panel2.Controls.Add(this.dtpOrderDate);
            this.panel2.Controls.Add(this.comboBoxOrderProduct);
            this.panel2.Controls.Add(this.lblToDate);
            this.panel2.Controls.Add(this.comboBoxOrderCategories);
            this.panel2.Controls.Add(this.btnPrevPage);
            this.panel2.Controls.Add(this.btnNextPage);
            this.panel2.Controls.Add(this.btnDeleteOrder);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.btnEditOrder);
            this.panel2.Controls.Add(this.lblOrderDate);
            this.panel2.Controls.Add(this.btnAddOrder);
            this.panel2.Controls.Add(this.lblOrderCategory);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.lblOrderProduct);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 474);
            this.panel2.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(527, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 44;
            this.label2.Text = "Orders";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFromDate
            // 
            this.lblFromDate.Location = new System.Drawing.Point(6, 66);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(150, 20);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "Filter From Date:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(462, 63);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(114, 23);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(9, 137);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(234, 22);
            this.dtpTo.TabIndex = 30;
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPageNumber.Location = new System.Drawing.Point(22, 394);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(93, 31);
            this.lblPageNumber.TabIndex = 34;
            this.lblPageNumber.Text = "Page 1";
            this.lblPageNumber.Click += new System.EventHandler(this.lblPageNumber_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(9, 89);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(234, 22);
            this.dtpFrom.TabIndex = 29;
            // 
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrders.ColumnHeadersHeight = 29;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrders.Location = new System.Drawing.Point(251, 178);
            this.dgvOrders.Name = "dgvOrders";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.Size = new System.Drawing.Size(655, 246);
            this.dgvOrders.TabIndex = 33;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(607, 143);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(260, 22);
            this.dtpOrderDate.TabIndex = 31;
            // 
            // comboBoxOrderProduct
            // 
            this.comboBoxOrderProduct.Location = new System.Drawing.Point(451, 143);
            this.comboBoxOrderProduct.Name = "comboBoxOrderProduct";
            this.comboBoxOrderProduct.Size = new System.Drawing.Size(150, 24);
            this.comboBoxOrderProduct.TabIndex = 28;
            this.comboBoxOrderProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderProduct_SelectedIndexChanged);
            // 
            // lblToDate
            // 
            this.lblToDate.Location = new System.Drawing.Point(6, 114);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(150, 20);
            this.lblToDate.TabIndex = 1;
            this.lblToDate.Text = "Filter To Date:";
            // 
            // comboBoxOrderCategories
            // 
            this.comboBoxOrderCategories.Location = new System.Drawing.Point(291, 143);
            this.comboBoxOrderCategories.Name = "comboBoxOrderCategories";
            this.comboBoxOrderCategories.Size = new System.Drawing.Size(150, 24);
            this.comboBoxOrderCategories.TabIndex = 26;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(483, 430);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(90, 26);
            this.btnPrevPage.TabIndex = 24;
            this.btnPrevPage.Text = "Previous Page";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(579, 430);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(90, 26);
            this.btnNextPage.TabIndex = 23;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(941, 303);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(137, 23);
            this.btnDeleteOrder.TabIndex = 22;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(604, 66);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(150, 20);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(941, 274);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(137, 23);
            this.btnEditOrder.TabIndex = 21;
            this.btnEditOrder.Text = "Edit Order";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Location = new System.Drawing.Point(607, 123);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(150, 20);
            this.lblOrderDate.TabIndex = 7;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(941, 245);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(137, 23);
            this.btnAddOrder.TabIndex = 20;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // lblOrderCategory
            // 
            this.lblOrderCategory.Location = new System.Drawing.Point(291, 123);
            this.lblOrderCategory.Name = "lblOrderCategory";
            this.lblOrderCategory.Size = new System.Drawing.Size(150, 20);
            this.lblOrderCategory.TabIndex = 8;
            this.lblOrderCategory.Text = "Order Category:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(604, 86);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 12;
            // 
            // lblOrderProduct
            // 
            this.lblOrderProduct.Location = new System.Drawing.Point(451, 123);
            this.lblOrderProduct.Name = "lblOrderProduct";
            this.lblOrderProduct.Size = new System.Drawing.Size(150, 20);
            this.lblOrderProduct.TabIndex = 9;
            this.lblOrderProduct.Text = "Order Product:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(462, 86);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerName.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1124, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "P&C";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvProducts);
            this.panel3.Controls.Add(this.comboBoxProductCategory);
            this.panel3.Controls.Add(this.btnDeleteProduct);
            this.panel3.Controls.Add(this.btnEditProduct);
            this.panel3.Controls.Add(this.lblProductName);
            this.panel3.Controls.Add(this.btnAddProduct);
            this.panel3.Controls.Add(this.lblProductPrice);
            this.panel3.Controls.Add(this.txtProductPrice);
            this.panel3.Controls.Add(this.lblProductCategory);
            this.panel3.Controls.Add(this.txtProductName);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1125, 475);
            this.panel3.TabIndex = 42;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(780, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 36);
            this.label3.TabIndex = 44;
            this.label3.Text = "Categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(125, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 43;
            this.label1.Text = "Products";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel4.Controls.Add(this.btnDeleteCategory);
            this.panel4.Controls.Add(this.lblCategoryName);
            this.panel4.Controls.Add(this.btnEditCategory);
            this.panel4.Controls.Add(this.txtCategoryName);
            this.panel4.Controls.Add(this.btnAddCategory);
            this.panel4.Controls.Add(this.dgvCategories);
            this.panel4.Location = new System.Drawing.Point(623, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 407);
            this.panel4.TabIndex = 43;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(330, 209);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(144, 25);
            this.btnDeleteCategory.TabIndex = 37;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Location = new System.Drawing.Point(88, 58);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(150, 20);
            this.lblCategoryName.TabIndex = 10;
            this.lblCategoryName.Text = "New Category Name:";
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(330, 178);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(144, 25);
            this.btnEditCategory.TabIndex = 36;
            this.btnEditCategory.Text = " Edit Category";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(91, 81);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(150, 22);
            this.txtCategoryName.TabIndex = 15;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(330, 147);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(144, 25);
            this.btnAddCategory.TabIndex = 19;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // dgvCategories
            // 
            this.dgvCategories.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(60, 108);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(249, 201);
            this.dgvCategories.TabIndex = 35;
            this.dgvCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellContentClick);
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvProducts.ColumnHeadersHeight = 29;
            this.dgvProducts.Location = new System.Drawing.Point(16, 175);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(450, 210);
            this.dgvProducts.TabIndex = 32;
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.Location = new System.Drawing.Point(298, 145);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Size = new System.Drawing.Size(150, 24);
            this.comboBoxProductCategory.TabIndex = 27;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(472, 284);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteProduct.TabIndex = 18;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(472, 255);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(130, 23);
            this.btnEditProduct.TabIndex = 17;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(16, 125);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(150, 20);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(472, 226);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(130, 23);
            this.btnAddProduct.TabIndex = 16;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.Location = new System.Drawing.Point(176, 125);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(91, 20);
            this.lblProductPrice.TabIndex = 3;
            this.lblProductPrice.Text = "Product Price:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(176, 145);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 22);
            this.txtProductPrice.TabIndex = 14;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.Location = new System.Drawing.Point(298, 125);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(150, 20);
            this.lblProductCategory.TabIndex = 4;
            this.lblProductCategory.Text = "Product Category:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(16, 145);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 22);
            this.txtProductName.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1132, 503);
            this.tabControl1.TabIndex = 44;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1196, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Orders);
            this.Name = "MainForm";
            this.Text = "Final Project";
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }
        private Label Orders;
        private TabPage tabPage3;
        private Panel panel2;
        private Label label2;
        private Label lblFromDate;
        private Label lblCustomerName;
        private DateTimePicker dtpTo;
        private Label lblPageNumber;
        private DateTimePicker dtpFrom;
        private DataGridView dgvOrders;
        private DateTimePicker dtpOrderDate;
        private ComboBox comboBoxOrderProduct;
        private Label lblToDate;
        private ComboBox comboBoxOrderCategories;
        private Button btnPrevPage;
        private Button btnNextPage;
        private Button btnDeleteOrder;
        private Label lblQuantity;
        private Button btnEditOrder;
        private Label lblOrderDate;
        private Button btnAddOrder;
        private Label lblOrderCategory;
        private TextBox txtQuantity;
        private Label lblOrderProduct;
        private TextBox txtCustomerName;
        private TabPage tabPage1;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Button btnDeleteCategory;
        private Label lblCategoryName;
        private Button btnEditCategory;
        private TextBox txtCategoryName;
        private Button btnAddCategory;
        private DataGridView dgvCategories;
        private DataGridView dgvProducts;
        private ComboBox comboBoxProductCategory;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
        private Label lblProductName;
        private Button btnAddProduct;
        private Label lblProductPrice;
        private TextBox txtProductPrice;
        private Label lblProductCategory;
        private TextBox txtProductName;
        private TabControl tabControl1;
    }
}
