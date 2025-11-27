using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevNooTools
{
    public partial class Form1 : Form
    {
        private ProductRepository repository;
        private BindingList<Product> products;
        private List<Product> allProducts;
        private const string SearchPlaceholder = "Search products...";
        
        // Euro culture
        private static readonly CultureInfo EuroCulture = new CultureInfo("de-DE");

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                repository = new ProductRepository();
                allProducts = repository.LoadAll();
                products = new BindingList<Product>(allProducts.ToList());
                bindingSourceProducts.DataSource = products;
                
                UpdateStats();
                dataGridViewProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allProducts = new List<Product>();
                products = new BindingList<Product>();
                bindingSourceProducts.DataSource = products;
            }
        }

        private void UpdateStats()
        {
            labelCardTotalValue.Text = allProducts.Count.ToString();
            decimal totalValue = allProducts.Sum(p => p.Price * p.Quantity);
            labelCardValueValue.Text = totalValue.ToString("C", EuroCulture);
            int lowStock = allProducts.Count(p => p.Quantity <= 5);
            labelCardLowStockValue.Text = lowStock.ToString();
        }

        // Button to open Add Product dialog
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ShowProductDialog(null);
        }

        // Double-click to edit
        private void dataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && bindingSourceProducts.Current is Product cur)
            {
                ShowProductDialog(cur);
            }
        }

        private void ShowProductDialog(Product product)
        {
            bool isEdit = product != null;
            
            using (Form dialog = new Form())
            {
                dialog.Text = isEdit ? "Edit Product" : "Add Product";
                dialog.Size = new Size(420, 520);
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;
                dialog.BackColor = Color.FromArgb(35, 41, 54);
                dialog.Font = new Font("Segoe UI", 10F);

                Color inputBg = Color.FromArgb(45, 52, 66);
                Color textColor = Color.White;
                Color labelColor = Color.FromArgb(156, 163, 175);
                Color accentGreen = Color.FromArgb(34, 197, 94);
                Color borderColor = Color.FromArgb(55, 65, 81);

                // Mode label
                Label lblMode = new Label
                {
                    Text = isEdit ? "EDIT MODE" : "ADD MODE",
                    Location = new Point(20, 20),
                    AutoSize = true,
                    ForeColor = accentGreen,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    BackColor = Color.FromArgb(45, 55, 72),
                    Padding = new Padding(8, 4, 8, 4)
                };

                // ID field (readonly for edit)
                Label lblId = new Label { Text = "ID:", Location = new Point(20, 65), AutoSize = true, ForeColor = labelColor };
                TextBox txtId = new TextBox
                {
                    Location = new Point(20, 90),
                    Size = new Size(360, 30),
                    BackColor = inputBg,
                    ForeColor = textColor,
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = isEdit ? product.Id.ToString().Substring(0, 8) : Guid.NewGuid().ToString().Substring(0, 8),
                    ReadOnly = true
                };

                // Name field
                Label lblName = new Label { Text = "Name:", Location = new Point(20, 130), AutoSize = true, ForeColor = labelColor };
                TextBox txtName = new TextBox
                {
                    Location = new Point(20, 155),
                    Size = new Size(360, 30),
                    BackColor = inputBg,
                    ForeColor = textColor,
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = isEdit ? product.Name : ""
                };

                // Category field
                Label lblCategory = new Label { Text = "Category:", Location = new Point(20, 195), AutoSize = true, ForeColor = labelColor };
                ComboBox cmbCategory = new ComboBox
                {
                    Location = new Point(20, 220),
                    Size = new Size(360, 30),
                    BackColor = inputBg,
                    ForeColor = textColor,
                    FlatStyle = FlatStyle.Flat,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                cmbCategory.Items.AddRange(new object[] { "Audio", "Cameras", "Electronics", "Other" });
                cmbCategory.SelectedIndex = 0;

                // Price field
                Label lblPrice = new Label { Text = "Price:", Location = new Point(20, 260), AutoSize = true, ForeColor = labelColor };
                TextBox txtPrice = new TextBox
                {
                    Location = new Point(20, 285),
                    Size = new Size(360, 30),
                    BackColor = inputBg,
                    ForeColor = textColor,
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = isEdit ? product.Price.ToString("F2", EuroCulture) : ""
                };

                // Quantity field
                Label lblQty = new Label { Text = "Quantity:", Location = new Point(20, 325), AutoSize = true, ForeColor = labelColor };
                TextBox txtQty = new TextBox
                {
                    Location = new Point(20, 350),
                    Size = new Size(360, 30),
                    BackColor = inputBg,
                    ForeColor = textColor,
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = isEdit ? product.Quantity.ToString() + " units" : ""
                };

                // Cancel button
                Button btnCancel = new Button
                {
                    Text = "Cancel",
                    Location = new Point(120, 420),
                    Size = new Size(100, 40),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(55, 65, 81),
                    ForeColor = textColor,
                    Cursor = Cursors.Hand
                };
                btnCancel.FlatAppearance.BorderSize = 0;
                btnCancel.Click += (s, ev) => dialog.DialogResult = DialogResult.Cancel;

                // Save button
                Button btnSave = new Button
                {
                    Text = "Save Changes",
                    Location = new Point(230, 420),
                    Size = new Size(150, 40),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = accentGreen,
                    ForeColor = textColor,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                btnSave.FlatAppearance.BorderSize = 0;
                btnSave.Click += (s, ev) =>
                {
                    if (string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    decimal price = ParseDecimal(txtPrice.Text.Replace("€", "").Trim());
                    int qty = ParseInt(txtQty.Text.Replace("units", "").Trim());

                    if (isEdit)
                    {
                        product.Name = txtName.Text.Trim();
                        product.Description = cmbCategory.SelectedItem?.ToString() ?? "";
                        product.Price = price;
                        product.Quantity = qty;
                    }
                    else
                    {
                        var newProduct = new Product
                        {
                            Name = txtName.Text.Trim(),
                            Description = cmbCategory.SelectedItem?.ToString() ?? "",
                            Price = price,
                            Quantity = qty
                        };
                        allProducts.Add(newProduct);
                        products.Add(newProduct);
                    }

                    SaveProducts();
                    UpdateStats();
                    bindingSourceProducts.ResetBindings(false);
                    dialog.DialogResult = DialogResult.OK;
                };

                dialog.Controls.AddRange(new Control[] {
                    lblMode, lblId, txtId, lblName, txtName, lblCategory, cmbCategory,
                    lblPrice, txtPrice, lblQty, txtQty, btnCancel, btnSave
                });

                dialog.ShowDialog(this);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(bindingSourceProducts.Current is Product cur))
            {
                MessageBox.Show("No product selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show(
                $"Are you sure you want to delete '{cur.Name}'?\n\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes)
            {
                allProducts.Remove(cur);
                products.Remove(cur);
                SaveProducts();
                UpdateStats();
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            // Update hidden fields for compatibility
            if (bindingSourceProducts.Current is Product cur)
            {
                textName.Text = cur.Name ?? string.Empty;
                textDescription.Text = cur.Description ?? string.Empty;
                textPrice.Text = cur.Price.ToString("F2", EuroCulture);
                textQuantity.Text = cur.Quantity.ToString();
            }
        }

        // Search functionality
        private void textSearch_Enter(object sender, EventArgs e)
        {
            if (textSearch.Text == SearchPlaceholder)
            {
                textSearch.Text = string.Empty;
                textSearch.ForeColor = Color.White;
            }
        }

        private void textSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textSearch.Text))
            {
                textSearch.Text = SearchPlaceholder;
                textSearch.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textSearch.Text;
            
            if (searchText == SearchPlaceholder || string.IsNullOrWhiteSpace(searchText))
            {
                products.Clear();
                foreach (var p in allProducts)
                    products.Add(p);
                return;
            }

            var filtered = allProducts.Where(p =>
                (p.Name?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (p.Description?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
            ).ToList();

            products.Clear();
            foreach (var p in filtered)
                products.Add(p);
        }

        private void SaveProducts()
        {
            try
            {
                repository.SaveAll(allProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ParseDecimal(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0m;

            // Remove currency symbols and whitespace
            text = text.Replace("€", "").Replace("$", "").Trim();

            if (decimal.TryParse(text, NumberStyles.Any, EuroCulture, out var val))
                return val;

            if (decimal.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out val))
                return val;

            return 0m;
        }

        private int ParseInt(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            // Remove "units" suffix if present
            text = text.Replace("units", "").Trim();

            if (int.TryParse(text, out var val))
                return val;

            return 0;
        }
    }
}
