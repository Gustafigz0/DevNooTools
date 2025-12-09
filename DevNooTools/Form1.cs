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

        // Animation helpers
        private Timer _fadeInTimer;
        private float _fadeProgress = 0f;

        // Dashboard chart
        private RoundedPanel panelChart;
        private BarChart barChart;
        private RoundedPanel panelPieChart;
        private PieChart pieChart;

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

            // Prepare fade-in
            this.Opacity = 0.0;
            _fadeInTimer = new Timer { Interval = 16 };
            _fadeInTimer.Tick += FadeInTimer_Tick;

            // Wire navigation clicks for dashboard and products
            try
            {
                panelNavDashboard.Click += PanelNavDashboard_Click;
                lblNavDashboard.Click += PanelNavDashboard_Click;

                panelNavProducts.Click += PanelNavProducts_Click;
                lblNavProducts.Click += PanelNavProducts_Click;
            }
            catch { /* designer fields may not be initialized in some contexts */ }
        }

        private void SetupPieChart()
        {
            if (panelMain == null) return;

            // Create Bar Chart container panel if not exists
            if (panelChart == null)
            {
                panelChart = new RoundedPanel
                {
                    Radius = 12,
                    ShowShadow = true,
                    ShadowDepth = 4,
                    BorderColor = ThemeManager.BorderDefault,
                    BackColor = ThemeManager.BgCard,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };

                barChart = new BarChart 
                { 
                    Dock = DockStyle.Fill,
                    BackColor = ThemeManager.BgCard,
                    Title = "?? Preços dos Produtos (Top 8)"
                };
                panelChart.Controls.Add(barChart);
                panelMain.Controls.Add(panelChart);
            }

            // Create Pie Chart container panel if not exists
            if (panelPieChart == null)
            {
                panelPieChart = new RoundedPanel
                {
                    Radius = 12,
                    ShowShadow = true,
                    ShadowDepth = 4,
                    BorderColor = ThemeManager.BorderDefault,
                    BackColor = ThemeManager.BgCard,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right
                };

                pieChart = new PieChart 
                { 
                    Dock = DockStyle.Fill,
                    BackColor = ThemeManager.BgCard
                };
                panelPieChart.Controls.Add(pieChart);
                panelMain.Controls.Add(panelPieChart);
            }

            // Position charts
            RepositionChart();

            // Update on resize to keep position
            panelMain.Resize -= PanelMain_Resize;
            panelMain.Resize += PanelMain_Resize;

            UpdateCharts();
        }

        private void PanelMain_Resize(object sender, EventArgs e)
        {
            RepositionChart();
        }

        private void RepositionChart()
        {
            if (panelMain == null) return;

            int margin = 24;
            int topOffset = panelHeader.Height + panelCards.Height + margin;
            int availableWidth = panelMain.Width - margin * 3;
            int availableHeight = panelMain.Height - topOffset - margin;

            // Bar chart takes 60% of width, Pie chart takes 35%
            int barChartWidth = (int)(availableWidth * 0.62);
            int pieChartWidth = (int)(availableWidth * 0.35);
            int chartHeight = Math.Max(280, availableHeight);

            if (panelChart != null)
            {
                panelChart.Location = new Point(margin, topOffset);
                panelChart.Size = new Size(barChartWidth, chartHeight);
                panelChart.BringToFront();
            }

            if (panelPieChart != null)
            {
                panelPieChart.Location = new Point(margin + barChartWidth + margin, topOffset);
                panelPieChart.Size = new Size(pieChartWidth, chartHeight);
                panelPieChart.BringToFront();
            }
        }

        private void UpdateCharts()
        {
            UpdateBarChart();
            UpdatePieChart();
        }

        private void UpdateBarChart()
        {
            if (barChart == null) return;

            if (allProducts == null || allProducts.Count == 0)
            {
                barChart.SetData(new List<BarChartItem>());
                return;
            }

            // Get top 8 products by price
            var topProducts = allProducts
                .OrderByDescending(p => p.Price)
                .Take(8)
                .Select(p => new BarChartItem(p.Name ?? "Sem nome", p.Price))
                .ToList();

            barChart.SetPalette(new Color[] { 
                ThemeManager.AccentBlue, 
                ThemeManager.AccentGreen, 
                ThemeManager.AccentOrange, 
                ThemeManager.AccentPurple, 
                ThemeManager.AccentRed,
                Color.FromArgb(255, 99, 132),
                Color.FromArgb(54, 162, 235),
                Color.FromArgb(255, 206, 86)
            });
            barChart.SetData(topProducts);
        }

        private void UpdatePieChart()
        {
            if (pieChart == null) return;

            if (allProducts == null || allProducts.Count == 0)
            {
                pieChart.SetData(new Dictionary<string,int>());
                return;
            }

            var groups = allProducts.GroupBy(p => string.IsNullOrWhiteSpace(p.Description) ? "Sem Categoria" : p.Description)
                .Select(g => new { Category = g.Key, Quantity = g.Sum(p => p.Quantity) })
                .OrderByDescending(g => g.Quantity)
                .Take(5)
                .ToList();

            var dict = groups.ToDictionary(g => g.Category, g => g.Quantity);
            pieChart.SetPalette(new Color[] { ThemeManager.AccentBlue, ThemeManager.AccentGreen, ThemeManager.AccentOrange, ThemeManager.AccentPurple, ThemeManager.AccentRed });
            pieChart.SetData(dict);
        }

        private void PanelNavDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void PanelNavProducts_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void ShowDashboard()
        {
            // Selection visuals
            if (panelNavDashboard != null) panelNavDashboard.IsSelected = true;
            if (panelNavProducts != null) panelNavProducts.IsSelected = false;

            panelNavDashboard?.Invalidate();
            panelNavProducts?.Invalidate();

            // Update main area: show cards, hide form and grid
            if (panelCards != null) panelCards.Visible = true;
            if (panelForm != null) panelForm.Visible = false;
            if (panelGrid != null) panelGrid.Visible = false;

            // Update header text
            if (labelTitle != null) labelTitle.Text = "Dashboard";
            if (labelSubtitle != null) labelSubtitle.Text = "Visão geral do inventário e métricas rápidas";

            // Ensure charts exist and are updated
            SetupPieChart();
            UpdateCharts();
            
            if (panelChart != null) panelChart.Visible = true;
            if (panelPieChart != null) panelPieChart.Visible = true;
        }

        private void ShowProducts()
        {
            if (panelNavDashboard != null) panelNavDashboard.IsSelected = false;
            if (panelNavProducts != null) panelNavProducts.IsSelected = true;

            panelNavDashboard?.Invalidate();
            panelNavProducts?.Invalidate();

            // Update main area: hide cards, show form and grid
            if (panelCards != null) panelCards.Visible = false;
            if (panelForm != null) panelForm.Visible = true;
            if (panelGrid != null) panelGrid.Visible = true;

            // Update header text
            if (labelTitle != null) labelTitle.Text = "Produtos";
            if (labelSubtitle != null) labelSubtitle.Text = "Gerencie seu inventário facilmente";

            if (panelChart != null) panelChart.Visible = false;
            if (panelPieChart != null) panelPieChart.Visible = false;
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            _fadeProgress += 0.04f;
            this.Opacity = Math.Min(1.0, _fadeProgress);
            if (this.Opacity >= 1.0)
            {
                _fadeInTimer.Stop();
                this.Opacity = 1.0;
            }
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
            // Update chart colors to reflect theme
            if (barChart != null)
            {
                barChart.BackColor = ThemeManager.BgCard;
            }
            if (panelChart != null)
            {
                panelChart.BackColor = ThemeManager.BgCard;
                panelChart.BorderColor = ThemeManager.BorderDefault;
            }
            if (pieChart != null)
            {
                pieChart.BackColor = ThemeManager.BgCard;
            }
            if (panelPieChart != null)
            {
                panelPieChart.BackColor = ThemeManager.BgCard;
                panelPieChart.BorderColor = ThemeManager.BorderDefault;
            }
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
            
            // Update nav items (only Dashboard and Products remain)
            lblNavDashboard.ForeColor = ThemeManager.TextSecondary;
            lblNavProducts.ForeColor = ThemeManager.TextPrimary;
            
            // Update nav panels hover color
            panelNavDashboard.HoverColor = ThemeManager.BgHover;
            panelNavProducts.HoverColor = ThemeManager.BgHover;
            
            panelNavDashboard.Invalidate();
            panelNavProducts.Invalidate();
            
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

                // Start fade-in animation
                _fadeProgress = 0f;
                this.Opacity = 0.0;
                _fadeInTimer.Start();

                // Attach hover fade effects to interactive controls
                try
                {
                    HoverFader.AttachToAll(this, 0.10f);
                }
                catch { }

                // Always start on Dashboard - hide product panels first
                panelForm.Visible = false;
                panelGrid.Visible = false;
                panelCards.Visible = true;
                
                // Setup chart after panels are configured
                SetupPieChart();

                // Now apply full dashboard state
                ShowDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}\n\nStack: {ex.StackTrace}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int newTotal = allProducts.Count;
            AnimateIntegerLabel(labelCardTotalValue, newTotal, 350);
            
            // Total value in stock (Euro)
            decimal totalValue = allProducts.Sum(p => p.Price * p.Quantity);
            labelCardValueValue.Text = totalValue.ToString("N2", EuroCulture) + " €";
            
            // Low stock (quantity <= 5)
            int lowStock = allProducts.Count(p => p.Quantity <= 5);
            labelCardLowStockValue.Text = lowStock.ToString();
            
            // Categories count (unique descriptions)
            int categories = allProducts.Select(p => p.Description).Where(d => !string.IsNullOrWhiteSpace(d)).Distinct().Count();
            labelCardCategoriesValue.Text = categories.ToString();

            // Update charts data as well
            UpdateCharts();
        }

        private void AnimateIntegerLabel(Label lbl, int target, int durationMs = 300)
        {
            if (lbl == null) return;

            int startVal = 0;
            if (!int.TryParse(lbl.Text, out startVal)) startVal = 0;

            if (startVal == target) return;

            int steps = Math.Max(1, durationMs / 16);
            int currentStep = 0;
            Timer t = new Timer { Interval = 16 };
            t.Tick += (s, e) =>
            {
                currentStep++;
                float progress = (float)currentStep / steps;
                int val = startVal + (int)((target - startVal) * progress);
                lbl.Text = val.ToString();
                if (currentStep >= steps)
                {
                    lbl.Text = target.ToString();
                    t.Stop();
                    t.Dispose();
                }
            };
            t.Start();
        }

        private void AnimatePanelPulse(Control ctrl)
        {
            if (ctrl == null) return;
            Color original = ctrl.BackColor;
            float progress = 0f;
            Timer t = new Timer { Interval = 16 };
            t.Tick += (s, e) =>
            {
                progress += 0.06f;
                if (progress >= 1f) progress = 1f;

                float intensity = (float)(Math.Sin(progress * Math.PI));
                ctrl.BackColor = RoundedHelper.LightenColor(original, 0.12f * intensity);

                if (progress >= 1f)
                {
                    // reverse animation
                    Timer rev = new Timer { Interval = 16 };
                    float revP = 0f;
                    rev.Tick += (s2, e2) =>
                    {
                        revP += 0.08f;
                        float rint = (float)(Math.Cos(revP * Math.PI / 2));
                        ctrl.BackColor = RoundedHelper.LightenColor(original, 0.12f * rint);
                        if (revP >= 1f)
                        {
                            ctrl.BackColor = original;
                            rev.Stop();
                            rev.Dispose();
                        }
                    };
                    rev.Start();

                    t.Stop();
                    t.Dispose();
                }
            };
            t.Start();
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

            // Pulse the grid area for feedback
            AnimatePanelPulse(panelGrid);

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

            // subtle pulse on form area
            AnimatePanelPulse(panelForm);

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
                AnimatePanelPulse(panelGrid);
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
            // Use a non-blocking toast notification for smoother UX
            try
            {
                ToastForm.Show(this, title, message, 3000);
            }
            catch
            {
                // Fallback to classic dialog if toast fails
                MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
            }
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
