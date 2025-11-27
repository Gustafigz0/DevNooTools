using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevNooTools
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Sidebar
        private Panel panelSidebar;
        private Panel panelLogo;
        private Label labelLogo;
        private Label labelLogoSub;
        private Label labelNavTitle;
        private Panel panelNavProducts;
        private Label labelNavProducts;
        private Panel panelNavFavorites;
        private Label labelNavFavorites;
        private Label labelActionsTitle;
        private Panel panelNavDelete;
        private Label labelNavDelete;
        private Label labelToolsTitle;
        private Panel panelNavExport;
        private Label labelNavExport;
        private Panel panelNavImport;
        private Label labelNavImport;
        private Panel panelUser;
        private Label labelUserName;

        // Main content
        private Panel panelMain;
        private Panel panelHeader;
        private Label labelWelcome;
        private Button btnAddProduct;
        private Button btnHistory;
        private TextBox textSearch;
        private ComboBox comboCategories;
        private ComboBox comboStock;

        // Grid
        private DataGridView dataGridViewProducts;
        private BindingSource bindingSourceProducts;

        // Form fields (for add/edit)
        private TextBox textName;
        private TextBox textDescription;
        private TextBox textPrice;
        private TextBox textQuantity;

        // Stats labels
        private Label labelCardTotalValue;
        private Label labelCardValueValue;
        private Label labelCardLowStockValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ============================================================
            // DARK THEME COLOR PALETTE (matching image)
            // ============================================================
            Color bgDark = Color.FromArgb(26, 32, 44);           // Main dark bg
            Color sidebarBg = Color.FromArgb(23, 25, 35);        // Sidebar darker
            Color cardBg = Color.FromArgb(35, 41, 54);           // Card/panel bg
            Color inputBg = Color.FromArgb(45, 52, 66);          // Input fields
            Color textPrimary = Color.FromArgb(255, 255, 255);   // White text
            Color textSecondary = Color.FromArgb(156, 163, 175); // Gray text
            Color textMuted = Color.FromArgb(107, 114, 128);     // Muted text
            Color accentGreen = Color.FromArgb(34, 197, 94);     // Green buttons
            Color accentGreenDark = Color.FromArgb(22, 163, 74); // Darker green
            Color accentBlue = Color.FromArgb(59, 130, 246);     // Blue
            Color accentRed = Color.FromArgb(239, 68, 68);       // Red/danger
            Color accentYellow = Color.FromArgb(234, 179, 8);    // Yellow/warning
            Color borderColor = Color.FromArgb(55, 65, 81);      // Borders
            Color hoverBg = Color.FromArgb(45, 55, 72);          // Hover state

            // ============================================================
            // FONTS
            // ============================================================
            Font fontLogo = new Font("Segoe UI", 13F, FontStyle.Bold);
            Font fontLogoSub = new Font("Segoe UI", 9F);
            Font fontNavTitle = new Font("Segoe UI", 8F, FontStyle.Bold);
            Font fontNav = new Font("Segoe UI", 10F);
            Font fontButton = new Font("Segoe UI", 9F, FontStyle.Bold);
            Font fontGrid = new Font("Segoe UI", 9F);
            Font fontGridHeader = new Font("Segoe UI", 9F, FontStyle.Bold);
            Font fontSearch = new Font("Segoe UI", 10F);
            Font fontWelcome = new Font("Segoe UI", 11F);

            // ============================================================
            // INITIALIZE CONTROLS
            // ============================================================
            this.panelSidebar = new Panel();
            this.panelLogo = new Panel();
            this.labelLogo = new Label();
            this.labelLogoSub = new Label();
            this.labelNavTitle = new Label();
            this.panelNavProducts = new Panel();
            this.labelNavProducts = new Label();
            this.panelNavFavorites = new Panel();
            this.labelNavFavorites = new Label();
            this.labelActionsTitle = new Label();
            this.panelNavDelete = new Panel();
            this.labelNavDelete = new Label();
            this.labelToolsTitle = new Label();
            this.panelNavExport = new Panel();
            this.labelNavExport = new Label();
            this.panelNavImport = new Panel();
            this.labelNavImport = new Label();
            this.panelUser = new Panel();
            this.labelUserName = new Label();
            this.panelMain = new Panel();
            this.panelHeader = new Panel();
            this.labelWelcome = new Label();
            this.btnAddProduct = new Button();
            this.btnHistory = new Button();
            this.textSearch = new TextBox();
            this.comboCategories = new ComboBox();
            this.comboStock = new ComboBox();
            this.dataGridViewProducts = new DataGridView();
            this.bindingSourceProducts = new BindingSource(this.components);
            this.textName = new TextBox();
            this.textDescription = new TextBox();
            this.textPrice = new TextBox();
            this.textQuantity = new TextBox();
            this.labelCardTotalValue = new Label();
            this.labelCardValueValue = new Label();
            this.labelCardLowStockValue = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            this.SuspendLayout();

            // ============================================================
            // SIDEBAR (220px wide, dark)
            // ============================================================
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.Width = 220;
            this.panelSidebar.BackColor = sidebarBg;
            this.panelSidebar.Padding = new Padding(0);

            // Logo area
            this.panelLogo.Location = new Point(15, 15);
            this.panelLogo.Size = new Size(190, 50);
            this.panelLogo.BackColor = Color.FromArgb(45, 55, 72);

            this.labelLogo.Text = "DevTools";
            this.labelLogo.Font = fontLogo;
            this.labelLogo.ForeColor = textPrimary;
            this.labelLogo.Location = new Point(45, 5);
            this.labelLogo.AutoSize = true;

            this.labelLogoSub.Text = "Manager";
            this.labelLogoSub.Font = fontLogoSub;
            this.labelLogoSub.ForeColor = textSecondary;
            this.labelLogoSub.Location = new Point(45, 26);
            this.labelLogoSub.AutoSize = true;

            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Controls.Add(this.labelLogoSub);

            // NAVIGATION section
            this.labelNavTitle.Text = "NAVIGATION";
            this.labelNavTitle.Font = fontNavTitle;
            this.labelNavTitle.ForeColor = textMuted;
            this.labelNavTitle.Location = new Point(20, 85);
            this.labelNavTitle.AutoSize = true;

            // Products nav (active)
            this.panelNavProducts.Location = new Point(0, 110);
            this.panelNavProducts.Size = new Size(220, 40);
            this.panelNavProducts.BackColor = accentGreen;
            this.panelNavProducts.Cursor = Cursors.Hand;

            this.labelNavProducts.Text = "    Products";
            this.labelNavProducts.Font = fontNav;
            this.labelNavProducts.ForeColor = textPrimary;
            this.labelNavProducts.Location = new Point(15, 10);
            this.labelNavProducts.AutoSize = true;
            this.panelNavProducts.Controls.Add(this.labelNavProducts);

            // Favorites nav
            this.panelNavFavorites.Location = new Point(0, 155);
            this.panelNavFavorites.Size = new Size(220, 40);
            this.panelNavFavorites.BackColor = sidebarBg;
            this.panelNavFavorites.Cursor = Cursors.Hand;

            this.labelNavFavorites.Text = "    Favorites";
            this.labelNavFavorites.Font = fontNav;
            this.labelNavFavorites.ForeColor = textSecondary;
            this.labelNavFavorites.Location = new Point(15, 10);
            this.labelNavFavorites.AutoSize = true;
            this.panelNavFavorites.Controls.Add(this.labelNavFavorites);

            // ACTIONS section
            this.labelActionsTitle.Text = "ACTIONS";
            this.labelActionsTitle.Font = fontNavTitle;
            this.labelActionsTitle.ForeColor = textMuted;
            this.labelActionsTitle.Location = new Point(20, 215);
            this.labelActionsTitle.AutoSize = true;

            // Delete Selected
            this.panelNavDelete.Location = new Point(0, 240);
            this.panelNavDelete.Size = new Size(220, 40);
            this.panelNavDelete.BackColor = sidebarBg;
            this.panelNavDelete.Cursor = Cursors.Hand;

            this.labelNavDelete.Text = "    Delete Selected";
            this.labelNavDelete.Font = fontNav;
            this.labelNavDelete.ForeColor = textSecondary;
            this.labelNavDelete.Location = new Point(15, 10);
            this.labelNavDelete.AutoSize = true;
            this.panelNavDelete.Controls.Add(this.labelNavDelete);
            this.panelNavDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.labelNavDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // TOOLS section
            this.labelToolsTitle.Text = "TOOLS";
            this.labelToolsTitle.Font = fontNavTitle;
            this.labelToolsTitle.ForeColor = textMuted;
            this.labelToolsTitle.Location = new Point(20, 300);
            this.labelToolsTitle.AutoSize = true;

            // Export
            this.panelNavExport.Location = new Point(0, 325);
            this.panelNavExport.Size = new Size(220, 40);
            this.panelNavExport.BackColor = sidebarBg;
            this.panelNavExport.Cursor = Cursors.Hand;

            this.labelNavExport.Text = "    Export";
            this.labelNavExport.Font = fontNav;
            this.labelNavExport.ForeColor = textSecondary;
            this.labelNavExport.Location = new Point(15, 10);
            this.labelNavExport.AutoSize = true;
            this.panelNavExport.Controls.Add(this.labelNavExport);

            // Import
            this.panelNavImport.Location = new Point(0, 370);
            this.panelNavImport.Size = new Size(220, 40);
            this.panelNavImport.BackColor = sidebarBg;
            this.panelNavImport.Cursor = Cursors.Hand;

            this.labelNavImport.Text = "    Import";
            this.labelNavImport.Font = fontNav;
            this.labelNavImport.ForeColor = textSecondary;
            this.labelNavImport.Location = new Point(15, 10);
            this.labelNavImport.AutoSize = true;
            this.panelNavImport.Controls.Add(this.labelNavImport);

            // User panel at bottom
            this.panelUser.Dock = DockStyle.Bottom;
            this.panelUser.Height = 60;
            this.panelUser.BackColor = sidebarBg;
            this.panelUser.Padding = new Padding(15);

            this.labelUserName.Text = "User";
            this.labelUserName.Font = fontNav;
            this.labelUserName.ForeColor = textSecondary;
            this.labelUserName.Location = new Point(50, 20);
            this.labelUserName.AutoSize = true;
            this.panelUser.Controls.Add(this.labelUserName);

            // Add all to sidebar
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Controls.Add(this.labelNavTitle);
            this.panelSidebar.Controls.Add(this.panelNavProducts);
            this.panelSidebar.Controls.Add(this.panelNavFavorites);
            this.panelSidebar.Controls.Add(this.labelActionsTitle);
            this.panelSidebar.Controls.Add(this.panelNavDelete);
            this.panelSidebar.Controls.Add(this.labelToolsTitle);
            this.panelSidebar.Controls.Add(this.panelNavExport);
            this.panelSidebar.Controls.Add(this.panelNavImport);
            this.panelSidebar.Controls.Add(this.panelUser);

            // ============================================================
            // MAIN PANEL
            // ============================================================
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.BackColor = bgDark;
            this.panelMain.Padding = new Padding(25);

            // ============================================================
            // HEADER
            // ============================================================
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 70;
            this.panelHeader.BackColor = bgDark;

            this.labelWelcome.Text = "Welcome back!";
            this.labelWelcome.Font = fontWelcome;
            this.labelWelcome.ForeColor = textSecondary;
            this.labelWelcome.Location = new Point(0, 10);
            this.labelWelcome.AutoSize = true;

            // Add Product button
            this.btnAddProduct.Location = new Point(600, 10);
            this.btnAddProduct.Size = new Size(120, 38);
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.Font = fontButton;
            this.btnAddProduct.FlatStyle = FlatStyle.Flat;
            this.btnAddProduct.BackColor = accentGreen;
            this.btnAddProduct.ForeColor = textPrimary;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.Cursor = Cursors.Hand;
            this.btnAddProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);

            // History button
            this.btnHistory.Location = new Point(730, 10);
            this.btnHistory.Size = new Size(90, 38);
            this.btnHistory.Text = "History";
            this.btnHistory.Font = fontButton;
            this.btnHistory.FlatStyle = FlatStyle.Flat;
            this.btnHistory.BackColor = cardBg;
            this.btnHistory.ForeColor = textSecondary;
            this.btnHistory.FlatAppearance.BorderColor = borderColor;
            this.btnHistory.FlatAppearance.BorderSize = 1;
            this.btnHistory.Cursor = Cursors.Hand;
            this.btnHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this.panelHeader.Controls.Add(this.labelWelcome);
            this.panelHeader.Controls.Add(this.btnAddProduct);
            this.panelHeader.Controls.Add(this.btnHistory);

            // ============================================================
            // SEARCH AND FILTERS ROW
            // ============================================================
            this.textSearch.Location = new Point(0, 75);
            this.textSearch.Size = new Size(300, 35);
            this.textSearch.Font = fontSearch;
            this.textSearch.BackColor = cardBg;
            this.textSearch.ForeColor = textSecondary;
            this.textSearch.BorderStyle = BorderStyle.FixedSingle;
            this.textSearch.Text = "Search products...";
            this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
            this.textSearch.Leave += new System.EventHandler(this.textSearch_Leave);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);

            this.comboCategories.Location = new Point(520, 75);
            this.comboCategories.Size = new Size(150, 35);
            this.comboCategories.Font = fontSearch;
            this.comboCategories.BackColor = cardBg;
            this.comboCategories.ForeColor = textSecondary;
            this.comboCategories.FlatStyle = FlatStyle.Flat;
            this.comboCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboCategories.Items.AddRange(new object[] { "All categories", "Audio", "Cameras", "Electronics" });
            this.comboCategories.SelectedIndex = 0;
            this.comboCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this.comboStock.Location = new Point(680, 75);
            this.comboStock.Size = new Size(140, 35);
            this.comboStock.Font = fontSearch;
            this.comboStock.BackColor = cardBg;
            this.comboStock.ForeColor = textSecondary;
            this.comboStock.FlatStyle = FlatStyle.Flat;
            this.comboStock.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboStock.Items.AddRange(new object[] { "All stock", "In stock", "Low stock", "Out of stock" });
            this.comboStock.SelectedIndex = 0;
            this.comboStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // ============================================================
            // DATA GRID
            // ============================================================
            this.dataGridViewProducts.Location = new Point(0, 120);
            this.dataGridViewProducts.Size = new Size(830, 450);
            this.dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridViewProducts.AutoGenerateColumns = true;
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.DataSource = this.bindingSourceProducts;
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.Font = fontGrid;
            this.dataGridViewProducts.BackgroundColor = cardBg;
            this.dataGridViewProducts.BorderStyle = BorderStyle.None;
            this.dataGridViewProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProducts.GridColor = borderColor;
            this.dataGridViewProducts.DefaultCellStyle.BackColor = cardBg;
            this.dataGridViewProducts.DefaultCellStyle.ForeColor = textPrimary;
            this.dataGridViewProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 65, 81);
            this.dataGridViewProducts.DefaultCellStyle.SelectionForeColor = textPrimary;
            this.dataGridViewProducts.DefaultCellStyle.Padding = new Padding(10, 12, 10, 12);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = cardBg;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = textSecondary;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = fontGridHeader;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 15, 10, 15);
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.ColumnHeadersHeight = 50;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProducts.RowTemplate.Height = 55;
            this.dataGridViewProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 46, 58);
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            this.dataGridViewProducts.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewProducts_CellDoubleClick);

            // Hidden input fields for edit functionality
            this.textName.Visible = false;
            this.textDescription.Visible = false;
            this.textPrice.Visible = false;
            this.textQuantity.Visible = false;

            // Hidden stats labels
            this.labelCardTotalValue.Visible = false;
            this.labelCardValueValue.Visible = false;
            this.labelCardLowStockValue.Visible = false;

            // ============================================================
            // ASSEMBLE MAIN PANEL
            // ============================================================
            this.panelMain.Controls.Add(this.dataGridViewProducts);
            this.panelMain.Controls.Add(this.textSearch);
            this.panelMain.Controls.Add(this.comboCategories);
            this.panelMain.Controls.Add(this.comboStock);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.textName);
            this.panelMain.Controls.Add(this.textDescription);
            this.panelMain.Controls.Add(this.textPrice);
            this.panelMain.Controls.Add(this.textQuantity);
            this.panelMain.Controls.Add(this.labelCardTotalValue);
            this.panelMain.Controls.Add(this.labelCardValueValue);
            this.panelMain.Controls.Add(this.labelCardLowStockValue);

            // ============================================================
            // FORM
            // ============================================================
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1100, 650);
            this.MinimumSize = new Size(900, 550);
            this.BackColor = bgDark;
            this.Font = new Font("Segoe UI", 9F);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Text = "DevTools Manager";
            this.StartPosition = FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
