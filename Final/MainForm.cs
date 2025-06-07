using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.EntityFrameworkCore;

namespace Final
{
    public partial class MainForm : Form
    {
        private int currentPage = 1;
        private const int pageSize = 10;
        private ShopDbContext db = new ShopDbContext();

        
        private bool suppressSelectionChanged = false;

        public MainForm()
        {
            InitializeComponent();

            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;

            LoadCategories();
            LoadProducts();
            LoadOrders();
            LoadOrderProducts();
            SetupEvents();
        }

        private void SetupEvents()
        {
            btnAddProduct.Click += BtnAddProduct_Click;
            btnEditProduct.Click += BtnEditProduct_Click;
            btnDeleteProduct.Click += BtnDeleteProduct_Click;

            btnAddCategory.Click += BtnAddCategory_Click;

            btnAddOrder.Click += BtnAddOrder_Click;
            btnEditOrder.Click += BtnEditOrder_Click;
            btnDeleteOrder.Click += BtnDeleteOrder_Click;

            btnNextPage.Click += BtnNextPage_Click;
            btnPrevPage.Click += BtnPrevPage_Click;

            dtpFrom.ValueChanged += FilterOrders;
            dtpTo.ValueChanged += FilterOrders;

           
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
            dgvCategories.SelectionChanged += DgvCategories_SelectionChanged;
            dgvOrders.SelectionChanged += DgvOrders_SelectionChanged;
            

        }

        private void ComboBoxOrderCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // --- Categories ---
        private void LoadCategories()
        {
            var categories = db.Categories
                .Select(c => new
                {
                    c.Id,
                    c.Name
                }).ToList();

            comboBoxOrderCategories.DataSource = null;
            comboBoxOrderCategories.DataSource = categories;
            comboBoxOrderCategories.DisplayMember = "Name";
            comboBoxOrderCategories.ValueMember = "Id";

            comboBoxProductCategory.DataSource = null;
            comboBoxProductCategory.DataSource = db.Categories.ToList();
            comboBoxProductCategory.DisplayMember = "Name";
            comboBoxProductCategory.ValueMember = "Id";

            dgvCategories.AutoGenerateColumns = true; 
            dgvCategories.DataSource = null;
            dgvCategories.DataSource = categories;
        }


        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    MessageBox.Show("Category name required!");
                    return;
                }

