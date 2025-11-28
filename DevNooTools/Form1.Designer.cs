namespace DevNooTools
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Sidebar
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelLogoSub;
        private System.Windows.Forms.Panel panelNavDashboard;
        private System.Windows.Forms.Label lblNavDashboard;
        private System.Windows.Forms.Panel panelNavProducts;
        private System.Windows.Forms.Label lblNavProducts;
        private System.Windows.Forms.Panel panelNavCategories;
        private System.Windows.Forms.Label lblNavCategories;
        private System.Windows.Forms.Panel panelNavReports;
        private System.Windows.Forms.Label lblNavReports;
        private System.Windows.Forms.Panel panelNavSettings;
        private System.Windows.Forms.Label lblNavSettings;
        private System.Windows.Forms.Label labelVersion;

        // Main
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnExport;

        // Cards
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Label labelCardTotalIcon;
        private System.Windows.Forms.Label labelCardTotalTitle;
        private System.Windows.Forms.Label labelCardTotalValue;
        private System.Windows.Forms.Panel cardValue;
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

        // Form
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        // Grid
        private System.Windows.Forms.Panel panelGrid;
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelLogoSub = new System.Windows.Forms.Label();
            this.panelNavDashboard = new System.Windows.Forms.Panel();
            this.lblNavDashboard = new System.Windows.Forms.Label();
            this.panelNavProducts = new System.Windows.Forms.Panel();
            this.lblNavProducts = new System.Windows.Forms.Label();
            this.panelNavCategories = new System.Windows.Forms.Panel();
            this.lblNavCategories = new System.Windows.Forms.Label();
            this.panelNavReports = new System.Windows.Forms.Panel();
            this.lblNavReports = new System.Windows.Forms.Label();
            this.panelNavSettings = new System.Windows.Forms.Panel();
            this.lblNavSettings = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.labelCardTotalIcon = new System.Windows.Forms.Label();
            this.labelCardTotalTitle = new System.Windows.Forms.Label();
            this.labelCardTotalValue = new System.Windows.Forms.Label();
            this.cardValue = new System.Windows.Forms.Panel();
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
            this.lblName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
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
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
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
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(12);
            this.panelSidebar.Size = new System.Drawing.Size(230, 720);
            this.panelSidebar.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.labelLogo.Location = new System.Drawing.Point(20, 28);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(156, 32);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "DevNooTools";
            // 
            // labelLogoSub
            // 
            this.labelLogoSub.AutoSize = true;
            this.labelLogoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelLogoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelLogoSub.Location = new System.Drawing.Point(22, 60);
            this.labelLogoSub.Name = "labelLogoSub";
            this.labelLogoSub.Size = new System.Drawing.Size(111, 15);
            this.labelLogoSub.TabIndex = 1;
            this.labelLogoSub.Text = "Gestao de Produtos";
            // 
            // panelNavDashboard
            // 
            this.panelNavDashboard.BackColor = System.Drawing.Color.Transparent;
            this.panelNavDashboard.Controls.Add(this.lblNavDashboard);
            this.panelNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavDashboard.Location = new System.Drawing.Point(12, 110);
            this.panelNavDashboard.Name = "panelNavDashboard";
            this.panelNavDashboard.Size = new System.Drawing.Size(206, 44);
            this.panelNavDashboard.TabIndex = 2;
            // 
            // lblNavDashboard
            // 
            this.lblNavDashboard.AutoSize = true;
            this.lblNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblNavDashboard.Location = new System.Drawing.Point(12, 12);
            this.lblNavDashboard.Name = "lblNavDashboard";
            this.lblNavDashboard.Size = new System.Drawing.Size(82, 19);
            this.lblNavDashboard.TabIndex = 0;
            this.lblNavDashboard.Text = "   Dashboard";
            // 
            // panelNavProducts
            // 
            this.panelNavProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.panelNavProducts.Controls.Add(this.lblNavProducts);
            this.panelNavProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavProducts.Location = new System.Drawing.Point(12, 162);
            this.panelNavProducts.Name = "panelNavProducts";
            this.panelNavProducts.Size = new System.Drawing.Size(206, 44);
            this.panelNavProducts.TabIndex = 3;
            // 
            // lblNavProducts
            // 
            this.lblNavProducts.AutoSize = true;
            this.lblNavProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNavProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblNavProducts.Location = new System.Drawing.Point(12, 12);
            this.lblNavProducts.Name = "lblNavProducts";
            this.lblNavProducts.Size = new System.Drawing.Size(75, 19);
            this.lblNavProducts.TabIndex = 0;
            this.lblNavProducts.Text = "   Produtos";
            // 
            // panelNavCategories
            // 
            this.panelNavCategories.BackColor = System.Drawing.Color.Transparent;
            this.panelNavCategories.Controls.Add(this.lblNavCategories);
            this.panelNavCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavCategories.Location = new System.Drawing.Point(12, 214);
            this.panelNavCategories.Name = "panelNavCategories";
            this.panelNavCategories.Size = new System.Drawing.Size(206, 44);
            this.panelNavCategories.TabIndex = 4;
            // 
            // lblNavCategories
            // 
            this.lblNavCategories.AutoSize = true;
            this.lblNavCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNavCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblNavCategories.Location = new System.Drawing.Point(12, 12);
            this.lblNavCategories.Name = "lblNavCategories";
            this.lblNavCategories.Size = new System.Drawing.Size(84, 19);
            this.lblNavCategories.TabIndex = 0;
            this.lblNavCategories.Text = "   Categorias";
            // 
            // panelNavReports
            // 
            this.panelNavReports.BackColor = System.Drawing.Color.Transparent;
            this.panelNavReports.Controls.Add(this.lblNavReports);
            this.panelNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavReports.Location = new System.Drawing.Point(12, 266);
            this.panelNavReports.Name = "panelNavReports";
            this.panelNavReports.Size = new System.Drawing.Size(206, 44);
            this.panelNavReports.TabIndex = 5;
            // 
            // lblNavReports
            // 
            this.lblNavReports.AutoSize = true;
            this.lblNavReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNavReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblNavReports.Location = new System.Drawing.Point(12, 12);
            this.lblNavReports.Name = "lblNavReports";
            this.lblNavReports.Size = new System.Drawing.Size(78, 19);
            this.lblNavReports.TabIndex = 0;
            this.lblNavReports.Text = "   Relatorios";
            // 
            // panelNavSettings
            // 
            this.panelNavSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelNavSettings.Controls.Add(this.lblNavSettings);
            this.panelNavSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavSettings.Location = new System.Drawing.Point(12, 318);
            this.panelNavSettings.Name = "panelNavSettings";
            this.panelNavSettings.Size = new System.Drawing.Size(206, 44);
            this.panelNavSettings.TabIndex = 6;
            // 
            // lblNavSettings
            // 
            this.lblNavSettings.AutoSize = true;
            this.lblNavSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNavSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblNavSettings.Location = new System.Drawing.Point(12, 12);
            this.lblNavSettings.Name = "lblNavSettings";
            this.lblNavSettings.Size = new System.Drawing.Size(105, 19);
            this.lblNavSettings.TabIndex = 0;
            this.lblNavSettings.Text = "   Configuracoes";
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelVersion.Location = new System.Drawing.Point(20, 690);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(37, 13);
            this.labelVersion.TabIndex = 7;
            this.labelVersion.Text = "v1.0.0";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.panelCards);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(230, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(30, 24, 30, 24);
            this.panelMain.Size = new System.Drawing.Size(920, 720);
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
            this.panelHeader.Location = new System.Drawing.Point(30, 24);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(860, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(137, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Produtos";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelSubtitle.Location = new System.Drawing.Point(2, 48);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(149, 19);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Gerencie seu inventario";
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.textSearch.Location = new System.Drawing.Point(450, 20);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(260, 25);
            this.textSearch.TabIndex = 2;
            this.textSearch.Text = "Buscar produtos...";
            this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
            this.textSearch.Leave += new System.EventHandler(this.textSearch_Leave);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(730, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 35);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exportar";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Controls.Add(this.cardCategories);
            this.panelCards.Controls.Add(this.cardLowStock);
            this.panelCards.Controls.Add(this.cardValue);
            this.panelCards.Controls.Add(this.cardTotal);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCards.Location = new System.Drawing.Point(30, 104);
            this.panelCards.Name = "panelCards";
            this.panelCards.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelCards.Size = new System.Drawing.Size(860, 120);
            this.panelCards.TabIndex = 1;
            // 
            // cardTotal
            // 
            this.cardTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.cardTotal.Controls.Add(this.labelCardTotalValue);
            this.cardTotal.Controls.Add(this.labelCardTotalTitle);
            this.cardTotal.Controls.Add(this.labelCardTotalIcon);
            this.cardTotal.Location = new System.Drawing.Point(0, 10);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(190, 100);
            this.cardTotal.TabIndex = 0;
            // 
            // labelCardTotalIcon
            // 
            this.labelCardTotalIcon.AutoSize = true;
            this.labelCardTotalIcon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.labelCardTotalIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.labelCardTotalIcon.Location = new System.Drawing.Point(16, 16);
            this.labelCardTotalIcon.Name = "labelCardTotalIcon";
            this.labelCardTotalIcon.Size = new System.Drawing.Size(30, 37);
            this.labelCardTotalIcon.TabIndex = 0;
            this.labelCardTotalIcon.Text = "#";
            // 
            // labelCardTotalTitle
            // 
            this.labelCardTotalTitle.AutoSize = true;
            this.labelCardTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCardTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.labelCardTotalTitle.Location = new System.Drawing.Point(50, 26);
            this.labelCardTotalTitle.Name = "labelCardTotalTitle";
            this.labelCardTotalTitle.Size = new System.Drawing.Size(84, 15);
            this.labelCardTotalTitle.TabIndex = 1;
            this.labelCardTotalTitle.Text = "Total Produtos";
            // 
            // labelCardTotalValue
            // 
            this.labelCardTotalValue.AutoSize = true;
            this.labelCardTotalValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelCardTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.labelCardTotalValue.Location = new System.Drawing.Point(16, 52);
            this.labelCardTotalValue.Name = "labelCardTotalValue";
            this.labelCardTotalValue.Size = new System.Drawing.Size(36, 45);
            this.labelCardTotalValue.TabIndex = 2;
            this.labelCardTotalValue.Text = "0";
            // 
            // cardValue
            // 
            this.cardValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.cardValue.Controls.Add(this.labelCardValueValue);
            this.cardValue.Controls.Add(this.labelCardValueTitle);
            this.cardValue.Controls.Add(this.labelCardValueIcon);
            this.cardValue.Location = new System.Drawing.Point(210, 10);
            this.cardValue.Name = "cardValue";
            this.cardValue.Size = new System.Drawing.Size(190, 100);
            this.cardValue.TabIndex = 1;
            // 
            // labelCardValueIcon
            // 
            this.labelCardValueIcon.AutoSize = true;
            this.labelCardValueIcon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.labelCardValueIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.labelCardValueIcon.Location = new System.Drawing.Point(16, 16);
            this.labelCardValueIcon.Name = "labelCardValueIcon";
            this.labelCardValueIcon.Size = new System.Drawing.Size(28, 37);
            this.labelCardValueIcon.TabIndex = 0;
            this.labelCardValueIcon.Text = "E";
            // 
            // labelCardValueTitle
            // 
            this.labelCardValueTitle.AutoSize = true;
            this.labelCardValueTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCardValueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.labelCardValueTitle.Location = new System.Drawing.Point(50, 26);
            this.labelCardValueTitle.Name = "labelCardValueTitle";
            this.labelCardValueTitle.Size = new System.Drawing.Size(80, 15);
            this.labelCardValueTitle.TabIndex = 1;
            this.labelCardValueTitle.Text = "Valor Estoque";
            // 
            // labelCardValueValue
            // 
            this.labelCardValueValue.AutoSize = true;
            this.labelCardValueValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelCardValueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.labelCardValueValue.Location = new System.Drawing.Point(16, 55);
            this.labelCardValueValue.Name = "labelCardValueValue";
            this.labelCardValueValue.Size = new System.Drawing.Size(106, 32);
            this.labelCardValueValue.TabIndex = 2;
            this.labelCardValueValue.Text = "0,00 EUR";
            // 
            // cardLowStock
            // 
            this.cardLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.cardLowStock.Controls.Add(this.labelCardLowStockValue);
            this.cardLowStock.Controls.Add(this.labelCardLowStockTitle);
            this.cardLowStock.Controls.Add(this.labelCardLowStockIcon);
            this.cardLowStock.Location = new System.Drawing.Point(420, 10);
            this.cardLowStock.Name = "cardLowStock";
            this.cardLowStock.Size = new System.Drawing.Size(190, 100);
            this.cardLowStock.TabIndex = 2;
            // 
            // labelCardLowStockIcon
            // 
            this.labelCardLowStockIcon.AutoSize = true;
            this.labelCardLowStockIcon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.labelCardLowStockIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
            this.labelCardLowStockIcon.Location = new System.Drawing.Point(16, 16);
            this.labelCardLowStockIcon.Name = "labelCardLowStockIcon";
            this.labelCardLowStockIcon.Size = new System.Drawing.Size(22, 37);
            this.labelCardLowStockIcon.TabIndex = 0;
            this.labelCardLowStockIcon.Text = "!";
            // 
            // labelCardLowStockTitle
            // 
            this.labelCardLowStockTitle.AutoSize = true;
            this.labelCardLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCardLowStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.labelCardLowStockTitle.Location = new System.Drawing.Point(50, 26);
            this.labelCardLowStockTitle.Name = "labelCardLowStockTitle";
            this.labelCardLowStockTitle.Size = new System.Drawing.Size(82, 15);
            this.labelCardLowStockTitle.TabIndex = 1;
            this.labelCardLowStockTitle.Text = "Estoque Baixo";
            // 
            // labelCardLowStockValue
            // 
            this.labelCardLowStockValue.AutoSize = true;
            this.labelCardLowStockValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelCardLowStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
            this.labelCardLowStockValue.Location = new System.Drawing.Point(16, 52);
            this.labelCardLowStockValue.Name = "labelCardLowStockValue";
            this.labelCardLowStockValue.Size = new System.Drawing.Size(36, 45);
            this.labelCardLowStockValue.TabIndex = 2;
            this.labelCardLowStockValue.Text = "0";
            // 
            // cardCategories
            // 
            this.cardCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.cardCategories.Controls.Add(this.labelCardCategoriesValue);
            this.cardCategories.Controls.Add(this.labelCardCategoriesTitle);
            this.cardCategories.Controls.Add(this.labelCardCategoriesIcon);
            this.cardCategories.Location = new System.Drawing.Point(630, 10);
            this.cardCategories.Name = "cardCategories";
            this.cardCategories.Size = new System.Drawing.Size(190, 100);
            this.cardCategories.TabIndex = 3;
            // 
            // labelCardCategoriesIcon
            // 
            this.labelCardCategoriesIcon.AutoSize = true;
            this.labelCardCategoriesIcon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.labelCardCategoriesIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.labelCardCategoriesIcon.Location = new System.Drawing.Point(16, 16);
            this.labelCardCategoriesIcon.Name = "labelCardCategoriesIcon";
            this.labelCardCategoriesIcon.Size = new System.Drawing.Size(29, 37);
            this.labelCardCategoriesIcon.TabIndex = 0;
            this.labelCardCategoriesIcon.Text = "C";
            // 
            // labelCardCategoriesTitle
            // 
            this.labelCardCategoriesTitle.AutoSize = true;
            this.labelCardCategoriesTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCardCategoriesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.labelCardCategoriesTitle.Location = new System.Drawing.Point(50, 26);
            this.labelCardCategoriesTitle.Name = "labelCardCategoriesTitle";
            this.labelCardCategoriesTitle.Size = new System.Drawing.Size(64, 15);
            this.labelCardCategoriesTitle.TabIndex = 1;
            this.labelCardCategoriesTitle.Text = "Categorias";
            // 
            // labelCardCategoriesValue
            // 
            this.labelCardCategoriesValue.AutoSize = true;
            this.labelCardCategoriesValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelCardCategoriesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.labelCardCategoriesValue.Location = new System.Drawing.Point(16, 52);
            this.labelCardCategoriesValue.Name = "labelCardCategoriesValue";
            this.labelCardCategoriesValue.Size = new System.Drawing.Size(36, 45);
            this.labelCardCategoriesValue.TabIndex = 2;
            this.labelCardCategoriesValue.Text = "0";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
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
            this.panelForm.Location = new System.Drawing.Point(30, 224);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(24);
            this.panelForm.Size = new System.Drawing.Size(860, 180);
            this.panelForm.TabIndex = 2;
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.labelFormTitle.Location = new System.Drawing.Point(24, 20);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(202, 21);
            this.labelFormTitle.TabIndex = 0;
            this.labelFormTitle.Text = "Adicionar / Editar Produto";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblName.Location = new System.Drawing.Point(24, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NOME";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textName.Location = new System.Drawing.Point(24, 75);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(170, 25);
            this.textName.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblDescription.Location = new System.Drawing.Point(210, 55);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "DESCRICAO";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textDescription.Location = new System.Drawing.Point(210, 75);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(220, 25);
            this.textDescription.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblPrice.Location = new System.Drawing.Point(446, 55);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "PRECO (EUR)";
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textPrice.Location = new System.Drawing.Point(446, 75);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(120, 25);
            this.textPrice.TabIndex = 6;
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblQuantity.Location = new System.Drawing.Point(582, 55);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(30, 15);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "QTD";
            // 
            // textQuantity
            // 
            this.textQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.textQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textQuantity.Location = new System.Drawing.Point(582, 75);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(80, 25);
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
            this.panelButtons.Location = new System.Drawing.Point(24, 120);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(640, 44);
            this.panelButtons.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+ Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(130, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(250, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(370, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.panelGrid.Controls.Add(this.dataGridViewProducts);
            this.panelGrid.Controls.Add(this.labelGridTitle);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(30, 404);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.panelGrid.Size = new System.Drawing.Size(860, 292);
            this.panelGrid.TabIndex = 3;
            // 
            // labelGridTitle
            // 
            this.labelGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.labelGridTitle.Location = new System.Drawing.Point(20, 15);
            this.labelGridTitle.Name = "labelGridTitle";
            this.labelGridTitle.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.labelGridTitle.Size = new System.Drawing.Size(820, 40);
            this.labelGridTitle.TabIndex = 0;
            this.labelGridTitle.Text = "Lista de Produtos";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProducts.ColumnHeadersHeight = 50;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProducts.DataSource = this.bindingSourceProducts;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.dataGridViewProducts.Location = new System.Drawing.Point(20, 55);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowTemplate.Height = 50;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(820, 217);
            this.dataGridViewProducts.TabIndex = 1;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1150, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
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
