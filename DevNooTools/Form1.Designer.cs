namespace DevNooTools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Sidebar
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelLogoSub;
        private System.Windows.Forms.Panel panelNavDashboard;
        private System.Windows.Forms.Label labelNavDashboard;
        private System.Windows.Forms.Panel panelNavProducts;
        private System.Windows.Forms.Label labelNavProducts;
        private System.Windows.Forms.Panel panelNavCategories;
        private System.Windows.Forms.Label labelNavCategories;
        private System.Windows.Forms.Panel panelNavReports;
        private System.Windows.Forms.Label labelNavReports;
        private System.Windows.Forms.Panel panelNavSettings;
        private System.Windows.Forms.Label labelNavSettings;
        private System.Windows.Forms.Label labelVersion;

        // Main content
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.Label labelPageSubtitle;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnExport;

        // Stats cards
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel cardTotalProducts;
        private System.Windows.Forms.Label labelCardTotalIcon;
        private System.Windows.Forms.Label labelCardTotalTitle;
        private System.Windows.Forms.Label labelCardTotalValue;
        private System.Windows.Forms.Panel cardTotalValue;
        private System.Windows.Forms.Label labelCardValueIcon;
        private System.Windows.Forms.Label labelCardValueTitle;
        private System.Windows.Forms.Label labelCardValueValue;
        private System.Windows.Forms.Panel cardLowStock;
        private System.Windows.Forms.Label labelCardLowStockIcon;
        private System.Windows.Forms.Label labelCardLowStockTitle;
        private System.Windows.Forms.Label labelCardLowStockValue;
        private System.Windows.Forms.Panel cardCategories;
        private System.Windows.Forms.Label labelCardCategoriesIcon;
        private System.Windows.Forms.Label labelCardCategoriesTitle;
        private System.Windows.Forms.Label labelCardCategoriesValue;

        // Form panel
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Panel panelFormButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        // Grid
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label labelGridTitle;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.BindingSource bindingSourceProducts;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ============================================================
            // PROFESSIONAL COLOR PALETTE
            // ============================================================
            System.Drawing.Color sidebarBg = System.Drawing.Color.FromArgb(15, 23, 42);
            System.Drawing.Color sidebarHover = System.Drawing.Color.FromArgb(30, 41, 59);
            System.Drawing.Color sidebarActive = System.Drawing.Color.FromArgb(59, 130, 246);
            System.Drawing.Color mainBg = System.Drawing.Color.FromArgb(241, 245, 249);
            System.Drawing.Color cardBg = System.Drawing.Color.White;
            System.Drawing.Color textPrimary = System.Drawing.Color.FromArgb(15, 23, 42);
            System.Drawing.Color textSecondary = System.Drawing.Color.FromArgb(100, 116, 139);
            System.Drawing.Color textMuted = System.Drawing.Color.FromArgb(148, 163, 184);
            System.Drawing.Color accentBlue = System.Drawing.Color.FromArgb(59, 130, 246);
            System.Drawing.Color accentGreen = System.Drawing.Color.FromArgb(34, 197, 94);
            System.Drawing.Color accentRed = System.Drawing.Color.FromArgb(239, 68, 68);
            System.Drawing.Color accentOrange = System.Drawing.Color.FromArgb(249, 115, 22);
            System.Drawing.Color accentPurple = System.Drawing.Color.FromArgb(168, 85, 247);
            System.Drawing.Color borderLight = System.Drawing.Color.FromArgb(226, 232, 240);
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color cardBlue = System.Drawing.Color.FromArgb(239, 246, 255);
            System.Drawing.Color cardGreen = System.Drawing.Color.FromArgb(240, 253, 244);
            System.Drawing.Color cardOrange = System.Drawing.Color.FromArgb(255, 247, 237);
            System.Drawing.Color cardPurple = System.Drawing.Color.FromArgb(250, 245, 255);

            // ============================================================
            // FONTS
            // ============================================================
            System.Drawing.Font fontLogo = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontLogoSub = new System.Drawing.Font("Segoe UI", 8F);
            System.Drawing.Font fontNav = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontNavActive = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontPageTitle = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontPageSubtitle = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontCardIcon = new System.Drawing.Font("Segoe UI", 18F);
            System.Drawing.Font fontCardTitle = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fontCardValue = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontFormTitle = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontLabel = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontInput = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontButton = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontGrid = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fontGridTitle = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontSearch = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontVersion = new System.Drawing.Font("Segoe UI", 8F);

            // ============================================================
            // INITIALIZE CONTROLS
            // ============================================================
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelLogoSub = new System.Windows.Forms.Label();
            this.panelNavDashboard = new System.Windows.Forms.Panel();
            this.labelNavDashboard = new System.Windows.Forms.Label();
            this.panelNavProducts = new System.Windows.Forms.Panel();
            this.labelNavProducts = new System.Windows.Forms.Label();
            this.panelNavCategories = new System.Windows.Forms.Panel();
            this.labelNavCategories = new System.Windows.Forms.Label();
            this.panelNavReports = new System.Windows.Forms.Panel();
            this.labelNavReports = new System.Windows.Forms.Label();
            this.panelNavSettings = new System.Windows.Forms.Panel();
            this.labelNavSettings = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.labelPageSubtitle = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.cardTotalProducts = new System.Windows.Forms.Panel();
            this.labelCardTotalIcon = new System.Windows.Forms.Label();
            this.labelCardTotalTitle = new System.Windows.Forms.Label();
            this.labelCardTotalValue = new System.Windows.Forms.Label();
            this.cardTotalValue = new System.Windows.Forms.Panel();
            this.labelCardValueIcon = new System.Windows.Forms.Label();
            this.labelCardValueTitle = new System.Windows.Forms.Label();
            this.labelCardValueValue = new System.Windows.Forms.Label();
            this.cardLowStock = new System.Windows.Forms.Panel();
            this.labelCardLowStockIcon = new System.Windows.Forms.Label();
            this.labelCardLowStockTitle = new System.Windows.Forms.Label();
            this.labelCardLowStockValue = new System.Windows.Forms.Label();
            this.cardCategories = new System.Windows.Forms.Panel();
            this.labelCardCategoriesIcon = new System.Windows.Forms.Label();
            this.labelCardCategoriesTitle = new System.Windows.Forms.Label();
            this.labelCardCategoriesValue = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.panelFormButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.labelGridTitle = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.bindingSourceProducts = new System.Windows.Forms.BindingSource(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            this.SuspendLayout();

            // ============================================================
            // SIDEBAR
            // ============================================================
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Width = 240;
            this.panelSidebar.BackColor = sidebarBg;
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(0);

            // Logo
            this.labelLogo.Text = "DevNooTools";
            this.labelLogo.Font = fontLogo;
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(20, 25);
            this.labelLogo.AutoSize = true;

            this.labelLogoSub.Text = "Sistema de Gestao de Produtos";
            this.labelLogoSub.Font = fontLogoSub;
            this.labelLogoSub.ForeColor = textMuted;
            this.labelLogoSub.Location = new System.Drawing.Point(22, 55);
            this.labelLogoSub.AutoSize = true;

            // Dashboard Nav
            this.panelNavDashboard.Location = new System.Drawing.Point(10, 100);
            this.panelNavDashboard.Size = new System.Drawing.Size(220, 44);
            this.panelNavDashboard.BackColor = sidebarHover;
            this.panelNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;

            this.labelNavDashboard.Text = "     Dashboard";
            this.labelNavDashboard.Font = fontNav;
            this.labelNavDashboard.ForeColor = textMuted;
            this.labelNavDashboard.Location = new System.Drawing.Point(15, 12);
            this.labelNavDashboard.AutoSize = true;
            this.labelNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;

            this.panelNavDashboard.Controls.Add(this.labelNavDashboard);

            // Products Nav (Active)
            this.panelNavProducts.Location = new System.Drawing.Point(10, 150);
            this.panelNavProducts.Size = new System.Drawing.Size(220, 44);
            this.panelNavProducts.BackColor = sidebarActive;
            this.panelNavProducts.Cursor = System.Windows.Forms.Cursors.Hand;

            this.labelNavProducts.Text = "     Produtos";
            this.labelNavProducts.Font = fontNavActive;
            this.labelNavProducts.ForeColor = System.Drawing.Color.White;
            this.labelNavProducts.Location = new System.Drawing.Point(15, 12);
            this.labelNavProducts.AutoSize = true;
            this.labelNavProducts.Cursor = System.Windows.Forms.Cursors.Hand;

            this.panelNavProducts.Controls.Add(this.labelNavProducts);

            // Categories Nav
            this.panelNavCategories.Location = new System.Drawing.Point(10, 200);
            this.panelNavCategories.Size = new System.Drawing.Size(220, 44);
            this.panelNavCategories.BackColor = System.Drawing.Color.Transparent;
            this.panelNavCategories.Cursor = System.Windows.Forms.Cursors.Hand;

            this.labelNavCategories.Text = "     Categorias";
            this.labelNavCategories.Font = fontNav;
            this.labelNavCategories.ForeColor = textMuted;
            this.labelNavCategories.Location = new System.Drawing.Point(15, 12);
            this.labelNavCategories.AutoSize = true;
            this.labelNavCategories.Cursor = System.Windows.Forms.Cursors.Hand;

            this.panelNavCategories.Controls.Add(this.labelNavCategories);

            // Reports Nav
            this.panelNavReports.Location = new System.Drawing.Point(10, 250);
            this.panelNavReports.Size = new System.Drawing.Size(220, 44);
            this.panelNavReports.BackColor = System.Drawing.Color.Transparent;
            this.panelNavReports.Cursor = System.Windows.Forms.Cursors.Hand;

            this.labelNavReports.Text = "     Relatorios";
            this.labelNavReports.Font = fontNav;
            this.labelNavReports.ForeColor = textMuted;
            this.labelNavReports.Location = new System.Drawing.Point(15, 12);
            this.labelNavReports.AutoSize = true;
            this.labelNavReports.Cursor = System.Windows.Forms.Cursors.Hand;

            this.panelNavReports.Controls.Add(this.labelNavReports);

            // Settings Nav
            this.panelNavSettings.Location = new System.Drawing.Point(10, 300);
            this.panelNavSettings.Size = new System.Drawing.Size(220, 44);
            this.panelNavSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelNavSettings.Cursor = System.Windows.Forms.Cursors.Hand;

            this.labelNavSettings.Text = "     Configuracoes";
            this.labelNavSettings.Font = fontNav;
            this.labelNavSettings.ForeColor = textMuted;
            this.labelNavSettings.Location = new System.Drawing.Point(15, 12);
            this.labelNavSettings.AutoSize = true;
            this.labelNavSettings.Cursor = System.Windows.Forms.Cursors.Hand;

            this.panelNavSettings.Controls.Add(this.labelNavSettings);

            // Version
            this.labelVersion.Text = "v1.0.0";
            this.labelVersion.Font = fontVersion;
            this.labelVersion.ForeColor = textMuted;
            this.labelVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.labelVersion.Location = new System.Drawing.Point(20, 680);
            this.labelVersion.AutoSize = true;

            this.panelSidebar.Controls.Add(this.labelLogo);
            this.panelSidebar.Controls.Add(this.labelLogoSub);
            this.panelSidebar.Controls.Add(this.panelNavDashboard);
            this.panelSidebar.Controls.Add(this.panelNavProducts);
            this.panelSidebar.Controls.Add(this.panelNavCategories);
            this.panelSidebar.Controls.Add(this.panelNavReports);
            this.panelSidebar.Controls.Add(this.panelNavSettings);
            this.panelSidebar.Controls.Add(this.labelVersion);

            // ============================================================
            // MAIN PANEL
            // ============================================================
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.BackColor = mainBg;
            this.panelMain.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);

            // ============================================================
            // HEADER
            // ============================================================
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 80;
            this.panelHeader.BackColor = mainBg;
            this.panelHeader.Padding = new System.Windows.Forms.Padding(0, 5, 0, 15);

            this.labelPageTitle.Text = "Gestao de Produtos";
            this.labelPageTitle.Font = fontPageTitle;
            this.labelPageTitle.ForeColor = textPrimary;
            this.labelPageTitle.Location = new System.Drawing.Point(0, 5);
            this.labelPageTitle.AutoSize = true;

            this.labelPageSubtitle.Text = "Gerencie seu inventario de forma simples e eficiente";
            this.labelPageSubtitle.Font = fontPageSubtitle;
            this.labelPageSubtitle.ForeColor = textSecondary;
            this.labelPageSubtitle.Location = new System.Drawing.Point(2, 40);
            this.labelPageSubtitle.AutoSize = true;

            this.textSearch.Location = new System.Drawing.Point(480, 15);
            this.textSearch.Size = new System.Drawing.Size(260, 35);
            this.textSearch.Font = fontSearch;
            this.textSearch.BackColor = cardBg;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSearch.ForeColor = textSecondary;
            this.textSearch.Text = "Buscar produtos...";
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
            this.textSearch.Leave += new System.EventHandler(this.textSearch_Leave);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);

            this.btnExport.Location = new System.Drawing.Point(755, 12);
            this.btnExport.Size = new System.Drawing.Size(110, 38);
            this.btnExport.Text = "Exportar";
            this.btnExport.Font = fontButton;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.BackColor = accentPurple;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            this.panelHeader.Controls.Add(this.labelPageTitle);
            this.panelHeader.Controls.Add(this.labelPageSubtitle);
            this.panelHeader.Controls.Add(this.textSearch);
            this.panelHeader.Controls.Add(this.btnExport);

            // ============================================================
            // STATS CARDS
            // ============================================================
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Height = 120;
            this.panelStats.BackColor = mainBg;
            this.panelStats.Padding = new System.Windows.Forms.Padding(0, 5, 0, 15);

            // Card 1: Total Products
            this.cardTotalProducts.Location = new System.Drawing.Point(0, 0);
            this.cardTotalProducts.Size = new System.Drawing.Size(200, 100);
            this.cardTotalProducts.BackColor = cardBlue;
            this.cardTotalProducts.Padding = new System.Windows.Forms.Padding(15);

            this.labelCardTotalIcon.Text = "[#]";
            this.labelCardTotalIcon.Font = fontCardIcon;
            this.labelCardTotalIcon.ForeColor = accentBlue;
            this.labelCardTotalIcon.Location = new System.Drawing.Point(15, 12);
            this.labelCardTotalIcon.AutoSize = true;

            this.labelCardTotalTitle.Text = "Total de Produtos";
            this.labelCardTotalTitle.Font = fontCardTitle;
            this.labelCardTotalTitle.ForeColor = textSecondary;
            this.labelCardTotalTitle.Location = new System.Drawing.Point(55, 18);
            this.labelCardTotalTitle.AutoSize = true;

            this.labelCardTotalValue.Text = "0";
            this.labelCardTotalValue.Font = fontCardValue;
            this.labelCardTotalValue.ForeColor = accentBlue;
            this.labelCardTotalValue.Location = new System.Drawing.Point(15, 50);
            this.labelCardTotalValue.AutoSize = true;

            this.cardTotalProducts.Controls.Add(this.labelCardTotalIcon);
            this.cardTotalProducts.Controls.Add(this.labelCardTotalTitle);
            this.cardTotalProducts.Controls.Add(this.labelCardTotalValue);

            // Card 2: Total Value
            this.cardTotalValue.Location = new System.Drawing.Point(215, 0);
            this.cardTotalValue.Size = new System.Drawing.Size(200, 100);
            this.cardTotalValue.BackColor = cardGreen;
            this.cardTotalValue.Padding = new System.Windows.Forms.Padding(15);

            this.labelCardValueIcon.Text = "[E]";
            this.labelCardValueIcon.Font = fontCardIcon;
            this.labelCardValueIcon.ForeColor = accentGreen;
            this.labelCardValueIcon.Location = new System.Drawing.Point(15, 12);
            this.labelCardValueIcon.AutoSize = true;

            this.labelCardValueTitle.Text = "Valor em Estoque";
            this.labelCardValueTitle.Font = fontCardTitle;
            this.labelCardValueTitle.ForeColor = textSecondary;
            this.labelCardValueTitle.Location = new System.Drawing.Point(55, 18);
            this.labelCardValueTitle.AutoSize = true;

            this.labelCardValueValue.Text = "0,00 E";
            this.labelCardValueValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelCardValueValue.ForeColor = accentGreen;
            this.labelCardValueValue.Location = new System.Drawing.Point(15, 50);
            this.labelCardValueValue.AutoSize = true;

            this.cardTotalValue.Controls.Add(this.labelCardValueIcon);
            this.cardTotalValue.Controls.Add(this.labelCardValueTitle);
            this.cardTotalValue.Controls.Add(this.labelCardValueValue);

            // Card 3: Low Stock
            this.cardLowStock.Location = new System.Drawing.Point(430, 0);
            this.cardLowStock.Size = new System.Drawing.Size(200, 100);
            this.cardLowStock.BackColor = cardOrange;
            this.cardLowStock.Padding = new System.Windows.Forms.Padding(15);

            this.labelCardLowStockIcon.Text = "[!]";
            this.labelCardLowStockIcon.Font = fontCardIcon;
            this.labelCardLowStockIcon.ForeColor = accentOrange;
            this.labelCardLowStockIcon.Location = new System.Drawing.Point(15, 12);
            this.labelCardLowStockIcon.AutoSize = true;

            this.labelCardLowStockTitle.Text = "Estoque Baixo";
            this.labelCardLowStockTitle.Font = fontCardTitle;
            this.labelCardLowStockTitle.ForeColor = textSecondary;
            this.labelCardLowStockTitle.Location = new System.Drawing.Point(55, 18);
            this.labelCardLowStockTitle.AutoSize = true;

            this.labelCardLowStockValue.Text = "0";
            this.labelCardLowStockValue.Font = fontCardValue;
            this.labelCardLowStockValue.ForeColor = accentOrange;
            this.labelCardLowStockValue.Location = new System.Drawing.Point(15, 50);
            this.labelCardLowStockValue.AutoSize = true;

            this.cardLowStock.Controls.Add(this.labelCardLowStockIcon);
            this.cardLowStock.Controls.Add(this.labelCardLowStockTitle);
            this.cardLowStock.Controls.Add(this.labelCardLowStockValue);

            // Card 4: Categories
            this.cardCategories.Location = new System.Drawing.Point(645, 0);
            this.cardCategories.Size = new System.Drawing.Size(200, 100);
            this.cardCategories.BackColor = cardPurple;
            this.cardCategories.Padding = new System.Windows.Forms.Padding(15);

            this.labelCardCategoriesIcon.Text = "[C]";
            this.labelCardCategoriesIcon.Font = fontCardIcon;
            this.labelCardCategoriesIcon.ForeColor = accentPurple;
            this.labelCardCategoriesIcon.Location = new System.Drawing.Point(15, 12);
            this.labelCardCategoriesIcon.AutoSize = true;

            this.labelCardCategoriesTitle.Text = "Categorias";
            this.labelCardCategoriesTitle.Font = fontCardTitle;
            this.labelCardCategoriesTitle.ForeColor = textSecondary;
            this.labelCardCategoriesTitle.Location = new System.Drawing.Point(55, 18);
            this.labelCardCategoriesTitle.AutoSize = true;

            this.labelCardCategoriesValue.Text = "0";
            this.labelCardCategoriesValue.Font = fontCardValue;
            this.labelCardCategoriesValue.ForeColor = accentPurple;
            this.labelCardCategoriesValue.Location = new System.Drawing.Point(15, 50);
            this.labelCardCategoriesValue.AutoSize = true;

            this.cardCategories.Controls.Add(this.labelCardCategoriesIcon);
            this.cardCategories.Controls.Add(this.labelCardCategoriesTitle);
            this.cardCategories.Controls.Add(this.labelCardCategoriesValue);

            this.panelStats.Controls.Add(this.cardTotalProducts);
            this.panelStats.Controls.Add(this.cardTotalValue);
            this.panelStats.Controls.Add(this.cardLowStock);
            this.panelStats.Controls.Add(this.cardCategories);

            // ============================================================
            // FORM PANEL
            // ============================================================
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Height = 170;
            this.panelForm.BackColor = cardBg;
            this.panelForm.Padding = new System.Windows.Forms.Padding(25);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);

            this.labelFormTitle.Text = "Adicionar / Editar Produto";
            this.labelFormTitle.Font = fontFormTitle;
            this.labelFormTitle.ForeColor = textPrimary;
            this.labelFormTitle.Location = new System.Drawing.Point(25, 18);
            this.labelFormTitle.AutoSize = true;

            this.labelName.Text = "NOME *";
            this.labelName.Font = fontLabel;
            this.labelName.ForeColor = textSecondary;
            this.labelName.Location = new System.Drawing.Point(25, 55);
            this.labelName.AutoSize = true;

            this.textName.Location = new System.Drawing.Point(25, 75);
            this.textName.Size = new System.Drawing.Size(180, 30);
            this.textName.Font = fontInput;
            this.textName.BackColor = inputBg;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.labelDescription.Text = "DESCRICAO";
            this.labelDescription.Font = fontLabel;
            this.labelDescription.ForeColor = textSecondary;
            this.labelDescription.Location = new System.Drawing.Point(225, 55);
            this.labelDescription.AutoSize = true;

            this.textDescription.Location = new System.Drawing.Point(225, 75);
            this.textDescription.Size = new System.Drawing.Size(250, 30);
            this.textDescription.Font = fontInput;
            this.textDescription.BackColor = inputBg;
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.labelPrice.Text = "PRECO (EUR)";
            this.labelPrice.Font = fontLabel;
            this.labelPrice.ForeColor = textSecondary;
            this.labelPrice.Location = new System.Drawing.Point(495, 55);
            this.labelPrice.AutoSize = true;

            this.textPrice.Location = new System.Drawing.Point(495, 75);
            this.textPrice.Size = new System.Drawing.Size(110, 30);
            this.textPrice.Font = fontInput;
            this.textPrice.BackColor = inputBg;
            this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.labelQuantity.Text = "QTD";
            this.labelQuantity.Font = fontLabel;
            this.labelQuantity.ForeColor = textSecondary;
            this.labelQuantity.Location = new System.Drawing.Point(625, 55);
            this.labelQuantity.AutoSize = true;

            this.textQuantity.Location = new System.Drawing.Point(625, 75);
            this.textQuantity.Size = new System.Drawing.Size(80, 30);
            this.textQuantity.Font = fontInput;
            this.textQuantity.BackColor = inputBg;
            this.textQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.panelFormButtons.Location = new System.Drawing.Point(25, 118);
            this.panelFormButtons.Size = new System.Drawing.Size(700, 45);
            this.panelFormButtons.BackColor = cardBg;

            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.Text = "+ Adicionar";
            this.btnAdd.Font = fontButton;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.BackColor = accentGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.Location = new System.Drawing.Point(130, 0);
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.Text = "Salvar";
            this.btnSave.Font = fontButton;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.BackColor = accentBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDelete.Location = new System.Drawing.Point(250, 0);
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.Text = "Excluir";
            this.btnDelete.Font = fontButton;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.BackColor = accentRed;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Location = new System.Drawing.Point(370, 0);
            this.btnClear.Size = new System.Drawing.Size(110, 40);
            this.btnClear.Text = "Limpar";
            this.btnClear.Font = fontButton;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.panelFormButtons.Controls.Add(this.btnAdd);
            this.panelFormButtons.Controls.Add(this.btnSave);
            this.panelFormButtons.Controls.Add(this.btnDelete);
            this.panelFormButtons.Controls.Add(this.btnClear);

            this.panelForm.Controls.Add(this.labelFormTitle);
            this.panelForm.Controls.Add(this.labelName);
            this.panelForm.Controls.Add(this.textName);
            this.panelForm.Controls.Add(this.labelDescription);
            this.panelForm.Controls.Add(this.textDescription);
            this.panelForm.Controls.Add(this.labelPrice);
            this.panelForm.Controls.Add(this.textPrice);
            this.panelForm.Controls.Add(this.labelQuantity);
            this.panelForm.Controls.Add(this.textQuantity);
            this.panelForm.Controls.Add(this.panelFormButtons);

            // ============================================================
            // GRID PANEL
            // ============================================================
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.BackColor = cardBg;
            this.panelGrid.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);

            this.labelGridTitle.Text = "Lista de Produtos";
            this.labelGridTitle.Font = fontGridTitle;
            this.labelGridTitle.ForeColor = textPrimary;
            this.labelGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGridTitle.Padding = new System.Windows.Forms.Padding(20, 15, 20, 10);
            this.labelGridTitle.AutoSize = false;
            this.labelGridTitle.Height = 45;

            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.AutoGenerateColumns = true;
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.DataSource = this.bindingSourceProducts;
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.Font = fontGrid;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProducts.GridColor = borderLight;
            this.dataGridViewProducts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            this.dataGridViewProducts.DefaultCellStyle.SelectionForeColor = textPrimary;
            this.dataGridViewProducts.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = textSecondary;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.ColumnHeadersHeight = 55;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProducts.RowTemplate.Height = 50;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);

            this.panelGrid.Controls.Add(this.dataGridViewProducts);
            this.panelGrid.Controls.Add(this.labelGridTitle);

            // ============================================================
            // ASSEMBLY
            // ============================================================
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.panelStats);
            this.panelMain.Controls.Add(this.panelHeader);

            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            this.ResumeLayout(false);

            // ============================================================
            // FORM SETTINGS
            // ============================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Text = "DevNooTools - Sistema de Gestao de Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackColor = mainBg;
        }

        #endregion
    }
}