                var cat = new Category { Name = txtCategoryName.Text.Trim() };
                db.Categories.Add(cat);
                db.SaveChanges();
                LoadCategories();
                MessageBox.Show("Category added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // --- Products ---
        private void LoadProducts()
        {
            try
            {
                var products = db.Products.Include(p => p.Category).Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Price,
                    Category = p.Category.Name
                }).ToList();

                suppressSelectionChanged = true;

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;

                comboBoxProductCategory.DataSource = null;
                comboBoxProductCategory.DataSource = db.Categories.ToList();
                comboBoxProductCategory.DisplayMember = "Name";
                comboBoxProductCategory.ValueMember = "Id";

                ClearProductInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                suppressSelectionChanged = false;
            }
        }


        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || !decimal.TryParse(txtProductPrice.Text, out decimal price))
            {
                MessageBox.Show("Fill product name and valid price");
                return;
            }

            try
            {
                var product = new Product
                {
                    Name = txtProductName.Text.Trim(),
                    Price = price,
                    CategoryId = (int)comboBoxProductCategory.SelectedValue
                };

                db.Products.Add(product);
                db.SaveChanges();
                LoadProducts();
                MessageBox.Show("Product added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            int id = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
            var product = db.Products.Find(id);
            if (product == null) return;

            if (string.IsNullOrWhiteSpace(txtProductName.Text) || !decimal.TryParse(txtProductPrice.Text, out decimal price))
            {
                MessageBox.Show("Fill product name and valid price");
                return;
            }

            try
            {
                product.Name = txtProductName.Text.Trim();
                product.Price = price;
                product.CategoryId = (int)comboBoxProductCategory.SelectedValue;

                db.SaveChanges();
                LoadProducts();
                MessageBox.Show("Product updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            if (MessageBox.Show("Confirm delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
                    var product = db.Products.Find(id);
                    if (product != null)
                    {
                        db.Products.Remove(product);
                        db.SaveChanges();
                        LoadProducts();
                        MessageBox.Show("Product deleted!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // --- Orders ---
        private void LoadOrders()
        {
            try
            {
                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);

                var orders = db.Orders
                    .Include(o => o.Product)
                    .Where(o => o.OrderDate >= fromDate && o.OrderDate <= toDate)
                    .OrderBy(o => o.Id)
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .Select(o => new
                    {
                        o.Id,
                        o.CustomerName,
                        o.OrderDate,
                        Product = o.Product.Name,
                        o.Quantity,
                        TotalPrice = o.Product.Price * o.Quantity
                    }).ToList();

                suppressSelectionChanged = true;

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = orders;
                UpdateOrderRowStyles();

                lblPageNumber.Text = $"Page: {currentPage}";

                ClearOrderInputs();

                suppressSelectionChanged = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadOrderProducts()
        {
            try
            {
                var products = db.Products
                    .Select(p => new
                    {
                        p.Id,
                        p.Name
                    })
                    .ToList();

                comboBoxOrderProduct.DataSource = null;
                comboBoxOrderProduct.DataSource = products;
                comboBoxOrderProduct.DisplayMember = "Name";
                comboBoxOrderProduct.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateOrderRowStyles()
        {
            try
            {
                foreach (DataGridViewRow row in dgvOrders.Rows)
                {
                    if (row.Cells["TotalPrice"].Value != null &&
                        decimal.TryParse(row.Cells["TotalPrice"].Value.ToString(), out decimal total))
                    {
                        row.DefaultCellStyle.BackColor = total > 100 ? Color.Red : Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error styling order rows: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
                {
                    MessageBox.Show("Customer name is required.");
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Enter a valid quantity greater than 0.");
                    return;
                }

                if (comboBoxOrderProduct.SelectedIndex == -1 || comboBoxOrderProduct.SelectedValue == null)
                {
                    MessageBox.Show("Please select a product.");
                    return;
                }

                if (dtpOrderDate.Value == null || dtpOrderDate.Value > DateTime.Today.AddDays(1))
                {
                    MessageBox.Show("Please select a valid order date.");
                    return;
                }

                var order = new Order
                {
                    CustomerName = txtCustomerName.Text.Trim(),
                    OrderDate = dtpOrderDate.Value,
                    ProductId = (int)comboBoxOrderProduct.SelectedValue,
                    Quantity = quantity
                };

                db.Orders.Add(order);
                db.SaveChanges();
                LoadOrders();
                MessageBox.Show("Order added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrders.CurrentRow == null)
                {
                    MessageBox.Show("Please select an order to edit.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
                {
                    MessageBox.Show("Customer name is required.");
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Enter a valid quantity greater than 0.");
                    return;
                }

                if (comboBoxOrderProduct.SelectedIndex == -1 || comboBoxOrderProduct.SelectedValue == null)
                {
                    MessageBox.Show("Please select a product.");
                    return;
                }

                if (dtpOrderDate.Value == null || dtpOrderDate.Value > DateTime.Today.AddDays(1))
                {
                    MessageBox.Show("Please select a valid order date.");
                    return;
                }

                int id = (int)dgvOrders.CurrentRow.Cells["Id"].Value;
                var order = db.Orders.Find(id);
                if (order == null)
                {
                    MessageBox.Show("Order not found in database.");
                    return;
                }

                order.CustomerName = txtCustomerName.Text.Trim();
                order.OrderDate = dtpOrderDate.Value;
                order.ProductId = (int)comboBoxOrderProduct.SelectedValue;
                order.Quantity = quantity;

                db.SaveChanges();
                LoadOrders();
                MessageBox.Show("Order updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrders.CurrentRow == null || dgvOrders.CurrentRow.Cells["Id"].Value == null)
                {
                    MessageBox.Show("Please select an order to delete.");
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this order?",
                                             "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int id = (int)dgvOrders.CurrentRow.Cells["Id"].Value;
                    var order = db.Orders.Find(id);

                    if (order != null)
                    {
                        db.Orders.Remove(order);
                        db.SaveChanges();
                        LoadOrders();
                        MessageBox.Show("Order deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Selected order was not found in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Pagination
        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            try
            {
                int totalOrders = db.Orders.Count(o => o.OrderDate >= dtpFrom.Value.Date && o.OrderDate <= dtpTo.Value.Date.AddDays(1).AddTicks(-1));
                if (totalOrders > currentPage * pageSize)
                {
                    currentPage++;
                    LoadOrders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while moving to next page: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPrevPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPage > 1)
                {
                    currentPage--;
                    LoadOrders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while moving to previous page: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterOrders(object sender, EventArgs e)
        {
            try
            {
                currentPage = 1;
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while filtering orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // SelectionChanged 


        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (suppressSelectionChanged) return;

            try
            {
                if (dgvProducts.CurrentRow == null) return;

                var row = dgvProducts.CurrentRow;
                if (row.Cells["Id"].Value == null) return;

                suppressSelectionChanged = true;

                txtProductName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                txtProductPrice.Text = row.Cells["Price"].Value?.ToString() ?? "";

                if (row.Cells["Category"].Value != null)
                {
                    string categoryName = row.Cells["Category"].Value.ToString();
                    comboBoxProductCategory.SelectedIndex = comboBoxProductCategory.FindStringExact(categoryName);
                }
                else
                {
                    comboBoxProductCategory.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while selecting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                suppressSelectionChanged = false;
            }
        }


        private void DgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (suppressSelectionChanged) return;

            try
            {
                if (dgvCategories.CurrentRow == null) return;

                var row = dgvCategories.CurrentRow;
                if (row.Cells["Id"].Value == null) return;

                suppressSelectionChanged = true;

                txtCategoryName.Text = row.Cells["Name"].Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while selecting category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                suppressSelectionChanged = false;
            }
        }


        private void DgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (suppressSelectionChanged) return;

            try
            {
                if (dgvOrders.CurrentRow == null) return;

                var row = dgvOrders.CurrentRow;
                if (row.Cells["Id"].Value == null) return;

                suppressSelectionChanged = true;

                txtCustomerName.Text = row.Cells["CustomerName"].Value?.ToString() ?? "";
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString() ?? "";

                if (row.Cells["OrderDate"].Value != null &&
                    DateTime.TryParse(row.Cells["OrderDate"].Value.ToString(), out DateTime orderDate))
                {
                    dtpOrderDate.Value = orderDate;
                }

                if (row.Cells["Product"].Value != null)
                {
                    string productName = row.Cells["Product"].Value.ToString();
                    comboBoxOrderProduct.SelectedIndex = comboBoxOrderProduct.FindStringExact(productName);
                }
                else
                {
                    comboBoxOrderProduct.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while selecting order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                suppressSelectionChanged = false;
            }
        }



        // Input clear methods

        private void ClearProductInputs()
        {
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            comboBoxProductCategory.SelectedIndex = -1;
        }

        private void ClearCategoryInputs()
        {
            txtCategoryName.Text = "";
        }

        private void ClearOrderInputs()
        {
            txtCustomerName.Text = "";
            txtQuantity.Text = "";
            dtpOrderDate.Value = DateTime.Today;
            comboBoxOrderProduct.SelectedIndex = -1;
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategories.CurrentRow == null)
                {
                    MessageBox.Show("Please select a category to edit.");
                    return;
                }

                int id = (int)dgvCategories.CurrentRow.Cells["Id"].Value;
                var category = db.Categories.Find(id);

                if (category == null)
                {
                    MessageBox.Show("Category not found.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    MessageBox.Show("Category name cannot be empty.");
                    return;
                }

                category.Name = txtCategoryName.Text.Trim();
                db.SaveChanges();
                LoadCategories();
                MessageBox.Show("Category updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategories.CurrentRow == null)
                {
                    MessageBox.Show("Please select a category to delete.");
                    return;
                }

                int id = (int)dgvCategories.CurrentRow.Cells["Id"].Value;
                var category = db.Categories
                    .Include(c => c.Products)
                    .FirstOrDefault(c => c.Id == id);

                if (category == null)
                {
                    MessageBox.Show("Category not found.");
                    return;
                }

                if (category.Products != null && category.Products.Any())
                {
                    MessageBox.Show("Cannot delete category because it has products.");
                    return;
                }

                var confirm = MessageBox.Show("Are you sure you want to delete this category?",
                                              "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    db.Categories.Remove(category);
                    db.SaveChanges();
                    LoadCategories();
                    MessageBox.Show("Category deleted!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPageNumber_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxOrderProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
