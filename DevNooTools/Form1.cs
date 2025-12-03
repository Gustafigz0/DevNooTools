using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        
        // Euro culture for currency formatting
        private static readonly CultureInfo EuroCulture = new CultureInfo("de-DE");

        public Form1()
        {
            // Start with dark theme
            ThemeManager.IsDarkTheme = true;
            
            InitializeComponent();
            this.Load += Form1_Load;
            
            // Subscribe to theme toggle
            toggleTheme.OnToggled += ToggleTheme_OnToggled;
            
            // Subscribe to theme changed event
            ThemeManager.ThemeChanged += ApplyTheme;
            
            // Enable double buffering for smooth rendering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | 
                          ControlStyles.AllPaintingInWmPaint | 
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();
            
            // Make avatar rounded
            MakeAvatarRounded();
            
            // Set initial toggle state
            toggleTheme.IsOn = ThemeManager.IsDarkTheme;
        }

        private void MakeAvatarRounded()
        {
            if (panelUserAvatar != null)
            {
                using (var path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, panelUserAvatar.Width, panelUserAvatar.Height);
                    panelUserAvatar.Region = new Region(path);
                }
            }
        }

        private void ToggleTheme_OnToggled(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme();
        }

        private void ApplyTheme()
        {
            this.SuspendLayout();
            
            // Update main backgrounds
            this.BackColor = ThemeManager.BgSecondary;
            panelMain.BackColor = ThemeManager.BgSecondary;
            panelSidebar.BackColor = ThemeManager.BgPrimary;
            panelSidebar.BorderColor = ThemeManager.BorderDefault;
            
            // Update header
            panelHeader.BackColor = Color.Transparent;
            labelTitle.ForeColor = ThemeManager.TextPrimary;
            labelSubtitle.ForeColor = ThemeManager.TextMuted;
            
            // Update sidebar labels
            labelLogo.ForeColor = ThemeManager.TextPrimary;
            labelLogoSub.ForeColor = ThemeManager.TextMuted;
            
            // Update nav items
            lblNavDashboard.ForeColor = ThemeManager.TextSecondary;
            lblNavProducts.ForeColor = ThemeManager.TextPrimary;
            lblNavCategories.ForeColor = ThemeManager.TextSecondary;
            lblNavReports.ForeColor = ThemeManager.TextSecondary;
            lblNavSettings.ForeColor = ThemeManager.TextSecondary;
            
            // Update nav panels hover color
            panelNavDashboard.HoverColor = ThemeManager.BgHover;
            panelNavProducts.HoverColor = ThemeManager.BgHover;
            panelNavCategories.HoverColor = ThemeManager.BgHover;
            panelNavReports.HoverColor = ThemeManager.BgHover;
            panelNavSettings.HoverColor = ThemeManager.BgHover;
            
            panelNavDashboard.Invalidate();
            panelNavProducts.Invalidate();
            panelNavCategories.Invalidate();
            panelNavReports.Invalidate();
            panelNavSettings.Invalidate();
            
            // Update user area
            labelUserName.ForeColor = ThemeManager.TextPrimary;
            labelUserRole.ForeColor = ThemeManager.TextMuted;
            labelThemeIcon.ForeColor = ThemeManager.TextSecondary;
            labelThemeText.ForeColor = ThemeManager.TextSecondary;
            
            // Update theme icon based on current theme
            labelThemeIcon.Text = ThemeManager.IsDarkTheme ? "??" : "??";
            labelThemeText.Text = ThemeManager.IsDarkTheme ? "Tema Claro" : "Tema Escuro";
            
            // Update form panel
            panelForm.BackColor = ThemeManager.BgPrimary;
            panelForm.BorderColor = ThemeManager.BorderDefault;
            labelFormTitle.ForeColor = ThemeManager.TextPrimary;
            lblName.ForeColor = ThemeManager.TextSecondary;
            lblDescription.ForeColor = ThemeManager.TextSecondary;
            lblPrice.ForeColor = ThemeManager.TextSecondary;
            lblQuantity.ForeColor = ThemeManager.TextSecondary;
            
            // Update textboxes
            textName.BackColor = ThemeManager.BgInput;
            textName.BorderColor = ThemeManager.BorderDefault;
            textName.ForeColor = ThemeManager.TextPrimary;
            textName.Invalidate();
            
            textDescription.BackColor = ThemeManager.BgInput;
            textDescription.BorderColor = ThemeManager.BorderDefault;
            textDescription.ForeColor = ThemeManager.TextPrimary;
            textDescription.Invalidate();
            
            textPrice.BackColor = ThemeManager.BgInput;
            textPrice.BorderColor = ThemeManager.BorderDefault;
            textPrice.ForeColor = ThemeManager.TextPrimary;
            textPrice.Invalidate();
            
            textQuantity.BackColor = ThemeManager.BgInput;
            textQuantity.BorderColor = ThemeManager.BorderDefault;
            textQuantity.ForeColor = ThemeManager.TextPrimary;
            textQuantity.Invalidate();
            
            // Update grid panel
            panelGrid.BackColor = ThemeManager.BgPrimary;
            panelGrid.BorderColor = ThemeManager.BorderDefault;
            labelGridTitle.ForeColor = ThemeManager.TextPrimary;
            
            // Update DataGridView
            ConfigureDataGridView();
            
            this.ResumeLayout(true);
            
            // Refresh all controls
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Configure DataGridView style
                ConfigureDataGridView();

                repository = new ProductRepository();
                allProducts = repository.LoadAll();
                products = new BindingList<Product>(allProducts.ToList());
                bindingSourceProducts.DataSource = products;
                
                UpdateStats();
                dataGridViewProducts.ClearSelection();
                ClearFields();

                // Show database location in title bar
                if (!string.IsNullOrEmpty(repository.DatabasePath))
                {
                    this.Text = $"DevNooTools - Dados: {repository.DatabasePath}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allProducts = new List<Product>();
                products = new BindingList<Product>();
                bindingSourceProducts.DataSource = products;
            }
        }

        private void ConfigureDataGridView()
        {
            if (dataGridViewProducts == null) return;

            // Header style
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = ThemeManager.IsDarkTheme 
                ? Color.FromArgb(33, 38, 45) 
                : Color.FromArgb(246, 248, 250);
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = ThemeManager.TextSecondary;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 0, 0, 0);

            // Cell style
            dataGridViewProducts.DefaultCellStyle.BackColor = ThemeManager.BgPrimary;
            dataGridViewProducts.DefaultCellStyle.ForeColor = ThemeManager.TextPrimary;
            dataGridViewProducts.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dataGridViewProducts.DefaultCellStyle.SelectionBackColor = ThemeManager.IsDarkTheme 
                ? Color.FromArgb(48, 54, 61) 
                : Color.FromArgb(235, 244, 255);
            dataGridViewProducts.DefaultCellStyle.SelectionForeColor = ThemeManager.AccentBlue;
            dataGridViewProducts.DefaultCellStyle.Padding = new Padding(12, 8, 8, 8);

            // Alternate row style
            dataGridViewProducts.AlternatingRowsDefaultCellStyle.BackColor = ThemeManager.IsDarkTheme 
                ? Color.FromArgb(22, 27, 34) 
                : Color.FromArgb(246, 248, 250);
            dataGridViewProducts.AlternatingRowsDefaultCellStyle.ForeColor = ThemeManager.TextPrimary;
            dataGridViewProducts.AlternatingRowsDefaultCellStyle.SelectionBackColor = ThemeManager.IsDarkTheme 
                ? Color.FromArgb(48, 54, 61) 
                : Color.FromArgb(235, 244, 255);
            dataGridViewProducts.AlternatingRowsDefaultCellStyle.SelectionForeColor = ThemeManager.AccentBlue;

            dataGridViewProducts.BackgroundColor = ThemeManager.BgPrimary;
            dataGridViewProducts.GridColor = ThemeManager.BorderDefault;
            dataGridViewProducts.AutoGenerateColumns = true;
        }

        private void UpdateStats()
        {
            // Total products
            labelCardTotalValue.Text = allProducts.Count.ToString();
            
            // Total value in stock (Euro)
            decimal totalValue = allProducts.Sum(p => p.Price * p.Quantity);
            labelCardValueValue.Text = totalValue.ToString("N2", EuroCulture) + " €";
            
            // Low stock (quantity <= 5)
            int lowStock = allProducts.Count(p => p.Quantity <= 5);
            labelCardLowStockValue.Text = lowStock.ToString();
            
            // Categories count (unique descriptions)
            int categories = allProducts.Select(p => p.Description).Where(d => !string.IsNullOrWhiteSpace(d)).Distinct().Count();
            labelCardCategoriesValue.Text = categories.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                ShowMessage("Nome é obrigatório.", "Validação", MessageBoxIcon.Warning);
                textName.Focus();
                return;
            }

            decimal price = ParseDecimal(textPrice.Text);
            int qty = ParseInt(textQuantity.Text);

            if (price < 0)
            {
                ShowMessage("Preço não pode ser negativo.", "Validação", MessageBoxIcon.Warning);
                textPrice.Focus();
                return;
            }

            if (qty < 0)
            {
                ShowMessage("Quantidade não pode ser negativa.", "Validação", MessageBoxIcon.Warning);
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

            ShowMessage("Produto adicionado com sucesso!", "Sucesso", MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(bindingSourceProducts.Current is Product cur))
            {
                ShowMessage("Nenhum produto selecionado.", "Aviso", MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                ShowMessage("Nome é obrigatório.", "Validação", MessageBoxIcon.Warning);
                textName.Focus();
                return;
            }

            decimal price = ParseDecimal(textPrice.Text);
            int qty = ParseInt(textQuantity.Text);

            if (price < 0)
            {
                ShowMessage("Preço não pode ser negativo.", "Validação", MessageBoxIcon.Warning);
                textPrice.Focus();
                return;
            }

            if (qty < 0)
            {
                ShowMessage("Quantidade não pode ser negativa.", "Validação", MessageBoxIcon.Warning);
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
            ShowMessage("Produto atualizado com sucesso!", "Sucesso", MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(bindingSourceProducts.Current is Product cur))
            {
                ShowMessage("Nenhum produto selecionado.", "Aviso", MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show(
                $"Tem certeza que deseja excluir o produto '{cur.Name}'?\n\nEsta ação não pode ser desfeita.",
                "Confirmar Exclusão",
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
                ShowMessage("Produto excluído com sucesso!", "Sucesso", MessageBoxIcon.Information);
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

        private void SaveProducts()
        {
            try
            {
                repository.SaveAll(allProducts);
            }
            catch (Exception ex)
            {
                ShowMessage($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxIcon.Error);
            }
        }

        private void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        private decimal ParseDecimal(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0m;

            // Remove currency symbols
            text = text.Replace("EUR", "").Replace("€", "").Replace("E", "").Replace("$", "").Trim();

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
