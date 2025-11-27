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
        private const string SearchPlaceholder = "Buscar produtos...";
        
        // Euro culture for currency formatting
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
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allProducts = new List<Product>();
                products = new BindingList<Product>();
                bindingSourceProducts.DataSource = products;
            }
        }

        private void UpdateStats()
        {
            // Total products
            labelCardTotalValue.Text = allProducts.Count.ToString();
            
            // Total value in stock (Euro)
            decimal totalValue = allProducts.Sum(p => p.Price * p.Quantity);
            labelCardValueValue.Text = totalValue.ToString("N2", EuroCulture) + " EUR";
            
            // Low stock (quantity <= 5)
            int lowStock = allProducts.Count(p => p.Quantity <= 5);
            labelCardLowStockValue.Text = lowStock.ToString();
            
            // Change color based on low stock
            if (lowStock > 0)
            {
                labelCardLowStockValue.ForeColor = Color.FromArgb(239, 68, 68);
            }
            else
            {
                labelCardLowStockValue.ForeColor = Color.FromArgb(34, 197, 94);
            }
            
            // Categories count (unique descriptions)
            int categories = allProducts.Select(p => p.Description).Distinct().Count();
            labelCardCategoriesValue.Text = categories.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Nome e obrigatorio.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textName.Focus();
                return;
            }

            decimal price = ParseDecimal(textPrice.Text);
            int qty = ParseInt(textQuantity.Text);

            if (price < 0)
            {
                MessageBox.Show("Preco nao pode ser negativo.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPrice.Focus();
                return;
            }

            if (qty < 0)
            {
                MessageBox.Show("Quantidade nao pode ser negativa.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textQuantity.Focus();
                return;
            }

            var p = new Product
            {
                Name = textName.Text.Trim(),
                Description = textDescription.Text?.Trim() ?? string.Empty,
                Price = price,
                Quantity = qty
            };

            allProducts.Add(p);
            products.Add(p);
            
            SaveProducts();
            UpdateStats();
            ClearFields();
            
            dataGridViewProducts.ClearSelection();
            int lastRowIndex = dataGridViewProducts.Rows.Count - 1;
            if (lastRowIndex >= 0)
            {
                dataGridViewProducts.Rows[lastRowIndex].Selected = true;
                dataGridViewProducts.FirstDisplayedScrollingRowIndex = lastRowIndex;
            }

            MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(bindingSourceProducts.Current is Product cur))
            {
                MessageBox.Show("Nenhum produto selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Nome e obrigatorio.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textName.Focus();
                return;
            }

            decimal price = ParseDecimal(textPrice.Text);
            int qty = ParseInt(textQuantity.Text);

            if (price < 0)
            {
                MessageBox.Show("Preco nao pode ser negativo.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPrice.Focus();
                return;
            }

            if (qty < 0)
            {
                MessageBox.Show("Quantidade nao pode ser negativa.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textQuantity.Focus();
                return;
            }

            cur.Name = textName.Text.Trim();
            cur.Description = textDescription.Text?.Trim() ?? string.Empty;
            cur.Price = price;
            cur.Quantity = qty;

            bindingSourceProducts.ResetBindings(false);
            SaveProducts();
            UpdateStats();
            MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(bindingSourceProducts.Current is Product cur))
            {
                MessageBox.Show("Nenhum produto selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show(
                $"Tem certeza que deseja excluir o produto '{cur.Name}'?\n\nEsta acao nao pode ser desfeita.",
                "Confirmar Exclusao",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes)
            {
                allProducts.Remove(cur);
                products.Remove(cur);
                
                SaveProducts();
                UpdateStats();
                ClearFields();
                MessageBox.Show("Produto excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            dataGridViewProducts.ClearSelection();
        }

        private void ClearFields()
        {
            textName.Text = string.Empty;
            textDescription.Text = string.Empty;
            textPrice.Text = string.Empty;
            textQuantity.Text = string.Empty;
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (bindingSourceProducts.Current is Product cur)
            {
                textName.Text = cur.Name ?? string.Empty;
                textDescription.Text = cur.Description ?? string.Empty;
                textPrice.Text = cur.Price.ToString("F2", EuroCulture);
                textQuantity.Text = cur.Quantity.ToString();
            }
            else
            {
                ClearFields();
            }
        }

        // Search functionality
        private void textSearch_Enter(object sender, EventArgs e)
        {
            if (textSearch.Text == SearchPlaceholder)
            {
                textSearch.Text = string.Empty;
                textSearch.ForeColor = Color.FromArgb(15, 23, 42);
            }
        }

        private void textSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textSearch.Text))
            {
                textSearch.Text = SearchPlaceholder;
                textSearch.ForeColor = Color.FromArgb(100, 116, 139);
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
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ParseDecimal(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0m;

            // Remove currency symbols
            text = text.Replace("EUR", "").Replace("E", "").Replace("$", "").Trim();

            // Try parsing with Euro culture first (uses comma as decimal separator)
            if (decimal.TryParse(text, NumberStyles.Any, EuroCulture, out var val))
                return val;

            // Fallback to invariant culture (uses dot as decimal separator)
            if (decimal.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out val))
                return val;

            return 0m;
        }

        private int ParseInt(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            if (int.TryParse(text.Trim(), out var val))
                return val;

            return 0;
        }
    }
}
