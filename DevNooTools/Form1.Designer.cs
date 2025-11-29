namespace DevNooTools
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Sidebar
        private RoundedPanel panelSidebar;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelLogoSub;
        private RoundedPanel panelNavDashboard;
        private System.Windows.Forms.Label labelNavDashboard;
        private RoundedPanel panelNavProducts;
        private System.Windows.Forms.Label labelNavProducts;
        private RoundedPanel panelNavCategories;
        private System.Windows.Forms.Label labelNavCategories;
        private RoundedPanel panelNavReports;
        private System.Windows.Forms.Label labelNavReports;
        private RoundedPanel panelNavSettings;
        private System.Windows.Forms.Label labelNavSettings;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.PictureBox pictureLogo;

        // Main
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.Label labelPageSubtitle;
        private RoundedTextBox textSearch;
        private RoundedButton btnAddProduct;

        // Cards
        private System.Windows.Forms.Panel panelStats;
        private RoundedPanel cardTotal;
        private System.Windows.Forms.Label labelCardTotalIcon;
        private System.Windows.Forms.Label labelCardTotalTitle;
        private System.Windows.Forms.Label labelCardTotalValue;
        private RoundedPanel cardValue;
        private System.Windows.Forms.Label labelCardValueIcon;
        private System.Windows.Forms.Label labelCardValueTitle;
        private System.Windows.Forms.Label labelCardValueValue;
        private RoundedPanel cardLowStock;
        private System.Windows.Forms.Label labelCardLowStockIcon;
        private System.Windows.Forms.Label labelCardLowStockTitle;
        private System.Windows.Forms.Label labelCardLowStockValue;
        private RoundedPanel cardCategories;
        private System.Windows.Forms.Label labelCardCategoriesIcon;
        private System.Windows.Forms.Label labelCardCategoriesTitle;
        private System.Windows.Forms.Label labelCardCategoriesValue;

        // Form Panel
        private RoundedPanel panelForm;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Label labelName;
        private RoundedTextBox textName;
        private System.Windows.Forms.Label labelDescription;
        private RoundedTextBox textDescription;
        private System.Windows.Forms.Label labelPrice;
        private RoundedTextBox textPrice;
        private System.Windows.Forms.Label labelQuantity;
        private RoundedTextBox textQuantity;
        private System.Windows.Forms.Panel panelFormButtons;
        private RoundedButton btnAdd;
        private RoundedButton btnSave;
        private RoundedButton btnDelete;
        private RoundedButton btnClear;

        // Grid
        private RoundedPanel panelGrid;
        private System.Windows.Forms.Label labelGridTitle;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.BindingSource bindingSourceProducts;

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

            // ===== MODERN DARK THEME COLORS =====
            System.Drawing.Color bgDark = System.Drawing.Color.FromArgb(17, 24, 39);
            System.Drawing.Color bgCard = System.Drawing.Color.FromArgb(31, 41, 55);
            System.Drawing.Color bgCardLight = System.Drawing.Color.FromArgb(55, 65, 81);
            System.Drawing.Color bgInput = System.Drawing.Color.FromArgb(31, 41, 55);
            System.Drawing.Color borderColor = System.Drawing.Color.FromArgb(55, 65, 81);
            System.Drawing.Color accentGreen = System.Drawing.Color.FromArgb(34, 197, 94);
            System.Drawing.Color accentBlue = System.Drawing.Color.FromArgb(59, 130, 246);
            System.Drawing.Color accentRed = System.Drawing.Color.FromArgb(239, 68, 68);
            System.Drawing.Color accentOrange = System.Drawing.Color.FromArgb(249, 115, 22);
            System.Drawing.Color accentPurple = System.Drawing.Color.FromArgb(168, 85, 247);
            System.Drawing.Color accentCyan = System.Drawing.Color.FromArgb(6, 182, 212);
            System.Drawing.Color textWhite = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color textGray = System.Drawing.Color.FromArgb(156, 163, 175);
            System.Drawing.Color textMuted = System.Drawing.Color.FromArgb(107, 114, 128);

            // ===== FONTS =====
            System.Drawing.Font fontLogo = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontLogoSub = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fontNav = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontNavActive = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontTitle = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontSubtitle = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontCardIcon = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontCardTitle = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fontCardValue = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontFormTitle = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontLabel = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontButton = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontGrid = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontVersion = new System.Drawing.Font("Segoe UI", 8F);

            this.bindingSourceProducts = new System.Windows.Forms.BindingSource(this.components);

            // ===== SIDEBAR =====
            this.panelSidebar = new RoundedPanel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelLogoSub = new System.Windows.Forms.Label();
            this.panelNavDashboard = new RoundedPanel();
            this.labelNavDashboard = new System.Windows.Forms.Label();
            this.panelNavProducts = new RoundedPanel();
            this.labelNavProducts = new System.Windows.Forms.Label();
            this.panelNavCategories = new RoundedPanel();
            this.labelNavCategories = new System.Windows.Forms.Label();
            this.panelNavReports = new RoundedPanel();
            this.labelNavReports = new System.Windows.Forms.Label();
            this.panelNavSettings = new RoundedPanel();
            this.labelNavSettings = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();

            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Width = 260;
            this.panelSidebar.BackColor = bgCard;
            this.panelSidebar.Radius = 0;
            this.panelSidebar.BorderSize = 0;
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(16, 20, 16, 20);

            // Logo
            this.labelLogo.Text = "DevNooTools";
            this.labelLogo.Font = fontLogo;
            this.labelLogo.ForeColor = textWhite;
            this.labelLogo.Location = new System.Drawing.Point(24, 30);
            this.labelLogo.AutoSize = true;

            this.labelLogoSub.Text = "Sistema de Gestao de Produtos";
            this.labelLogoSub.Font = fontLogoSub;
            this.labelLogoSub.ForeColor = textMuted;
            this.labelLogoSub.Location = new System.Drawing.Point(26, 60);
            this.labelLogoSub.AutoSize = true;

            // Nav Items
            int navY = 110;
            int navH = 48;
            int navGap = 8;
            int navX = 16;
            int navW = 228;

            // Dashboard
            this.panelNavDashboard.Location = new System.Drawing.Point(navX, navY);
            this.panelNavDashboard.Size = new System.Drawing.Size(navW, navH);
            this.panelNavDashboard.BackColor = System.Drawing.Color.Transparent;
            this.panelNavDashboard.Radius = 12;
            this.panelNavDashboard.BorderSize = 0;
            this.panelNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;

            this.labelNavDashboard.Text = "     Dashboard";
            this.labelNavDashboard.Font = fontNav;
            this.labelNavDashboard.ForeColor = textGray;
            this.labelNavDashboard.Location = new System.Drawing.Point(16, 14);
            this.labelNavDashboard.AutoSize = true;
            this.panelNavDashboard.Controls.Add(this.labelNavDashboard);

            navY += navH + navGap;

            // Products (Active)
            this.panelNavProducts.Location = new System.Drawing.Point(navX, navY);
            this.panelNavProducts.Size = new System.Drawing.Size(navW, navH);
            this.panelNavProducts.BackColor = accentGreen;
            this.panelNavProducts.Radius = 12;
            this.panelNavProducts.BorderSize = 0;
            this.panelNavProducts.Cursor = System.Windows.Forms.Cursors.Hand;

            this.labelNavProducts.Text = "     Produtos";
            this.labelNavProducts.Font = fontNavActive;
            this.labelNavProducts.ForeColor = textWhite;
            this.labelNavProducts.Location = new System.Drawing.Point(16, 14);
            this.labelNavProducts.AutoSize = true;
            this.panelNavProducts.Controls.Add(this.labelNavProducts);

            navY += navH + navGap;

            // Categories
            this.panelNavCategories.Location = new System.Drawing.Point(navX, navY);
            this.panelNavCategories.Size = new System.Drawing.Size(navW, navH);
            this.panelNavCategories.BackColor = System.Drawing.Color.Transparent;
            this.panelNavCategories.Radius = 12;
            this.panelNavCategories.BorderSize = 0;
            this.panelNavCategories.Cursor = System.Windows.Forms.Cursors.Hand;

            this.labelNavCategories.Text = "     Categorias";
            this.labelNavCategories.Font = fontNav;
            this.labelNavCategories.ForeColor = textGray;
            this.labelNavCategories.Location = new System.Drawing.Point(16, 14);
            this.labelNavCategories.AutoSize = true;
            this.panelNavCategories.Controls.Add(this.labelNavCategories);

            navY += navH + navGap;

            // Reports
            this.panelNavReports.Location = new System.Drawing.Point(navX, navY);
            this.panelNavReports.Size = new System.Drawing.Size(navW, navH);
            this.panelNavReports.BackColor = System.Drawing.Color.Transparent;
            this.panelNavReports.Radius = 12;
            this.panelNavReports.BorderSize = 0;
            this.panelNavReports.Cursor = System.Windows.Forms.Cursors.Hand;

            this.labelNavReports.Text = "     Relatorios";
            this.labelNavReports.Font = fontNav;
            this.labelNavReports.ForeColor = textGray;
            this.labelNavReports.Location = new System.Drawing.Point(16, 14);
            this.labelNavReports.AutoSize = true;
            this.panelNavReports.Controls.Add(this.labelNavReports);

            navY += navH + navGap;

            // Settings
            this.panelNavSettings.Location = new System.Drawing.Point(navX, navY);
            this.panelNavSettings.Size = new System.Drawing.Size(navW, navH);
            this.panelNavSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelNavSettings.Radius = 12;
            this.panelNavSettings.BorderSize = 0;
            this.panelNavSettings.Cursor = System.Windows.Forms.Cursors.Hand;

            this.labelNavSettings.Text = "     Configuracoes";
            this.labelNavSettings.Font = fontNav;
            this.labelNavSettings.ForeColor = textGray;
            this.labelNavSettings.Location = new System.Drawing.Point(16, 14);
            this.labelNavSettings.AutoSize = true;
            this.panelNavSettings.Controls.Add(this.labelNavSettings);

            // Version
            this.labelVersion.Text = "v2.0.0";
            this.labelVersion.Font = fontVersion;
            this.labelVersion.ForeColor = textMuted;
            this.labelVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.labelVersion.Location = new System.Drawing.Point(24, 680);
            this.labelVersion.AutoSize = true;

            this.panelSidebar.Controls.Add(this.labelLogo);
            this.panelSidebar.Controls.Add(this.labelLogoSub);
            this.panelSidebar.Controls.Add(this.panelNavDashboard);
            this.panelSidebar.Controls.Add(this.panelNavProducts);
            this.panelSidebar.Controls.Add(this.panelNavCategories);
            this.panelSidebar.Controls.Add(this.panelNavReports);
            this.panelSidebar.Controls.Add(this.panelNavSettings);
            this.panelSidebar.Controls.Add(this.labelVersion);

            // ===== MAIN PANEL =====
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.BackColor = bgDark;
            this.panelMain.Padding = new System.Windows.Forms.Padding(32, 28, 32, 28);

            // ===== HEADER =====
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.labelPageSubtitle = new System.Windows.Forms.Label();
            this.textSearch = new RoundedTextBox();
            this.btnAddProduct = new RoundedButton();

            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 90;
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;

            this.labelPageTitle.Text = "Gestao de Produtos";
            this.labelPageTitle.Font = fontTitle;
            this.labelPageTitle.ForeColor = textWhite;
            this.labelPageTitle.Location = new System.Drawing.Point(0, 8);
            this.labelPageTitle.AutoSize = true;

            this.labelPageSubtitle.Text = "Gerencie seu inventario de forma simples e eficiente";
            this.labelPageSubtitle.Font = fontSubtitle;
            this.labelPageSubtitle.ForeColor = textGray;
            this.labelPageSubtitle.Location = new System.Drawing.Point(2, 52);
            this.labelPageSubtitle.AutoSize = true;

            this.textSearch.Location = new System.Drawing.Point(500, 18);
            this.textSearch.Size = new System.Drawing.Size(280, 44);
            this.textSearch.BackColor = bgCard;
            this.textSearch.ForeColor = textWhite;
            this.textSearch.BorderColor = borderColor;
            this.textSearch.FocusBorderColor = accentGreen;
            this.textSearch.Radius = 12;
            this.textSearch.Text = "Buscar produtos...";
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);

            this.btnAddProduct.Location = new System.Drawing.Point(800, 18);
            this.btnAddProduct.Size = new System.Drawing.Size(150, 44);
            this.btnAddProduct.Text = "+ Novo Produto";
            this.btnAddProduct.Font = fontButton;
            this.btnAddProduct.ForeColor = textWhite;
            this.btnAddProduct.BackColor = accentGreen;
            this.btnAddProduct.HoverColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnAddProduct.Radius = 12;
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            this.panelHeader.Controls.Add(this.labelPageTitle);
            this.panelHeader.Controls.Add(this.labelPageSubtitle);
            this.panelHeader.Controls.Add(this.textSearch);
            this.panelHeader.Controls.Add(this.btnAddProduct);

            // ===== STATS CARDS =====
            this.panelStats = new System.Windows.Forms.Panel();
            this.cardTotal = new RoundedPanel();
            this.labelCardTotalIcon = new System.Windows.Forms.Label();
            this.labelCardTotalTitle = new System.Windows.Forms.Label();
            this.labelCardTotalValue = new System.Windows.Forms.Label();
            this.cardValue = new RoundedPanel();
            this.labelCardValueIcon = new System.Windows.Forms.Label();
            this.labelCardValueTitle = new System.Windows.Forms.Label();
            this.labelCardValueValue = new System.Windows.Forms.Label();
            this.cardLowStock = new RoundedPanel();
            this.labelCardLowStockIcon = new System.Windows.Forms.Label();
            this.labelCardLowStockTitle = new System.Windows.Forms.Label();
            this.labelCardLowStockValue = new System.Windows.Forms.Label();
            this.cardCategories = new RoundedPanel();
            this.labelCardCategoriesIcon = new System.Windows.Forms.Label();
            this.labelCardCategoriesTitle = new System.Windows.Forms.Label();
            this.labelCardCategoriesValue = new System.Windows.Forms.Label();

            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Height = 130;
            this.panelStats.BackColor = System.Drawing.Color.Transparent;
            this.panelStats.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);

            int cardW = 210;
            int cardH = 110;
            int cardGap = 20;

            // Card Total
            this.cardTotal.Location = new System.Drawing.Point(0, 0);
            this.cardTotal.Size = new System.Drawing.Size(cardW, cardH);
            this.cardTotal.BackColor = bgCard;
            this.cardTotal.Radius = 16;
            this.cardTotal.BorderColor = borderColor;
            this.cardTotal.BorderSize = 1;

            this.labelCardTotalIcon.Text = "[#]";
            this.labelCardTotalIcon.Font = fontCardIcon;
            this.labelCardTotalIcon.ForeColor = accentBlue;
            this.labelCardTotalIcon.Location = new System.Drawing.Point(18, 18);
            this.labelCardTotalIcon.AutoSize = true;

            this.labelCardTotalTitle.Text = "Total de Produtos";
            this.labelCardTotalTitle.Font = fontCardTitle;
            this.labelCardTotalTitle.ForeColor = textGray;
            this.labelCardTotalTitle.Location = new System.Drawing.Point(60, 22);
            this.labelCardTotalTitle.AutoSize = true;

            this.labelCardTotalValue.Text = "0";
            this.labelCardTotalValue.Font = fontCardValue;
            this.labelCardTotalValue.ForeColor = accentBlue;
            this.labelCardTotalValue.Location = new System.Drawing.Point(18, 55);
            this.labelCardTotalValue.AutoSize = true;

            this.cardTotal.Controls.Add(this.labelCardTotalIcon);
            this.cardTotal.Controls.Add(this.labelCardTotalTitle);
            this.cardTotal.Controls.Add(this.labelCardTotalValue);

            // Card Value
            this.cardValue.Location = new System.Drawing.Point(cardW + cardGap, 0);
            this.cardValue.Size = new System.Drawing.Size(cardW, cardH);
            this.cardValue.BackColor = bgCard;
            this.cardValue.Radius = 16;
            this.cardValue.BorderColor = borderColor;
            this.cardValue.BorderSize = 1;

            this.labelCardValueIcon.Text = "[E]";
            this.labelCardValueIcon.Font = fontCardIcon;
            this.labelCardValueIcon.ForeColor = accentGreen;
            this.labelCardValueIcon.Location = new System.Drawing.Point(18, 18);
            this.labelCardValueIcon.AutoSize = true;

            this.labelCardValueTitle.Text = "Valor em Estoque";
            this.labelCardValueTitle.Font = fontCardTitle;
            this.labelCardValueTitle.ForeColor = textGray;
            this.labelCardValueTitle.Location = new System.Drawing.Point(60, 22);
            this.labelCardValueTitle.AutoSize = true;

            this.labelCardValueValue.Text = "0,00 EUR";
            this.labelCardValueValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelCardValueValue.ForeColor = accentGreen;
            this.labelCardValueValue.Location = new System.Drawing.Point(18, 55);
            this.labelCardValueValue.AutoSize = true;

            this.cardValue.Controls.Add(this.labelCardValueIcon);
            this.cardValue.Controls.Add(this.labelCardValueTitle);
            this.cardValue.Controls.Add(this.labelCardValueValue);

            // Card Low Stock
            this.cardLowStock.Location = new System.Drawing.Point((cardW + cardGap) * 2, 0);
            this.cardLowStock.Size = new System.Drawing.Size(cardW, cardH);
            this.cardLowStock.BackColor = bgCard;
            this.cardLowStock.Radius = 16;
            this.cardLowStock.BorderColor = borderColor;
            this.cardLowStock.BorderSize = 1;

            this.labelCardLowStockIcon.Text = "[!]";
            this.labelCardLowStockIcon.Font = fontCardIcon;
            this.labelCardLowStockIcon.ForeColor = accentOrange;
            this.labelCardLowStockIcon.Location = new System.Drawing.Point(18, 18);
            this.labelCardLowStockIcon.AutoSize = true;

            this.labelCardLowStockTitle.Text = "Estoque Baixo";
            this.labelCardLowStockTitle.Font = fontCardTitle;
            this.labelCardLowStockTitle.ForeColor = textGray;
            this.labelCardLowStockTitle.Location = new System.Drawing.Point(60, 22);
            this.labelCardLowStockTitle.AutoSize = true;

            this.labelCardLowStockValue.Text = "0";
            this.labelCardLowStockValue.Font = fontCardValue;
            this.labelCardLowStockValue.ForeColor = accentOrange;
            this.labelCardLowStockValue.Location = new System.Drawing.Point(18, 55);
            this.labelCardLowStockValue.AutoSize = true;

            this.cardLowStock.Controls.Add(this.labelCardLowStockIcon);
            this.cardLowStock.Controls.Add(this.labelCardLowStockTitle);
            this.cardLowStock.Controls.Add(this.labelCardLowStockValue);

            // Card Categories
            this.cardCategories.Location = new System.Drawing.Point((cardW + cardGap) * 3, 0);
            this.cardCategories.Size = new System.Drawing.Size(cardW, cardH);
            this.cardCategories.BackColor = bgCard;
            this.cardCategories.Radius = 16;
            this.cardCategories.BorderColor = borderColor;
            this.cardCategories.BorderSize = 1;

            this.labelCardCategoriesIcon.Text = "[C]";
            this.labelCardCategoriesIcon.Font = fontCardIcon;
            this.labelCardCategoriesIcon.ForeColor = accentPurple;
            this.labelCardCategoriesIcon.Location = new System.Drawing.Point(18, 18);
            this.labelCardCategoriesIcon.AutoSize = true;

            this.labelCardCategoriesTitle.Text = "Categorias";
            this.labelCardCategoriesTitle.Font = fontCardTitle;
            this.labelCardCategoriesTitle.ForeColor = textGray;
            this.labelCardCategoriesTitle.Location = new System.Drawing.Point(60, 22);
            this.labelCardCategoriesTitle.AutoSize = true;

            this.labelCardCategoriesValue.Text = "0";
            this.labelCardCategoriesValue.Font = fontCardValue;
            this.labelCardCategoriesValue.ForeColor = accentPurple;
            this.labelCardCategoriesValue.Location = new System.Drawing.Point(18, 55);
            this.labelCardCategoriesValue.AutoSize = true;

            this.cardCategories.Controls.Add(this.labelCardCategoriesIcon);
            this.cardCategories.Controls.Add(this.labelCardCategoriesTitle);
            this.cardCategories.Controls.Add(this.labelCardCategoriesValue);

            this.panelStats.Controls.Add(this.cardTotal);
            this.panelStats.Controls.Add(this.cardValue);
            this.panelStats.Controls.Add(this.cardLowStock);
            this.panelStats.Controls.Add(this.cardCategories);

            // ===== FORM PANEL =====
            this.panelForm = new RoundedPanel();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new RoundedTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textDescription = new RoundedTextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textPrice = new RoundedTextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textQuantity = new RoundedTextBox();
            this.panelFormButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new RoundedButton();
            this.btnSave = new RoundedButton();
            this.btnDelete = new RoundedButton();
            this.btnClear = new RoundedButton();

            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Height = 190;
            this.panelForm.BackColor = bgCard;
            this.panelForm.Radius = 16;
            this.panelForm.BorderColor = borderColor;
            this.panelForm.BorderSize = 1;
            this.panelForm.Padding = new System.Windows.Forms.Padding(28);

            this.labelFormTitle.Text = "Adicionar / Editar Produto";
            this.labelFormTitle.Font = fontFormTitle;
            this.labelFormTitle.ForeColor = textWhite;
            this.labelFormTitle.Location = new System.Drawing.Point(28, 22);
            this.labelFormTitle.AutoSize = true;

            this.labelName.Text = "NOME *";
            this.labelName.Font = fontLabel;
            this.labelName.ForeColor = textGray;
            this.labelName.Location = new System.Drawing.Point(28, 60);
            this.labelName.AutoSize = true;

            this.textName.Location = new System.Drawing.Point(28, 82);
            this.textName.Size = new System.Drawing.Size(180, 44);
            this.textName.BackColor = bgInput;
            this.textName.ForeColor = textWhite;
            this.textName.BorderColor = borderColor;
            this.textName.FocusBorderColor = accentGreen;
            this.textName.Radius = 10;

            this.labelDescription.Text = "DESCRICAO";
            this.labelDescription.Font = fontLabel;
            this.labelDescription.ForeColor = textGray;
            this.labelDescription.Location = new System.Drawing.Point(228, 60);
            this.labelDescription.AutoSize = true;

            this.textDescription.Location = new System.Drawing.Point(228, 82);
            this.textDescription.Size = new System.Drawing.Size(240, 44);
            this.textDescription.BackColor = bgInput;
            this.textDescription.ForeColor = textWhite;
            this.textDescription.BorderColor = borderColor;
            this.textDescription.FocusBorderColor = accentGreen;
            this.textDescription.Radius = 10;

            this.labelPrice.Text = "PRECO (EUR)";
            this.labelPrice.Font = fontLabel;
            this.labelPrice.ForeColor = textGray;
            this.labelPrice.Location = new System.Drawing.Point(488, 60);
            this.labelPrice.AutoSize = true;

            this.textPrice.Location = new System.Drawing.Point(488, 82);
            this.textPrice.Size = new System.Drawing.Size(130, 44);
            this.textPrice.BackColor = bgInput;
            this.textPrice.ForeColor = textWhite;
            this.textPrice.BorderColor = borderColor;
            this.textPrice.FocusBorderColor = accentGreen;
            this.textPrice.Radius = 10;
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.labelQuantity.Text = "QTD";
            this.labelQuantity.Font = fontLabel;
            this.labelQuantity.ForeColor = textGray;
            this.labelQuantity.Location = new System.Drawing.Point(638, 60);
            this.labelQuantity.AutoSize = true;

            this.textQuantity.Location = new System.Drawing.Point(638, 82);
            this.textQuantity.Size = new System.Drawing.Size(90, 44);
            this.textQuantity.BackColor = bgInput;
            this.textQuantity.ForeColor = textWhite;
            this.textQuantity.BorderColor = borderColor;
            this.textQuantity.FocusBorderColor = accentGreen;
            this.textQuantity.Radius = 10;
            this.textQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.panelFormButtons.Location = new System.Drawing.Point(28, 138);
            this.panelFormButtons.Size = new System.Drawing.Size(700, 48);
            this.panelFormButtons.BackColor = System.Drawing.Color.Transparent;

            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Size = new System.Drawing.Size(130, 44);
            this.btnAdd.Text = "+ Adicionar";
            this.btnAdd.Font = fontButton;
            this.btnAdd.ForeColor = textWhite;
            this.btnAdd.BackColor = accentGreen;
            this.btnAdd.HoverColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnAdd.Radius = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.Location = new System.Drawing.Point(145, 0);
            this.btnSave.Size = new System.Drawing.Size(115, 44);
            this.btnSave.Text = "Salvar";
            this.btnSave.Font = fontButton;
            this.btnSave.ForeColor = textWhite;
            this.btnSave.BackColor = accentBlue;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSave.Radius = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDelete.Location = new System.Drawing.Point(275, 0);
            this.btnDelete.Size = new System.Drawing.Size(115, 44);
            this.btnDelete.Text = "Excluir";
            this.btnDelete.Font = fontButton;
            this.btnDelete.ForeColor = textWhite;
            this.btnDelete.BackColor = accentRed;
            this.btnDelete.HoverColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDelete.Radius = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Location = new System.Drawing.Point(405, 0);
            this.btnClear.Size = new System.Drawing.Size(115, 44);
            this.btnClear.Text = "Limpar";
            this.btnClear.Font = fontButton;
            this.btnClear.ForeColor = textWhite;
            this.btnClear.BackColor = bgCardLight;
            this.btnClear.HoverColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnClear.Radius = 10;
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

            // ===== GRID PANEL =====
            this.panelGrid = new RoundedPanel();
            this.labelGridTitle = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();

            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.BackColor = bgCard;
            this.panelGrid.Radius = 16;
            this.panelGrid.BorderColor = borderColor;
            this.panelGrid.BorderSize = 1;
            this.panelGrid.Padding = new System.Windows.Forms.Padding(20, 18, 20, 20);

            this.labelGridTitle.Text = "Lista de Produtos";
            this.labelGridTitle.Font = fontFormTitle;
            this.labelGridTitle.ForeColor = textWhite;
            this.labelGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGridTitle.Padding = new System.Windows.Forms.Padding(8, 4, 8, 12);
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
            this.dataGridViewProducts.BackgroundColor = bgCard;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProducts.GridColor = borderColor;
            this.dataGridViewProducts.DefaultCellStyle.BackColor = bgCard;
            this.dataGridViewProducts.DefaultCellStyle.ForeColor = textWhite;
            this.dataGridViewProducts.DefaultCellStyle.SelectionBackColor = accentGreen;
            this.dataGridViewProducts.DefaultCellStyle.SelectionForeColor = textWhite;
            this.dataGridViewProducts.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = textGray;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.ColumnHeadersHeight = 55;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProducts.RowTemplate.Height = 55;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);

            this.panelGrid.Controls.Add(this.dataGridViewProducts);
            this.panelGrid.Controls.Add(this.labelGridTitle);

            // ===== SPACERS =====
            var spacer1 = new System.Windows.Forms.Panel();
            spacer1.Height = 20;
            spacer1.Dock = System.Windows.Forms.DockStyle.Top;
            spacer1.BackColor = System.Drawing.Color.Transparent;

            var spacer2 = new System.Windows.Forms.Panel();
            spacer2.Height = 20;
            spacer2.Dock = System.Windows.Forms.DockStyle.Top;
            spacer2.BackColor = System.Drawing.Color.Transparent;

            // ===== ASSEMBLY =====
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(spacer2);
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(spacer1);
            this.panelMain.Controls.Add(this.panelStats);
            this.panelMain.Controls.Add(this.panelHeader);

            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();

            // ===== FORM SETTINGS =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Text = "DevNooTools - Sistema de Gestao de Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackColor = bgDark;

            this.ResumeLayout(false);
        }

        #endregion
    }
}
