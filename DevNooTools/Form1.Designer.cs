namespace DevNooTools
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Sidebar
        private RoundedPanel panelSidebar;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelLogoSub;
        private NavPanel panelNavDashboard;
        private System.Windows.Forms.Label lblNavDashboard;
        private NavPanel panelNavProducts;
        private System.Windows.Forms.Label lblNavProducts;
        private NavPanel panelNavCategories;
        private System.Windows.Forms.Label lblNavCategories;
        private NavPanel panelNavReports;
        private System.Windows.Forms.Label lblNavReports;
        private NavPanel panelNavSettings;
        private System.Windows.Forms.Label lblNavSettings;
        private System.Windows.Forms.Label labelVersion;

        // Main
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private RoundedTextBox textSearch;
        private RoundedButton btnExport;

        // Cards
        private System.Windows.Forms.Panel panelCards;
        private GradientCard cardTotal;
        private System.Windows.Forms.Label labelCardTotalIcon;
        private System.Windows.Forms.Label labelCardTotalTitle;
        private System.Windows.Forms.Label labelCardTotalValue;
        private GradientCard cardValue;
        private System.Windows.Forms.Label labelCardValueIcon;
        private System.Windows.Forms.Label labelCardValueTitle;
        private System.Windows.Forms.Label labelCardValueValue;
        private GradientCard cardLowStock;
        private System.Windows.Forms.Label labelCardLowStockIcon;
        private System.Windows.Forms.Label labelCardLowStockTitle;
        private System.Windows.Forms.Label labelCardLowStockValue;
        private GradientCard cardCategories;
        private System.Windows.Forms.Label labelCardCategoriesIcon;
        private System.Windows.Forms.Label labelCardCategoriesTitle;
        private System.Windows.Forms.Label labelCardCategoriesValue;

        // Form
        private RoundedPanel panelForm;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Label lblName;
        private RoundedTextBox textName;
        private System.Windows.Forms.Label lblDescription;
        private RoundedTextBox textDescription;
        private System.Windows.Forms.Label lblPrice;
        private RoundedTextBox textPrice;
        private System.Windows.Forms.Label lblQuantity;
        private RoundedTextBox textQuantity;
        private System.Windows.Forms.Panel panelButtons;
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
            
            // Colors - Modern Dark Theme with Purple/Indigo accents
            System.Drawing.Color bgDark = System.Drawing.Color.FromArgb(18, 18, 24);
            System.Drawing.Color bgSidebar = System.Drawing.Color.FromArgb(22, 22, 30);
            System.Drawing.Color bgCard = System.Drawing.Color.FromArgb(28, 28, 38);
            System.Drawing.Color bgInput = System.Drawing.Color.FromArgb(35, 35, 45);
            System.Drawing.Color textPrimary = System.Drawing.Color.FromArgb(245, 245, 250);
            System.Drawing.Color textSecondary = System.Drawing.Color.FromArgb(160, 160, 180);
            System.Drawing.Color textMuted = System.Drawing.Color.FromArgb(120, 120, 140);
            System.Drawing.Color accentPrimary = System.Drawing.Color.FromArgb(100, 100, 255);
            System.Drawing.Color accentSuccess = System.Drawing.Color.FromArgb(80, 200, 120);
            System.Drawing.Color accentDanger = System.Drawing.Color.FromArgb(255, 90, 90);
            System.Drawing.Color accentWarning = System.Drawing.Color.FromArgb(255, 180, 80);
            System.Drawing.Color accentPurple = System.Drawing.Color.FromArgb(160, 100, 255);
            System.Drawing.Color borderColor = System.Drawing.Color.FromArgb(50, 50, 65);

            this.panelSidebar = new RoundedPanel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelLogoSub = new System.Windows.Forms.Label();
            this.panelNavDashboard = new NavPanel();
            this.lblNavDashboard = new System.Windows.Forms.Label();
            this.panelNavProducts = new NavPanel();
            this.lblNavProducts = new System.Windows.Forms.Label();
            this.panelNavCategories = new NavPanel();
            this.lblNavCategories = new System.Windows.Forms.Label();
            this.panelNavReports = new NavPanel();
            this.lblNavReports = new System.Windows.Forms.Label();
            this.panelNavSettings = new NavPanel();
            this.lblNavSettings = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.textSearch = new RoundedTextBox();
            this.btnExport = new RoundedButton();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardTotal = new GradientCard();
            this.labelCardTotalIcon = new System.Windows.Forms.Label();
            this.labelCardTotalTitle = new System.Windows.Forms.Label();
            this.labelCardTotalValue = new System.Windows.Forms.Label();
            this.cardValue = new GradientCard();
            this.labelCardValueIcon = new System.Windows.Forms.Label();
            this.labelCardValueTitle = new System.Windows.Forms.Label();
            this.labelCardValueValue = new System.Windows.Forms.Label();
            this.cardLowStock = new GradientCard();
            this.labelCardLowStockIcon = new System.Windows.Forms.Label();
            this.labelCardLowStockTitle = new System.Windows.Forms.Label();
            this.labelCardLowStockValue = new System.Windows.Forms.Label();
            this.cardCategories = new GradientCard();
            this.labelCardCategoriesIcon = new System.Windows.Forms.Label();
            this.labelCardCategoriesTitle = new System.Windows.Forms.Label();
            this.labelCardCategoriesValue = new System.Windows.Forms.Label();
            this.panelForm = new RoundedPanel();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.textName = new RoundedTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textDescription = new RoundedTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textPrice = new RoundedTextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textQuantity = new RoundedTextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new RoundedButton();
            this.btnSave = new RoundedButton();
            this.btnDelete = new RoundedButton();
            this.btnClear = new RoundedButton();
            this.panelGrid = new RoundedPanel();
            this.labelGridTitle = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.bindingSourceProducts = new System.Windows.Forms.BindingSource(this.components);
            this.panelSidebar.SuspendLayout();
            this.panelNavDashboard.SuspendLayout();
            this.panelNavProducts.SuspendLayout();
            this.panelNavCategories.SuspendLayout();
            this.panelNavReports.SuspendLayout();
            this.panelNavSettings.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.cardValue.SuspendLayout();
            this.cardLowStock.SuspendLayout();
            this.cardCategories.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = bgSidebar;
            this.panelSidebar.Radius = 0;
            this.panelSidebar.Controls.Add(this.labelVersion);
            this.panelSidebar.Controls.Add(this.panelNavSettings);
            this.panelSidebar.Controls.Add(this.panelNavReports);
            this.panelSidebar.Controls.Add(this.panelNavCategories);
            this.panelSidebar.Controls.Add(this.panelNavProducts);
            this.panelSidebar.Controls.Add(this.panelNavDashboard);
            this.panelSidebar.Controls.Add(this.labelLogoSub);
            this.panelSidebar.Controls.Add(this.labelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(16);
            this.panelSidebar.Size = new System.Drawing.Size(220, 720);
            this.panelSidebar.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelLogo.ForeColor = textPrimary;
            this.labelLogo.Location = new System.Drawing.Point(20, 28);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(160, 32);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "DevNooTools";
            // 
            // labelLogoSub
            // 
            this.labelLogoSub.AutoSize = true;
            this.labelLogoSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelLogoSub.ForeColor = textMuted;
            this.labelLogoSub.Location = new System.Drawing.Point(22, 62);
            this.labelLogoSub.Name = "labelLogoSub";
            this.labelLogoSub.Size = new System.Drawing.Size(100, 13);
            this.labelLogoSub.TabIndex = 1;
            this.labelLogoSub.Text = "Gestao de Produtos";
            // 
            // panelNavDashboard
            // 
            this.panelNavDashboard.BackColor = System.Drawing.Color.Transparent;
            this.panelNavDashboard.Controls.Add(this.lblNavDashboard);
            this.panelNavDashboard.IsSelected = false;
            this.panelNavDashboard.Location = new System.Drawing.Point(12, 110);
            this.panelNavDashboard.Name = "panelNavDashboard";
            this.panelNavDashboard.Radius = 10;
            this.panelNavDashboard.Size = new System.Drawing.Size(196, 42);
            this.panelNavDashboard.TabIndex = 2;
            // 
            // lblNavDashboard
            // 
            this.lblNavDashboard.AutoSize = true;
            this.lblNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavDashboard.ForeColor = textSecondary;
            this.lblNavDashboard.Location = new System.Drawing.Point(16, 12);
            this.lblNavDashboard.Name = "lblNavDashboard";
            this.lblNavDashboard.Size = new System.Drawing.Size(70, 17);
            this.lblNavDashboard.TabIndex = 0;
            this.lblNavDashboard.Text = "Dashboard";
            // 
            // panelNavProducts
            // 
            this.panelNavProducts.BackColor = System.Drawing.Color.Transparent;
            this.panelNavProducts.Controls.Add(this.lblNavProducts);
            this.panelNavProducts.IsSelected = true;
            this.panelNavProducts.SelectedColor = accentPrimary;
            this.panelNavProducts.Location = new System.Drawing.Point(12, 158);
            this.panelNavProducts.Name = "panelNavProducts";
            this.panelNavProducts.Radius = 10;
            this.panelNavProducts.Size = new System.Drawing.Size(196, 42);
            this.panelNavProducts.TabIndex = 3;
            // 
            // lblNavProducts
            // 
            this.lblNavProducts.AutoSize = true;
            this.lblNavProducts.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNavProducts.ForeColor = textPrimary;
            this.lblNavProducts.Location = new System.Drawing.Point(16, 12);
            this.lblNavProducts.Name = "lblNavProducts";
            this.lblNavProducts.Size = new System.Drawing.Size(60, 17);
            this.lblNavProducts.TabIndex = 0;
            this.lblNavProducts.Text = "Produtos";
            // 
            // panelNavCategories
            // 
            this.panelNavCategories.BackColor = System.Drawing.Color.Transparent;
            this.panelNavCategories.Controls.Add(this.lblNavCategories);
            this.panelNavCategories.IsSelected = false;
            this.panelNavCategories.Location = new System.Drawing.Point(12, 206);
            this.panelNavCategories.Name = "panelNavCategories";
            this.panelNavCategories.Radius = 10;
            this.panelNavCategories.Size = new System.Drawing.Size(196, 42);
            this.panelNavCategories.TabIndex = 4;
            // 
            // lblNavCategories
            // 
            this.lblNavCategories.AutoSize = true;
            this.lblNavCategories.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavCategories.ForeColor = textSecondary;
            this.lblNavCategories.Location = new System.Drawing.Point(16, 12);
            this.lblNavCategories.Name = "lblNavCategories";
            this.lblNavCategories.Size = new System.Drawing.Size(68, 17);
            this.lblNavCategories.TabIndex = 0;
            this.lblNavCategories.Text = "Categorias";
            // 
            // panelNavReports
            // 
            this.panelNavReports.BackColor = System.Drawing.Color.Transparent;
            this.panelNavReports.Controls.Add(this.lblNavReports);
            this.panelNavReports.IsSelected = false;
            this.panelNavReports.Location = new System.Drawing.Point(12, 254);
            this.panelNavReports.Name = "panelNavReports";
            this.panelNavReports.Radius = 10;
            this.panelNavReports.Size = new System.Drawing.Size(196, 42);
            this.panelNavReports.TabIndex = 5;
            // 
            // lblNavReports
            // 
            this.lblNavReports.AutoSize = true;
            this.lblNavReports.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavReports.ForeColor = textSecondary;
            this.lblNavReports.Location = new System.Drawing.Point(16, 12);
            this.lblNavReports.Name = "lblNavReports";
            this.lblNavReports.Size = new System.Drawing.Size(63, 17);
            this.lblNavReports.TabIndex = 0;
            this.lblNavReports.Text = "Relatorios";
            // 
            // panelNavSettings
            // 
            this.panelNavSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelNavSettings.Controls.Add(this.lblNavSettings);
            this.panelNavSettings.IsSelected = false;
            this.panelNavSettings.Location = new System.Drawing.Point(12, 302);
            this.panelNavSettings.Name = "panelNavSettings";
            this.panelNavSettings.Radius = 10;
            this.panelNavSettings.Size = new System.Drawing.Size(196, 42);
            this.panelNavSettings.TabIndex = 6;
            // 
            // lblNavSettings
            // 
            this.lblNavSettings.AutoSize = true;
            this.lblNavSettings.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavSettings.ForeColor = textSecondary;
            this.lblNavSettings.Location = new System.Drawing.Point(16, 12);
            this.lblNavSettings.Name = "lblNavSettings";
            this.lblNavSettings.Size = new System.Drawing.Size(86, 17);
            this.lblNavSettings.TabIndex = 0;
            this.lblNavSettings.Text = "Configuracoes";
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelVersion.ForeColor = textMuted;
            this.labelVersion.Location = new System.Drawing.Point(20, 690);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(55, 13);
            this.labelVersion.TabIndex = 7;
            this.labelVersion.Text = "v1.0.0";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = bgDark;
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.panelCards);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(28, 24, 28, 24);
            this.panelMain.Size = new System.Drawing.Size(940, 720);
            this.panelMain.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.btnExport);
            this.panelHeader.Controls.Add(this.textSearch);
            this.panelHeader.Controls.Add(this.labelSubtitle);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(28, 24);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(884, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = textPrimary;
            this.labelTitle.Location = new System.Drawing.Point(0, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(140, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Produtos";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSubtitle.ForeColor = textMuted;
            this.labelSubtitle.Location = new System.Drawing.Point(4, 50);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(185, 15);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Gerencie seu inventario facilmente";
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.BackColor = bgInput;
            this.textSearch.BorderColor = borderColor;
            this.textSearch.FocusBorderColor = accentPrimary;
            this.textSearch.ForeColor = textSecondary;
            this.textSearch.Location = new System.Drawing.Point(480, 18);
            this.textSearch.Name = "textSearch";
            this.textSearch.Radius = 10;
            this.textSearch.Size = new System.Drawing.Size(260, 40);
            this.textSearch.TabIndex = 2;
            this.textSearch.Text = "Buscar produtos...";
            this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
            this.textSearch.Leave += new System.EventHandler(this.textSearch_Leave);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = accentPurple;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(760, 18);
            this.btnExport.Name = "btnExport";
            this.btnExport.Radius = 10;
            this.btnExport.Size = new System.Drawing.Size(120, 40);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exportar";
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Controls.Add(this.cardCategories);
            this.panelCards.Controls.Add(this.cardLowStock);
            this.panelCards.Controls.Add(this.cardValue);
            this.panelCards.Controls.Add(this.cardTotal);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCards.Location = new System.Drawing.Point(28, 104);
            this.panelCards.Name = "panelCards";
            this.panelCards.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.panelCards.Size = new System.Drawing.Size(884, 115);
            this.panelCards.TabIndex = 1;
            // 
            // cardTotal
            // 
            this.cardTotal.AccentColor = accentPrimary;
            this.cardTotal.BorderColor = borderColor;
            this.cardTotal.Controls.Add(this.labelCardTotalValue);
            this.cardTotal.Controls.Add(this.labelCardTotalTitle);
            this.cardTotal.Controls.Add(this.labelCardTotalIcon);
            this.cardTotal.GradientStartColor = System.Drawing.Color.FromArgb(35, 35, 50);
            this.cardTotal.GradientEndColor = bgCard;
            this.cardTotal.Location = new System.Drawing.Point(0, 8);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Radius = 14;
            this.cardTotal.Size = new System.Drawing.Size(205, 95);
            this.cardTotal.TabIndex = 0;
            // 
            // labelCardTotalIcon
            // 
            this.labelCardTotalIcon.AutoSize = true;
            this.labelCardTotalIcon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelCardTotalIcon.ForeColor = accentPrimary;
            this.labelCardTotalIcon.Location = new System.Drawing.Point(16, 14);
            this.labelCardTotalIcon.Name = "labelCardTotalIcon";
            this.labelCardTotalIcon.Size = new System.Drawing.Size(30, 25);
            this.labelCardTotalIcon.TabIndex = 0;
            this.labelCardTotalIcon.Text = "#";
            // 
            // labelCardTotalTitle
            // 
            this.labelCardTotalTitle.AutoSize = true;
            this.labelCardTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelCardTotalTitle.ForeColor = textSecondary;
            this.labelCardTotalTitle.Location = new System.Drawing.Point(50, 20);
            this.labelCardTotalTitle.Name = "labelCardTotalTitle";
            this.labelCardTotalTitle.Size = new System.Drawing.Size(82, 15);
            this.labelCardTotalTitle.TabIndex = 1;
            this.labelCardTotalTitle.Text = "Total Produtos";
            // 
            // labelCardTotalValue
            // 
            this.labelCardTotalValue.AutoSize = true;
            this.labelCardTotalValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelCardTotalValue.ForeColor = textPrimary;
            this.labelCardTotalValue.Location = new System.Drawing.Point(16, 46);
            this.labelCardTotalValue.Name = "labelCardTotalValue";
            this.labelCardTotalValue.Size = new System.Drawing.Size(36, 45);
            this.labelCardTotalValue.TabIndex = 2;
            this.labelCardTotalValue.Text = "0";
            // 
            // cardValue
            // 
            this.cardValue.AccentColor = accentSuccess;
            this.cardValue.BorderColor = borderColor;
            this.cardValue.Controls.Add(this.labelCardValueValue);
            this.cardValue.Controls.Add(this.labelCardValueTitle);
            this.cardValue.Controls.Add(this.labelCardValueIcon);
            this.cardValue.GradientStartColor = System.Drawing.Color.FromArgb(35, 35, 50);
            this.cardValue.GradientEndColor = bgCard;
            this.cardValue.Location = new System.Drawing.Point(225, 8);
            this.cardValue.Name = "cardValue";
            this.cardValue.Radius = 14;
            this.cardValue.Size = new System.Drawing.Size(205, 95);
            this.cardValue.TabIndex = 1;
            // 
            // labelCardValueIcon
            // 
            this.labelCardValueIcon.AutoSize = true;
            this.labelCardValueIcon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelCardValueIcon.ForeColor = accentSuccess;
            this.labelCardValueIcon.Location = new System.Drawing.Point(16, 14);
            this.labelCardValueIcon.Name = "labelCardValueIcon";
            this.labelCardValueIcon.Size = new System.Drawing.Size(24, 25);
            this.labelCardValueIcon.TabIndex = 0;
            this.labelCardValueIcon.Text = "$";
            // 
            // labelCardValueTitle
            // 
            this.labelCardValueTitle.AutoSize = true;
            this.labelCardValueTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelCardValueTitle.ForeColor = textSecondary;
            this.labelCardValueTitle.Location = new System.Drawing.Point(50, 20);
            this.labelCardValueTitle.Name = "labelCardValueTitle";
            this.labelCardValueTitle.Size = new System.Drawing.Size(78, 15);
            this.labelCardValueTitle.TabIndex = 1;
            this.labelCardValueTitle.Text = "Valor Estoque";
            // 
            // labelCardValueValue
            // 
            this.labelCardValueValue.AutoSize = true;
            this.labelCardValueValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelCardValueValue.ForeColor = textPrimary;
            this.labelCardValueValue.Location = new System.Drawing.Point(16, 52);
            this.labelCardValueValue.Name = "labelCardValueValue";
            this.labelCardValueValue.Size = new System.Drawing.Size(75, 30);
            this.labelCardValueValue.TabIndex = 2;
            this.labelCardValueValue.Text = "0,00 €";
            // 
            // cardLowStock
            // 
            this.cardLowStock.AccentColor = accentWarning;
            this.cardLowStock.BorderColor = borderColor;
            this.cardLowStock.Controls.Add(this.labelCardLowStockValue);
            this.cardLowStock.Controls.Add(this.labelCardLowStockTitle);
            this.cardLowStock.Controls.Add(this.labelCardLowStockIcon);
            this.cardLowStock.GradientStartColor = System.Drawing.Color.FromArgb(35, 35, 50);
            this.cardLowStock.GradientEndColor = bgCard;
            this.cardLowStock.Location = new System.Drawing.Point(450, 8);
            this.cardLowStock.Name = "cardLowStock";
            this.cardLowStock.Radius = 14;
            this.cardLowStock.Size = new System.Drawing.Size(205, 95);
            this.cardLowStock.TabIndex = 2;
            // 
            // labelCardLowStockIcon
            // 
            this.labelCardLowStockIcon.AutoSize = true;
            this.labelCardLowStockIcon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelCardLowStockIcon.ForeColor = accentWarning;
            this.labelCardLowStockIcon.Location = new System.Drawing.Point(16, 14);
            this.labelCardLowStockIcon.Name = "labelCardLowStockIcon";
            this.labelCardLowStockIcon.Size = new System.Drawing.Size(22, 25);
            this.labelCardLowStockIcon.TabIndex = 0;
            this.labelCardLowStockIcon.Text = "!";
            // 
            // labelCardLowStockTitle
            // 
            this.labelCardLowStockTitle.AutoSize = true;
            this.labelCardLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelCardLowStockTitle.ForeColor = textSecondary;
            this.labelCardLowStockTitle.Location = new System.Drawing.Point(50, 20);
            this.labelCardLowStockTitle.Name = "labelCardLowStockTitle";
            this.labelCardLowStockTitle.Size = new System.Drawing.Size(79, 15);
            this.labelCardLowStockTitle.TabIndex = 1;
            this.labelCardLowStockTitle.Text = "Estoque Baixo";
            // 
            // labelCardLowStockValue
            // 
            this.labelCardLowStockValue.AutoSize = true;
            this.labelCardLowStockValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelCardLowStockValue.ForeColor = textPrimary;
            this.labelCardLowStockValue.Location = new System.Drawing.Point(16, 46);
            this.labelCardLowStockValue.Name = "labelCardLowStockValue";
            this.labelCardLowStockValue.Size = new System.Drawing.Size(36, 45);
            this.labelCardLowStockValue.TabIndex = 2;
            this.labelCardLowStockValue.Text = "0";
            // 
            // cardCategories
            // 
            this.cardCategories.AccentColor = accentPurple;
            this.cardCategories.BorderColor = borderColor;
            this.cardCategories.Controls.Add(this.labelCardCategoriesValue);
            this.cardCategories.Controls.Add(this.labelCardCategoriesTitle);
            this.cardCategories.Controls.Add(this.labelCardCategoriesIcon);
            this.cardCategories.GradientStartColor = System.Drawing.Color.FromArgb(35, 35, 50);
            this.cardCategories.GradientEndColor = bgCard;
            this.cardCategories.Location = new System.Drawing.Point(675, 8);
            this.cardCategories.Name = "cardCategories";
            this.cardCategories.Radius = 14;
            this.cardCategories.Size = new System.Drawing.Size(205, 95);
            this.cardCategories.TabIndex = 3;
            // 
            // labelCardCategoriesIcon
            // 
            this.labelCardCategoriesIcon.AutoSize = true;
            this.labelCardCategoriesIcon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelCardCategoriesIcon.ForeColor = accentPurple;
            this.labelCardCategoriesIcon.Location = new System.Drawing.Point(16, 14);
            this.labelCardCategoriesIcon.Name = "labelCardCategoriesIcon";
            this.labelCardCategoriesIcon.Size = new System.Drawing.Size(26, 25);
            this.labelCardCategoriesIcon.TabIndex = 0;
            this.labelCardCategoriesIcon.Text = "@";
            // 
            // labelCardCategoriesTitle
            // 
            this.labelCardCategoriesTitle.AutoSize = true;
            this.labelCardCategoriesTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelCardCategoriesTitle.ForeColor = textSecondary;
            this.labelCardCategoriesTitle.Location = new System.Drawing.Point(50, 20);
            this.labelCardCategoriesTitle.Name = "labelCardCategoriesTitle";
            this.labelCardCategoriesTitle.Size = new System.Drawing.Size(63, 15);
            this.labelCardCategoriesTitle.TabIndex = 1;
            this.labelCardCategoriesTitle.Text = "Categorias";
            // 
            // labelCardCategoriesValue
            // 
            this.labelCardCategoriesValue.AutoSize = true;
            this.labelCardCategoriesValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelCardCategoriesValue.ForeColor = textPrimary;
            this.labelCardCategoriesValue.Location = new System.Drawing.Point(16, 46);
            this.labelCardCategoriesValue.Name = "labelCardCategoriesValue";
            this.labelCardCategoriesValue.Size = new System.Drawing.Size(36, 45);
            this.labelCardCategoriesValue.TabIndex = 2;
            this.labelCardCategoriesValue.Text = "0";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = bgCard;
            this.panelForm.BorderColor = borderColor;
            this.panelForm.BorderSize = 1;
            this.panelForm.Controls.Add(this.panelButtons);
            this.panelForm.Controls.Add(this.textQuantity);
            this.panelForm.Controls.Add(this.lblQuantity);
            this.panelForm.Controls.Add(this.textPrice);
            this.panelForm.Controls.Add(this.lblPrice);
            this.panelForm.Controls.Add(this.textDescription);
            this.panelForm.Controls.Add(this.lblDescription);
            this.panelForm.Controls.Add(this.textName);
            this.panelForm.Controls.Add(this.lblName);
            this.panelForm.Controls.Add(this.labelFormTitle);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Location = new System.Drawing.Point(28, 219);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(24);
            this.panelForm.Radius = 16;
            this.panelForm.Size = new System.Drawing.Size(884, 185);
            this.panelForm.TabIndex = 2;
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelFormTitle.ForeColor = textPrimary;
            this.labelFormTitle.Location = new System.Drawing.Point(24, 18);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(195, 21);
            this.labelFormTitle.TabIndex = 0;
            this.labelFormTitle.Text = "Adicionar / Editar Produto";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = textSecondary;
            this.lblName.Location = new System.Drawing.Point(24, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NOME";
            // 
            // textName
            // 
            this.textName.BackColor = bgInput;
            this.textName.BorderColor = borderColor;
            this.textName.FocusBorderColor = accentPrimary;
            this.textName.ForeColor = textPrimary;
            this.textName.Location = new System.Drawing.Point(24, 70);
            this.textName.Name = "textName";
            this.textName.Radius = 10;
            this.textName.Size = new System.Drawing.Size(180, 38);
            this.textName.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = textSecondary;
            this.lblDescription.Location = new System.Drawing.Point(220, 52);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(64, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "DESCRICAO";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = bgInput;
            this.textDescription.BorderColor = borderColor;
            this.textDescription.FocusBorderColor = accentPrimary;
            this.textDescription.ForeColor = textPrimary;
            this.textDescription.Location = new System.Drawing.Point(220, 70);
            this.textDescription.Name = "textDescription";
            this.textDescription.Radius = 10;
            this.textDescription.Size = new System.Drawing.Size(260, 38);
            this.textDescription.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = textSecondary;
            this.lblPrice.Location = new System.Drawing.Point(496, 52);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "PRECO (EUR)";
            // 
            // textPrice
            // 
            this.textPrice.BackColor = bgInput;
            this.textPrice.BorderColor = borderColor;
            this.textPrice.FocusBorderColor = accentSuccess;
            this.textPrice.ForeColor = textPrimary;
            this.textPrice.Location = new System.Drawing.Point(496, 70);
            this.textPrice.Name = "textPrice";
            this.textPrice.Radius = 10;
            this.textPrice.Size = new System.Drawing.Size(130, 38);
            this.textPrice.TabIndex = 6;
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = textSecondary;
            this.lblQuantity.Location = new System.Drawing.Point(642, 52);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(27, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "QTD";
            // 
            // textQuantity
            // 
            this.textQuantity.BackColor = bgInput;
            this.textQuantity.BorderColor = borderColor;
            this.textQuantity.FocusBorderColor = accentPrimary;
            this.textQuantity.ForeColor = textPrimary;
            this.textQuantity.Location = new System.Drawing.Point(642, 70);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Radius = 10;
            this.textQuantity.Size = new System.Drawing.Size(90, 38);
            this.textQuantity.TabIndex = 8;
            this.textQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Location = new System.Drawing.Point(24, 125);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(710, 46);
            this.panelButtons.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = accentSuccess;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+ Adicionar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = accentPrimary;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(145, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = accentDanger;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(270, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 10;
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(395, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Radius = 10;
            this.btnClear.Size = new System.Drawing.Size(110, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = bgCard;
            this.panelGrid.BorderColor = borderColor;
            this.panelGrid.BorderSize = 1;
            this.panelGrid.Controls.Add(this.dataGridViewProducts);
            this.panelGrid.Controls.Add(this.labelGridTitle);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(28, 404);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(20, 16, 20, 20);
            this.panelGrid.Radius = 16;
            this.panelGrid.Size = new System.Drawing.Size(884, 292);
            this.panelGrid.TabIndex = 3;
            // 
            // labelGridTitle
            // 
            this.labelGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelGridTitle.ForeColor = textPrimary;
            this.labelGridTitle.Location = new System.Drawing.Point(20, 16);
            this.labelGridTitle.Name = "labelGridTitle";
            this.labelGridTitle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.labelGridTitle.Size = new System.Drawing.Size(844, 38);
            this.labelGridTitle.TabIndex = 0;
            this.labelGridTitle.Text = "Lista de Produtos";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = bgCard;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProducts.ColumnHeadersHeight = 45;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProducts.DataSource = this.bindingSourceProducts;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.GridColor = borderColor;
            this.dataGridViewProducts.Location = new System.Drawing.Point(20, 54);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowTemplate.Height = 45;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(844, 218);
            this.dataGridViewProducts.TabIndex = 1;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = bgDark;
            this.ClientSize = new System.Drawing.Size(1160, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevNooTools - Gestao de Produtos";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelNavDashboard.ResumeLayout(false);
            this.panelNavDashboard.PerformLayout();
            this.panelNavProducts.ResumeLayout(false);
            this.panelNavProducts.PerformLayout();
            this.panelNavCategories.ResumeLayout(false);
            this.panelNavCategories.PerformLayout();
            this.panelNavReports.ResumeLayout(false);
            this.panelNavReports.PerformLayout();
            this.panelNavSettings.ResumeLayout(false);
            this.panelNavSettings.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.cardValue.ResumeLayout(false);
            this.cardValue.PerformLayout();
            this.cardLowStock.ResumeLayout(false);
            this.cardLowStock.PerformLayout();
            this.cardCategories.ResumeLayout(false);
            this.cardCategories.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
