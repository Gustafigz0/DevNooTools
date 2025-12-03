namespace DevNooTools
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Sidebar
        private GlassPanel panelSidebar;
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
        
        // User Area (bottom sidebar)
        private UserProfilePanel panelUserArea;
        private System.Windows.Forms.Panel panelUserAvatar;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserRole;
        private System.Windows.Forms.Panel panelThemeRow;
        private System.Windows.Forms.Label labelThemeIcon;
        private System.Windows.Forms.Label labelThemeText;
        private ToggleSwitch toggleTheme;

        // Main
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;

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
            
            // GitHub Dark Theme Colors
            System.Drawing.Color bgDark = System.Drawing.Color.FromArgb(13, 17, 23);
            System.Drawing.Color bgCard = System.Drawing.Color.FromArgb(22, 27, 34);
            System.Drawing.Color bgInput = System.Drawing.Color.FromArgb(33, 38, 45);
            System.Drawing.Color bgHover = System.Drawing.Color.FromArgb(48, 54, 61);
            
            System.Drawing.Color accentBlue = System.Drawing.Color.FromArgb(56, 139, 253);
            System.Drawing.Color accentGreen = System.Drawing.Color.FromArgb(46, 160, 67);
            System.Drawing.Color accentOrange = System.Drawing.Color.FromArgb(227, 98, 9);
            System.Drawing.Color accentPurple = System.Drawing.Color.FromArgb(130, 80, 223);
            System.Drawing.Color accentRed = System.Drawing.Color.FromArgb(218, 54, 51);
            
            System.Drawing.Color textPrimary = System.Drawing.Color.FromArgb(230, 237, 243);
            System.Drawing.Color textSecondary = System.Drawing.Color.FromArgb(139, 148, 158);
            System.Drawing.Color textMuted = System.Drawing.Color.FromArgb(110, 118, 129);
            
            System.Drawing.Color borderColor = System.Drawing.Color.FromArgb(48, 54, 61);

            this.panelSidebar = new GlassPanel();
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
            this.panelUserArea = new UserProfilePanel();
            this.panelUserAvatar = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.panelThemeRow = new System.Windows.Forms.Panel();
            this.labelThemeIcon = new System.Windows.Forms.Label();
            this.labelThemeText = new System.Windows.Forms.Label();
            this.toggleTheme = new ToggleSwitch();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
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
            this.panelUserArea.SuspendLayout();
            this.panelThemeRow.SuspendLayout();
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
            this.panelSidebar.BackColor = bgDark;
            this.panelSidebar.Radius = 0;
            this.panelSidebar.BorderColor = borderColor;
            this.panelSidebar.BorderSize = 1;
            this.panelSidebar.Controls.Add(this.panelUserArea);
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
            this.panelSidebar.Size = new System.Drawing.Size(240, 720);
            this.panelSidebar.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelLogo.ForeColor = textPrimary;
            this.labelLogo.Location = new System.Drawing.Point(20, 24);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(148, 30);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "DevNooTools";
            // 
            // labelLogoSub
            // 
            this.labelLogoSub.AutoSize = true;
            this.labelLogoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelLogoSub.ForeColor = textMuted;
            this.labelLogoSub.Location = new System.Drawing.Point(22, 56);
            this.labelLogoSub.Name = "labelLogoSub";
            this.labelLogoSub.Size = new System.Drawing.Size(118, 15);
            this.labelLogoSub.TabIndex = 1;
            this.labelLogoSub.Text = "Gestão de Produtos";
            // 
            // panelNavDashboard
            // 
            this.panelNavDashboard.BackColor = System.Drawing.Color.Transparent;
            this.panelNavDashboard.Controls.Add(this.lblNavDashboard);
            this.panelNavDashboard.IsSelected = false;
            this.panelNavDashboard.SelectedColor = accentBlue;
            this.panelNavDashboard.HoverColor = bgHover;
            this.panelNavDashboard.Location = new System.Drawing.Point(12, 100);
            this.panelNavDashboard.Name = "panelNavDashboard";
            this.panelNavDashboard.Radius = 8;
            this.panelNavDashboard.Size = new System.Drawing.Size(216, 40);
            this.panelNavDashboard.TabIndex = 2;
            // 
            // lblNavDashboard
            // 
            this.lblNavDashboard.AutoSize = true;
            this.lblNavDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavDashboard.ForeColor = textSecondary;
            this.lblNavDashboard.Location = new System.Drawing.Point(14, 10);
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
            this.panelNavProducts.SelectedColor = accentBlue;
            this.panelNavProducts.HoverColor = bgHover;
            this.panelNavProducts.Location = new System.Drawing.Point(12, 146);
            this.panelNavProducts.Name = "panelNavProducts";
            this.panelNavProducts.Radius = 8;
            this.panelNavProducts.Size = new System.Drawing.Size(216, 40);
            this.panelNavProducts.TabIndex = 3;
            // 
            // lblNavProducts
            // 
            this.lblNavProducts.AutoSize = true;
            this.lblNavProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblNavProducts.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNavProducts.ForeColor = textPrimary;
            this.lblNavProducts.Location = new System.Drawing.Point(14, 10);
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
            this.panelNavCategories.SelectedColor = accentBlue;
            this.panelNavCategories.HoverColor = bgHover;
            this.panelNavCategories.Location = new System.Drawing.Point(12, 192);
            this.panelNavCategories.Name = "panelNavCategories";
            this.panelNavCategories.Radius = 8;
            this.panelNavCategories.Size = new System.Drawing.Size(216, 40);
            this.panelNavCategories.TabIndex = 4;
            // 
            // lblNavCategories
            // 
            this.lblNavCategories.AutoSize = true;
            this.lblNavCategories.BackColor = System.Drawing.Color.Transparent;
            this.lblNavCategories.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavCategories.ForeColor = textSecondary;
            this.lblNavCategories.Location = new System.Drawing.Point(14, 10);
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
            this.panelNavReports.SelectedColor = accentBlue;
            this.panelNavReports.HoverColor = bgHover;
            this.panelNavReports.Location = new System.Drawing.Point(12, 238);
            this.panelNavReports.Name = "panelNavReports";
            this.panelNavReports.Radius = 8;
            this.panelNavReports.Size = new System.Drawing.Size(216, 40);
            this.panelNavReports.TabIndex = 5;
            // 
            // lblNavReports
            // 
            this.lblNavReports.AutoSize = true;
            this.lblNavReports.BackColor = System.Drawing.Color.Transparent;
            this.lblNavReports.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavReports.ForeColor = textSecondary;
            this.lblNavReports.Location = new System.Drawing.Point(14, 10);
            this.lblNavReports.Name = "lblNavReports";
            this.lblNavReports.Size = new System.Drawing.Size(63, 17);
            this.lblNavReports.TabIndex = 0;
            this.lblNavReports.Text = "Relatórios";
            // 
            // panelNavSettings
            // 
            this.panelNavSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelNavSettings.Controls.Add(this.lblNavSettings);
            this.panelNavSettings.IsSelected = false;
            this.panelNavSettings.SelectedColor = accentBlue;
            this.panelNavSettings.HoverColor = bgHover;
            this.panelNavSettings.Location = new System.Drawing.Point(12, 284);
            this.panelNavSettings.Name = "panelNavSettings";
            this.panelNavSettings.Radius = 8;
            this.panelNavSettings.Size = new System.Drawing.Size(216, 40);
            this.panelNavSettings.TabIndex = 6;
            // 
            // lblNavSettings
            // 
            this.lblNavSettings.AutoSize = true;
            this.lblNavSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblNavSettings.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavSettings.ForeColor = textSecondary;
            this.lblNavSettings.Location = new System.Drawing.Point(14, 10);
            this.lblNavSettings.Name = "lblNavSettings";
            this.lblNavSettings.Size = new System.Drawing.Size(86, 17);
            this.lblNavSettings.TabIndex = 0;
            this.lblNavSettings.Text = "Configurações";
            // 
            // panelUserArea
            // 
            this.panelUserArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelUserArea.BackColor = System.Drawing.Color.Transparent;
            this.panelUserArea.Radius = 12;
            this.panelUserArea.Controls.Add(this.panelThemeRow);
            this.panelUserArea.Controls.Add(this.labelUserRole);
            this.panelUserArea.Controls.Add(this.labelUserName);
            this.panelUserArea.Controls.Add(this.panelUserAvatar);
            this.panelUserArea.Location = new System.Drawing.Point(12, 590);
            this.panelUserArea.Name = "panelUserArea";
            this.panelUserArea.Size = new System.Drawing.Size(216, 118);
            this.panelUserArea.TabIndex = 7;
            // 
            // panelUserAvatar
            // 
            this.panelUserAvatar.BackColor = accentBlue;
            this.panelUserAvatar.Location = new System.Drawing.Point(14, 14);
            this.panelUserAvatar.Name = "panelUserAvatar";
            this.panelUserAvatar.Size = new System.Drawing.Size(44, 44);
            this.panelUserAvatar.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelUserName.ForeColor = textPrimary;
            this.labelUserName.Location = new System.Drawing.Point(66, 16);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(69, 19);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Utilizador";
            // 
            // labelUserRole
            // 
            this.labelUserRole.AutoSize = true;
            this.labelUserRole.BackColor = System.Drawing.Color.Transparent;
            this.labelUserRole.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelUserRole.ForeColor = textMuted;
            this.labelUserRole.Location = new System.Drawing.Point(67, 37);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(87, 15);
            this.labelUserRole.TabIndex = 2;
            this.labelUserRole.Text = "Administrador";
            // 
            // panelThemeRow
            // 
            this.panelThemeRow.BackColor = System.Drawing.Color.Transparent;
            this.panelThemeRow.Controls.Add(this.toggleTheme);
            this.panelThemeRow.Controls.Add(this.labelThemeText);
            this.panelThemeRow.Controls.Add(this.labelThemeIcon);
            this.panelThemeRow.Location = new System.Drawing.Point(10, 70);
            this.panelThemeRow.Name = "panelThemeRow";
            this.panelThemeRow.Size = new System.Drawing.Size(196, 38);
            this.panelThemeRow.TabIndex = 3;
            // 
            // labelThemeIcon
            // 
            this.labelThemeIcon.AutoSize = true;
            this.labelThemeIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelThemeIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelThemeIcon.ForeColor = textSecondary;
            this.labelThemeIcon.Location = new System.Drawing.Point(4, 8);
            this.labelThemeIcon.Name = "labelThemeIcon";
            this.labelThemeIcon.Size = new System.Drawing.Size(24, 20);
            this.labelThemeIcon.TabIndex = 0;
            this.labelThemeIcon.Text = "??";
            // 
            // labelThemeText
            // 
            this.labelThemeText.AutoSize = true;
            this.labelThemeText.BackColor = System.Drawing.Color.Transparent;
            this.labelThemeText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelThemeText.ForeColor = textSecondary;
            this.labelThemeText.Location = new System.Drawing.Point(30, 11);
            this.labelThemeText.Name = "labelThemeText";
            this.labelThemeText.Size = new System.Drawing.Size(72, 15);
            this.labelThemeText.TabIndex = 1;
            this.labelThemeText.Text = "Tema Claro";
            // 
            // toggleTheme
            // 
            this.toggleTheme.IsOn = true;
            this.toggleTheme.Location = new System.Drawing.Point(140, 7);
            this.toggleTheme.Name = "toggleTheme";
            this.toggleTheme.Size = new System.Drawing.Size(48, 26);
            this.toggleTheme.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = bgCard;
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.panelCards);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(240, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.panelMain.Size = new System.Drawing.Size(920, 720);
            this.panelMain.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.labelSubtitle);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(24, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(872, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = textPrimary;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(165, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Produtos";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitle.ForeColor = textMuted;
            this.labelSubtitle.Location = new System.Drawing.Point(4, 42);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(203, 19);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Gerencie seu inventário facilmente";
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Controls.Add(this.cardCategories);
            this.panelCards.Controls.Add(this.cardLowStock);
            this.panelCards.Controls.Add(this.cardValue);
            this.panelCards.Controls.Add(this.cardTotal);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCards.Location = new System.Drawing.Point(24, 80);
            this.panelCards.Name = "panelCards";
            this.panelCards.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.panelCards.Size = new System.Drawing.Size(872, 116);
            this.panelCards.TabIndex = 1;
            // 
            // cardTotal - Blue gradient
            // 
            this.cardTotal.GradientStartColor = System.Drawing.Color.FromArgb(56, 139, 253);
            this.cardTotal.GradientEndColor = System.Drawing.Color.FromArgb(31, 111, 235);
            this.cardTotal.Controls.Add(this.labelCardTotalValue);
            this.cardTotal.Controls.Add(this.labelCardTotalTitle);
            this.cardTotal.Controls.Add(this.labelCardTotalIcon);
            this.cardTotal.Location = new System.Drawing.Point(0, 8);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Radius = 12;
            this.cardTotal.Size = new System.Drawing.Size(205, 96);
            this.cardTotal.TabIndex = 0;
            // 
            // labelCardTotalIcon
            // 
            this.labelCardTotalIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelCardTotalIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelCardTotalIcon.ForeColor = System.Drawing.Color.FromArgb(220, 255, 255, 255);
            this.labelCardTotalIcon.Location = new System.Drawing.Point(16, 12);
            this.labelCardTotalIcon.Name = "labelCardTotalIcon";
            this.labelCardTotalIcon.Size = new System.Drawing.Size(173, 20);
            this.labelCardTotalIcon.TabIndex = 0;
            this.labelCardTotalIcon.Text = "Total Produtos";
            // 
            // labelCardTotalTitle
            // 
            this.labelCardTotalTitle.Visible = false;
            this.labelCardTotalTitle.Location = new System.Drawing.Point(0, 0);
            this.labelCardTotalTitle.Name = "labelCardTotalTitle";
            this.labelCardTotalTitle.Size = new System.Drawing.Size(0, 0);
            this.labelCardTotalTitle.TabIndex = 1;
            // 
            // labelCardTotalValue
            // 
            this.labelCardTotalValue.BackColor = System.Drawing.Color.Transparent;
            this.labelCardTotalValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelCardTotalValue.ForeColor = System.Drawing.Color.White;
            this.labelCardTotalValue.Location = new System.Drawing.Point(12, 38);
            this.labelCardTotalValue.Name = "labelCardTotalValue";
            this.labelCardTotalValue.Size = new System.Drawing.Size(180, 52);
            this.labelCardTotalValue.TabIndex = 2;
            this.labelCardTotalValue.Text = "0";
            // 
            // cardValue - Green gradient
            // 
            this.cardValue.GradientStartColor = System.Drawing.Color.FromArgb(46, 160, 67);
            this.cardValue.GradientEndColor = System.Drawing.Color.FromArgb(35, 134, 54);
            this.cardValue.Controls.Add(this.labelCardValueValue);
            this.cardValue.Controls.Add(this.labelCardValueTitle);
            this.cardValue.Controls.Add(this.labelCardValueIcon);
            this.cardValue.Location = new System.Drawing.Point(222, 8);
            this.cardValue.Name = "cardValue";
            this.cardValue.Radius = 12;
            this.cardValue.Size = new System.Drawing.Size(205, 96);
            this.cardValue.TabIndex = 1;
            // 
            // labelCardValueIcon
            // 
            this.labelCardValueIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelCardValueIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelCardValueIcon.ForeColor = System.Drawing.Color.FromArgb(220, 255, 255, 255);
            this.labelCardValueIcon.Location = new System.Drawing.Point(16, 12);
            this.labelCardValueIcon.Name = "labelCardValueIcon";
            this.labelCardValueIcon.Size = new System.Drawing.Size(173, 20);
            this.labelCardValueIcon.TabIndex = 0;
            this.labelCardValueIcon.Text = "Valor Estoque";
            // 
            // labelCardValueTitle
            // 
            this.labelCardValueTitle.Visible = false;
            this.labelCardValueTitle.Location = new System.Drawing.Point(0, 0);
            this.labelCardValueTitle.Name = "labelCardValueTitle";
            this.labelCardValueTitle.Size = new System.Drawing.Size(0, 0);
            this.labelCardValueTitle.TabIndex = 1;
            // 
            // labelCardValueValue
            // 
            this.labelCardValueValue.BackColor = System.Drawing.Color.Transparent;
            this.labelCardValueValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelCardValueValue.ForeColor = System.Drawing.Color.White;
            this.labelCardValueValue.Location = new System.Drawing.Point(14, 42);
            this.labelCardValueValue.Name = "labelCardValueValue";
            this.labelCardValueValue.Size = new System.Drawing.Size(178, 48);
            this.labelCardValueValue.TabIndex = 2;
            this.labelCardValueValue.Text = "0,00 €";
            // 
            // cardLowStock - Orange gradient
            // 
            this.cardLowStock.GradientStartColor = System.Drawing.Color.FromArgb(227, 98, 9);
            this.cardLowStock.GradientEndColor = System.Drawing.Color.FromArgb(191, 87, 0);
            this.cardLowStock.Controls.Add(this.labelCardLowStockValue);
            this.cardLowStock.Controls.Add(this.labelCardLowStockTitle);
            this.cardLowStock.Controls.Add(this.labelCardLowStockIcon);
            this.cardLowStock.Location = new System.Drawing.Point(444, 8);
            this.cardLowStock.Name = "cardLowStock";
            this.cardLowStock.Radius = 12;
            this.cardLowStock.Size = new System.Drawing.Size(205, 96);
            this.cardLowStock.TabIndex = 2;
            // 
            // labelCardLowStockIcon
            // 
            this.labelCardLowStockIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelCardLowStockIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelCardLowStockIcon.ForeColor = System.Drawing.Color.FromArgb(220, 255, 255, 255);
            this.labelCardLowStockIcon.Location = new System.Drawing.Point(16, 12);
            this.labelCardLowStockIcon.Name = "labelCardLowStockIcon";
            this.labelCardLowStockIcon.Size = new System.Drawing.Size(173, 20);
            this.labelCardLowStockIcon.TabIndex = 0;
            this.labelCardLowStockIcon.Text = "Estoque Baixo";
            // 
            // labelCardLowStockTitle
            // 
            this.labelCardLowStockTitle.Visible = false;
            this.labelCardLowStockTitle.Location = new System.Drawing.Point(0, 0);
            this.labelCardLowStockTitle.Name = "labelCardLowStockTitle";
            this.labelCardLowStockTitle.Size = new System.Drawing.Size(0, 0);
            this.labelCardLowStockTitle.TabIndex = 1;
            // 
            // labelCardLowStockValue
            // 
            this.labelCardLowStockValue.BackColor = System.Drawing.Color.Transparent;
            this.labelCardLowStockValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelCardLowStockValue.ForeColor = System.Drawing.Color.White;
            this.labelCardLowStockValue.Location = new System.Drawing.Point(12, 38);
            this.labelCardLowStockValue.Name = "labelCardLowStockValue";
            this.labelCardLowStockValue.Size = new System.Drawing.Size(180, 52);
            this.labelCardLowStockValue.TabIndex = 2;
            this.labelCardLowStockValue.Text = "0";
            // 
            // cardCategories - Purple gradient
            // 
            this.cardCategories.GradientStartColor = System.Drawing.Color.FromArgb(130, 80, 223);
            this.cardCategories.GradientEndColor = System.Drawing.Color.FromArgb(110, 64, 201);
            this.cardCategories.Controls.Add(this.labelCardCategoriesValue);
            this.cardCategories.Controls.Add(this.labelCardCategoriesTitle);
            this.cardCategories.Controls.Add(this.labelCardCategoriesIcon);
            this.cardCategories.Location = new System.Drawing.Point(666, 8);
            this.cardCategories.Name = "cardCategories";
            this.cardCategories.Radius = 12;
            this.cardCategories.Size = new System.Drawing.Size(205, 96);
            this.cardCategories.TabIndex = 3;
            // 
            // labelCardCategoriesIcon
            // 
            this.labelCardCategoriesIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelCardCategoriesIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelCardCategoriesIcon.ForeColor = System.Drawing.Color.FromArgb(220, 255, 255, 255);
            this.labelCardCategoriesIcon.Location = new System.Drawing.Point(16, 12);
            this.labelCardCategoriesIcon.Name = "labelCardCategoriesIcon";
            this.labelCardCategoriesIcon.Size = new System.Drawing.Size(173, 20);
            this.labelCardCategoriesIcon.TabIndex = 0;
            this.labelCardCategoriesIcon.Text = "Categorias";
            // 
            // labelCardCategoriesTitle
            // 
            this.labelCardCategoriesTitle.Visible = false;
            this.labelCardCategoriesTitle.Location = new System.Drawing.Point(0, 0);
            this.labelCardCategoriesTitle.Name = "labelCardCategoriesTitle";
            this.labelCardCategoriesTitle.Size = new System.Drawing.Size(0, 0);
            this.labelCardCategoriesTitle.TabIndex = 1;
            // 
            // labelCardCategoriesValue
            // 
            this.labelCardCategoriesValue.BackColor = System.Drawing.Color.Transparent;
            this.labelCardCategoriesValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelCardCategoriesValue.ForeColor = System.Drawing.Color.White;
            this.labelCardCategoriesValue.Location = new System.Drawing.Point(12, 38);
            this.labelCardCategoriesValue.Name = "labelCardCategoriesValue";
            this.labelCardCategoriesValue.Size = new System.Drawing.Size(180, 52);
            this.labelCardCategoriesValue.TabIndex = 2;
            this.labelCardCategoriesValue.Text = "0";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = bgDark;
            this.panelForm.BorderColor = borderColor;
            this.panelForm.BorderSize = 1;
            this.panelForm.ShowShadow = false;
            this.panelForm.Radius = 12;
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
            this.panelForm.Location = new System.Drawing.Point(24, 196);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(20);
            this.panelForm.Size = new System.Drawing.Size(872, 170);
            this.panelForm.TabIndex = 2;
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelFormTitle.ForeColor = textPrimary;
            this.labelFormTitle.Location = new System.Drawing.Point(20, 16);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(195, 21);
            this.labelFormTitle.TabIndex = 0;
            this.labelFormTitle.Text = "Adicionar / Editar Produto";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.ForeColor = textSecondary;
            this.lblName.Location = new System.Drawing.Point(20, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome";
            // 
            // textName
            // 
            this.textName.BackColor = bgInput;
            this.textName.BorderColor = borderColor;
            this.textName.FocusBorderColor = accentBlue;
            this.textName.ForeColor = textPrimary;
            this.textName.Location = new System.Drawing.Point(20, 66);
            this.textName.Name = "textName";
            this.textName.Radius = 8;
            this.textName.Size = new System.Drawing.Size(170, 36);
            this.textName.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescription.ForeColor = textSecondary;
            this.lblDescription.Location = new System.Drawing.Point(206, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(58, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Descrição";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = bgInput;
            this.textDescription.BorderColor = borderColor;
            this.textDescription.FocusBorderColor = accentBlue;
            this.textDescription.ForeColor = textPrimary;
            this.textDescription.Location = new System.Drawing.Point(206, 66);
            this.textDescription.Name = "textDescription";
            this.textDescription.Radius = 8;
            this.textDescription.Size = new System.Drawing.Size(250, 36);
            this.textDescription.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.ForeColor = textSecondary;
            this.lblPrice.Location = new System.Drawing.Point(472, 48);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Preço (EUR)";
            // 
            // textPrice
            // 
            this.textPrice.BackColor = bgInput;
            this.textPrice.BorderColor = borderColor;
            this.textPrice.FocusBorderColor = accentGreen;
            this.textPrice.ForeColor = textPrimary;
            this.textPrice.Location = new System.Drawing.Point(472, 66);
            this.textPrice.Name = "textPrice";
            this.textPrice.Radius = 8;
            this.textPrice.Size = new System.Drawing.Size(120, 36);
            this.textPrice.TabIndex = 6;
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuantity.ForeColor = textSecondary;
            this.lblQuantity.Location = new System.Drawing.Point(608, 48);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(31, 15);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Qtd.";
            // 
            // textQuantity
            // 
            this.textQuantity.BackColor = bgInput;
            this.textQuantity.BorderColor = borderColor;
            this.textQuantity.FocusBorderColor = accentBlue;
            this.textQuantity.ForeColor = textPrimary;
            this.textQuantity.Location = new System.Drawing.Point(608, 66);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Radius = 8;
            this.textQuantity.Size = new System.Drawing.Size(80, 36);
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
            this.panelButtons.Location = new System.Drawing.Point(20, 116);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(680, 42);
            this.panelButtons.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = accentGreen;
            this.btnAdd.GradientEndColor = System.Drawing.Color.FromArgb(35, 134, 54);
            this.btnAdd.UseGradient = true;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 8;
            this.btnAdd.Size = new System.Drawing.Size(110, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = accentBlue;
            this.btnSave.GradientEndColor = System.Drawing.Color.FromArgb(31, 111, 235);
            this.btnSave.UseGradient = true;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(122, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 8;
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = accentRed;
            this.btnDelete.GradientEndColor = System.Drawing.Color.FromArgb(191, 38, 35);
            this.btnDelete.UseGradient = true;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(234, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 8;
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(110, 118, 129);
            this.btnClear.GradientEndColor = System.Drawing.Color.FromArgb(87, 96, 106);
            this.btnClear.UseGradient = true;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(346, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Radius = 8;
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = bgDark;
            this.panelGrid.BorderColor = borderColor;
            this.panelGrid.BorderSize = 1;
            this.panelGrid.ShowShadow = false;
            this.panelGrid.Radius = 12;
            this.panelGrid.Controls.Add(this.dataGridViewProducts);
            this.panelGrid.Controls.Add(this.labelGridTitle);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(24, 366);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(16);
            this.panelGrid.Size = new System.Drawing.Size(872, 334);
            this.panelGrid.TabIndex = 3;
            // 
            // labelGridTitle
            // 
            this.labelGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelGridTitle.ForeColor = textPrimary;
            this.labelGridTitle.Location = new System.Drawing.Point(16, 16);
            this.labelGridTitle.Name = "labelGridTitle";
            this.labelGridTitle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.labelGridTitle.Size = new System.Drawing.Size(840, 36);
            this.labelGridTitle.TabIndex = 0;
            this.labelGridTitle.Text = "Lista de Produtos";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = bgDark;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProducts.ColumnHeadersHeight = 42;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProducts.DataSource = this.bindingSourceProducts;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.GridColor = borderColor;
            this.dataGridViewProducts.Location = new System.Drawing.Point(16, 52);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowTemplate.Height = 42;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(840, 266);
            this.dataGridViewProducts.TabIndex = 1;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = bgCard;
            this.ClientSize = new System.Drawing.Size(1160, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevNooTools - Gestão de Produtos";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelUserArea.ResumeLayout(false);
            this.panelUserArea.PerformLayout();
            this.panelThemeRow.ResumeLayout(false);
            this.panelThemeRow.PerformLayout();
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
            this.cardValue.ResumeLayout(false);
            this.cardLowStock.ResumeLayout(false);
            this.cardCategories.ResumeLayout(false);
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
