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
        
        // User Area (bottom sidebar)
        private UserProfilePanel panelUserArea;
        private System.Windows.Forms.Panel panelUserAvatar;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserRole;
        private System.Windows.Forms.Panel panelThemeRow;
        private System.Windows.Forms.Label labelThemeIcon;
        private System.Windows.Forms.Label labelThemeText;
        private ToggleSwitch toggleTheme;
        private DevNooTools.RoundedButton btnLogout;

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
            this.panelSidebar = new DevNooTools.GlassPanel();
            this.panelUserArea = new DevNooTools.UserProfilePanel();
            this.panelThemeRow = new System.Windows.Forms.Panel();
            this.toggleTheme = new DevNooTools.ToggleSwitch();
            this.labelThemeText = new System.Windows.Forms.Label();
            this.labelThemeIcon = new System.Windows.Forms.Label();
            this.btnLogout = new DevNooTools.RoundedButton();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelUserAvatar = new System.Windows.Forms.Panel();
            this.panelNavProducts = new DevNooTools.NavPanel();
            this.lblNavProducts = new System.Windows.Forms.Label();
            this.panelNavDashboard = new DevNooTools.NavPanel();
            this.lblNavDashboard = new System.Windows.Forms.Label();
            this.labelLogoSub = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGrid = new DevNooTools.RoundedPanel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.bindingSourceProducts = new System.Windows.Forms.BindingSource(this.components);
            this.labelGridTitle = new System.Windows.Forms.Label();
            this.panelForm = new DevNooTools.RoundedPanel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnClear = new DevNooTools.RoundedButton();
            this.btnDelete = new DevNooTools.RoundedButton();
            this.btnSave = new DevNooTools.RoundedButton();
            this.btnAdd = new DevNooTools.RoundedButton();
            this.textQuantity = new DevNooTools.RoundedTextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textPrice = new DevNooTools.RoundedTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textDescription = new DevNooTools.RoundedTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textName = new DevNooTools.RoundedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardCategories = new DevNooTools.GradientCard();
            this.labelCardCategoriesValue = new System.Windows.Forms.Label();
            this.labelCardCategoriesTitle = new System.Windows.Forms.Label();
            this.labelCardCategoriesIcon = new System.Windows.Forms.Label();
            this.cardLowStock = new DevNooTools.GradientCard();
            this.labelCardLowStockValue = new System.Windows.Forms.Label();
            this.labelCardLowStockTitle = new System.Windows.Forms.Label();
            this.labelCardLowStockIcon = new System.Windows.Forms.Label();
            this.cardValue = new DevNooTools.GradientCard();
            this.labelCardValueValue = new System.Windows.Forms.Label();
            this.labelCardValueTitle = new System.Windows.Forms.Label();
            this.labelCardValueIcon = new System.Windows.Forms.Label();
            this.cardTotal = new DevNooTools.GradientCard();
            this.labelCardTotalValue = new System.Windows.Forms.Label();
            this.labelCardTotalTitle = new System.Windows.Forms.Label();
            this.labelCardTotalIcon = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelUserArea.SuspendLayout();
            this.panelThemeRow.SuspendLayout();
            this.panelNavProducts.SuspendLayout();
            this.panelNavDashboard.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.cardCategories.SuspendLayout();
            this.cardLowStock.SuspendLayout();
            this.cardValue.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panelSidebar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.panelSidebar.BorderSize = 1;
            this.panelSidebar.Controls.Add(this.panelUserArea);
            this.panelSidebar.Controls.Add(this.panelNavProducts);
            this.panelSidebar.Controls.Add(this.panelNavDashboard);
            this.panelSidebar.Controls.Add(this.labelLogoSub);
            this.panelSidebar.Controls.Add(this.labelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.GlowColor = System.Drawing.Color.Empty;
            this.panelSidebar.GlowSize = 0;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Radius = 0;
            this.panelSidebar.ShowGlow = false;
            this.panelSidebar.Size = new System.Drawing.Size(240, 720);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelUserArea
            // 
            this.panelUserArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelUserArea.BackColor = System.Drawing.Color.Transparent;
            this.panelUserArea.Controls.Add(this.btnLogout);
            this.panelUserArea.Controls.Add(this.panelThemeRow);
            this.panelUserArea.Controls.Add(this.labelUserRole);
            this.panelUserArea.Controls.Add(this.labelUserName);
            this.panelUserArea.Controls.Add(this.panelUserAvatar);
            this.panelUserArea.Location = new System.Drawing.Point(12, 518);
            this.panelUserArea.Name = "panelUserArea";
            this.panelUserArea.Radius = 12;
            this.panelUserArea.Size = new System.Drawing.Size(216, 190);
            this.panelUserArea.TabIndex = 7;
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
            // toggleTheme
            // 
            this.toggleTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleTheme.IsOn = true;
            this.toggleTheme.Location = new System.Drawing.Point(140, 7);
            this.toggleTheme.Name = "toggleTheme";
            this.toggleTheme.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.toggleTheme.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.toggleTheme.Size = new System.Drawing.Size(48, 26);
            this.toggleTheme.TabIndex = 2;
            // 
            // labelThemeText
            // 
            this.labelThemeText.AutoSize = true;
            this.labelThemeText.BackColor = System.Drawing.Color.Transparent;
            this.labelThemeText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelThemeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.labelThemeText.Location = new System.Drawing.Point(30, 11);
            this.labelThemeText.Name = "labelThemeText";
            this.labelThemeText.Size = new System.Drawing.Size(78, 15);
            this.labelThemeText.TabIndex = 1;
            this.labelThemeText.Text = "Tema Escuro";
            // 
            // labelThemeIcon
            // 
            this.labelThemeIcon.AutoSize = true;
            this.labelThemeIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelThemeIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelThemeIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.labelThemeIcon.Location = new System.Drawing.Point(4, 8);
            this.labelThemeIcon.Name = "labelThemeIcon";
            this.labelThemeIcon.Size = new System.Drawing.Size(22, 20);
            this.labelThemeIcon.TabIndex = 0;
            this.labelThemeIcon.Text = "☾";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(54)))), ((int)(((byte)(51)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(38)))), ((int)(((byte)(35)))));
            this.btnLogout.Location = new System.Drawing.Point(10, 126);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnLogout.Radius = 12;
            this.btnLogout.Size = new System.Drawing.Size(196, 42);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "⎋ Terminar sessão";
            this.btnLogout.UseGradient = true;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // labelUserRole
            // 
            this.labelUserRole.AutoSize = true;
            this.labelUserRole.BackColor = System.Drawing.Color.Transparent;
            this.labelUserRole.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.labelUserRole.Location = new System.Drawing.Point(67, 37);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(59, 15);
            this.labelUserRole.TabIndex = 2;
            this.labelUserRole.Text = "Utilizador";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.labelUserName.Location = new System.Drawing.Point(66, 16);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(39, 19);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Guts";
            // 
            // panelUserAvatar
            // 
            this.panelUserAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.panelUserAvatar.Location = new System.Drawing.Point(14, 14);
            this.panelUserAvatar.Name = "panelUserAvatar";
            this.panelUserAvatar.Size = new System.Drawing.Size(44, 44);
            this.panelUserAvatar.TabIndex = 0;
            // 
            // panelNavProducts
            // 
            this.panelNavProducts.BackColor = System.Drawing.Color.Transparent;
            this.panelNavProducts.Controls.Add(this.lblNavProducts);
            this.panelNavProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavProducts.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.panelNavProducts.IsSelected = false;
            this.panelNavProducts.Location = new System.Drawing.Point(12, 146);
            this.panelNavProducts.Name = "panelNavProducts";
            this.panelNavProducts.Radius = 8;
            this.panelNavProducts.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.panelNavProducts.Size = new System.Drawing.Size(216, 40);
            this.panelNavProducts.TabIndex = 3;
            // 
            // lblNavProducts
            // 
            this.lblNavProducts.AutoSize = true;
            this.lblNavProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblNavProducts.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNavProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.lblNavProducts.Location = new System.Drawing.Point(14, 10);
            this.lblNavProducts.Name = "lblNavProducts";
            this.lblNavProducts.Size = new System.Drawing.Size(64, 17);
            this.lblNavProducts.TabIndex = 0;
            this.lblNavProducts.Text = "Produtos";
            // 
            // panelNavDashboard
            // 
            this.panelNavDashboard.BackColor = System.Drawing.Color.Transparent;
            this.panelNavDashboard.Controls.Add(this.lblNavDashboard);
            this.panelNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavDashboard.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.panelNavDashboard.IsSelected = true;
            this.panelNavDashboard.Location = new System.Drawing.Point(12, 100);
            this.panelNavDashboard.Name = "panelNavDashboard";
            this.panelNavDashboard.Radius = 8;
            this.panelNavDashboard.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.panelNavDashboard.Size = new System.Drawing.Size(216, 40);
            this.panelNavDashboard.TabIndex = 2;
            // 
            // lblNavDashboard
            // 
            this.lblNavDashboard.AutoSize = true;
            this.lblNavDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.lblNavDashboard.Location = new System.Drawing.Point(14, 10);
            this.lblNavDashboard.Name = "lblNavDashboard";
            this.lblNavDashboard.Size = new System.Drawing.Size(73, 17);
            this.lblNavDashboard.TabIndex = 0;
            this.lblNavDashboard.Text = "Dashboard";
            // 
            // labelLogoSub
            // 
            this.labelLogoSub.AutoSize = true;
            this.labelLogoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelLogoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.labelLogoSub.Location = new System.Drawing.Point(22, 56);
            this.labelLogoSub.Name = "labelLogoSub";
            this.labelLogoSub.Size = new System.Drawing.Size(110, 15);
            this.labelLogoSub.TabIndex = 1;
            this.labelLogoSub.Text = "Gestão de Produtos";
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.labelLogo.Location = new System.Drawing.Point(20, 24);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(149, 30);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "DevNooTools";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
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
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panelGrid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.panelGrid.BorderSize = 1;
            this.panelGrid.Controls.Add(this.dataGridViewProducts);
            this.panelGrid.Controls.Add(this.labelGridTitle);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(24, 366);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(16);
            this.panelGrid.Radius = 12;
            this.panelGrid.ShadowDepth = 4;
            this.panelGrid.ShowShadow = false;
            this.panelGrid.Size = new System.Drawing.Size(872, 334);
            this.panelGrid.TabIndex = 3;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProducts.ColumnHeadersHeight = 42;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProducts.DataSource = this.bindingSourceProducts;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
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
            // labelGridTitle
            // 
            this.labelGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.labelGridTitle.Location = new System.Drawing.Point(16, 16);
            this.labelGridTitle.Name = "labelGridTitle";
            this.labelGridTitle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.labelGridTitle.Size = new System.Drawing.Size(840, 36);
            this.labelGridTitle.TabIndex = 0;
            this.labelGridTitle.Text = "Lista de Produtos";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panelForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
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
            this.panelForm.Location = new System.Drawing.Point(24, 196);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(20);
            this.panelForm.Radius = 12;
            this.panelForm.ShadowDepth = 4;
            this.panelForm.ShowShadow = false;
            this.panelForm.Size = new System.Drawing.Size(872, 170);
            this.panelForm.TabIndex = 2;
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
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.btnClear.Location = new System.Drawing.Point(346, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Radius = 8;
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseGradient = true;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(54)))), ((int)(((byte)(51)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(38)))), ((int)(((byte)(35)))));
            this.btnDelete.Location = new System.Drawing.Point(234, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 8;
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseGradient = true;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(235)))));
            this.btnSave.Location = new System.Drawing.Point(122, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 8;
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseGradient = true;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(54)))));
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 8;
            this.btnAdd.Size = new System.Drawing.Size(110, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseGradient = true;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textQuantity
            // 
            this.textQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.textQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textQuantity.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.textQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.textQuantity.Location = new System.Drawing.Point(608, 66);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Radius = 8;
            this.textQuantity.Size = new System.Drawing.Size(80, 36);
            this.textQuantity.TabIndex = 8;
            this.textQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.lblQuantity.Location = new System.Drawing.Point(608, 48);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(30, 15);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Qtd.";
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.textPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textPrice.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.textPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.textPrice.Location = new System.Drawing.Point(472, 66);
            this.textPrice.Name = "textPrice";
            this.textPrice.Radius = 8;
            this.textPrice.Size = new System.Drawing.Size(120, 36);
            this.textPrice.TabIndex = 6;
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.lblPrice.Location = new System.Drawing.Point(472, 48);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Preço (EUR)";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.textDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textDescription.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.textDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.textDescription.Location = new System.Drawing.Point(206, 66);
            this.textDescription.Name = "textDescription";
            this.textDescription.Radius = 8;
            this.textDescription.Size = new System.Drawing.Size(250, 36);
            this.textDescription.TabIndex = 4;
            this.textDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.lblDescription.Location = new System.Drawing.Point(206, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(58, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Descrição";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.textName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.textName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.textName.Location = new System.Drawing.Point(20, 66);
            this.textName.Name = "textName";
            this.textName.Radius = 8;
            this.textName.Size = new System.Drawing.Size(170, 36);
            this.textName.TabIndex = 2;
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.lblName.Location = new System.Drawing.Point(20, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome";
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.labelFormTitle.Location = new System.Drawing.Point(20, 16);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(210, 21);
            this.labelFormTitle.TabIndex = 0;
            this.labelFormTitle.Text = "Adicionar / Editar Produto";
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
            // cardCategories
            // 
            this.cardCategories.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(223)))));
            this.cardCategories.AccentWidth = 4;
            this.cardCategories.BorderColor = System.Drawing.Color.Empty;
            this.cardCategories.Controls.Add(this.labelCardCategoriesValue);
            this.cardCategories.Controls.Add(this.labelCardCategoriesTitle);
            this.cardCategories.Controls.Add(this.labelCardCategoriesIcon);
            this.cardCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.cardCategories.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(64)))), ((int)(((byte)(201)))));
            this.cardCategories.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(223)))));
            this.cardCategories.Location = new System.Drawing.Point(666, 8);
            this.cardCategories.Name = "cardCategories";
            this.cardCategories.Radius = 12;
            this.cardCategories.ShowShadow = true;
            this.cardCategories.Size = new System.Drawing.Size(205, 100);
            this.cardCategories.TabIndex = 3;
            // 
            // labelCardCategoriesValue
            // 
            this.labelCardCategoriesValue.BackColor = System.Drawing.Color.Transparent;
            this.labelCardCategoriesValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelCardCategoriesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(223)))));
            this.labelCardCategoriesValue.Location = new System.Drawing.Point(14, 38);
            this.labelCardCategoriesValue.Name = "labelCardCategoriesValue";
            this.labelCardCategoriesValue.Size = new System.Drawing.Size(180, 52);
            this.labelCardCategoriesValue.TabIndex = 2;
            this.labelCardCategoriesValue.Text = "0";
            // 
            // labelCardCategoriesTitle
            // 
            this.labelCardCategoriesTitle.Location = new System.Drawing.Point(0, 0);
            this.labelCardCategoriesTitle.Name = "labelCardCategoriesTitle";
            this.labelCardCategoriesTitle.Size = new System.Drawing.Size(0, 0);
            this.labelCardCategoriesTitle.TabIndex = 1;
            this.labelCardCategoriesTitle.Visible = false;
            // 
            // labelCardCategoriesIcon
            // 
            this.labelCardCategoriesIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelCardCategoriesIcon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCardCategoriesIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.labelCardCategoriesIcon.Location = new System.Drawing.Point(20, 16);
            this.labelCardCategoriesIcon.Name = "labelCardCategoriesIcon";
            this.labelCardCategoriesIcon.Size = new System.Drawing.Size(170, 18);
            this.labelCardCategoriesIcon.TabIndex = 0;
            this.labelCardCategoriesIcon.Text = "Categorias";
            // 
            // cardLowStock
            // 
            this.cardLowStock.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(98)))), ((int)(((byte)(9)))));
            this.cardLowStock.AccentWidth = 4;
            this.cardLowStock.BorderColor = System.Drawing.Color.Empty;
            this.cardLowStock.Controls.Add(this.labelCardLowStockValue);
            this.cardLowStock.Controls.Add(this.labelCardLowStockTitle);
            this.cardLowStock.Controls.Add(this.labelCardLowStockIcon);
            this.cardLowStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.cardLowStock.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.cardLowStock.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(98)))), ((int)(((byte)(9)))));
            this.cardLowStock.Location = new System.Drawing.Point(444, 8);
            this.cardLowStock.Name = "cardLowStock";
            this.cardLowStock.Radius = 12;
            this.cardLowStock.ShowShadow = true;
            this.cardLowStock.Size = new System.Drawing.Size(205, 100);
            this.cardLowStock.TabIndex = 2;
            // 
            // labelCardLowStockValue
            // 
            this.labelCardLowStockValue.BackColor = System.Drawing.Color.Transparent;
            this.labelCardLowStockValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelCardLowStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(98)))), ((int)(((byte)(9)))));
            this.labelCardLowStockValue.Location = new System.Drawing.Point(14, 38);
            this.labelCardLowStockValue.Name = "labelCardLowStockValue";
            this.labelCardLowStockValue.Size = new System.Drawing.Size(180, 52);
            this.labelCardLowStockValue.TabIndex = 2;
            this.labelCardLowStockValue.Text = "0";
            // 
            // labelCardLowStockTitle
            // 
            this.labelCardLowStockTitle.Location = new System.Drawing.Point(0, 0);
            this.labelCardLowStockTitle.Name = "labelCardLowStockTitle";
            this.labelCardLowStockTitle.Size = new System.Drawing.Size(0, 0);
            this.labelCardLowStockTitle.TabIndex = 1;
            this.labelCardLowStockTitle.Visible = false;
            // 
            // labelCardLowStockIcon
            // 
            this.labelCardLowStockIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelCardLowStockIcon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCardLowStockIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.labelCardLowStockIcon.Location = new System.Drawing.Point(20, 16);
            this.labelCardLowStockIcon.Name = "labelCardLowStockIcon";
            this.labelCardLowStockIcon.Size = new System.Drawing.Size(170, 18);
            this.labelCardLowStockIcon.TabIndex = 0;
            this.labelCardLowStockIcon.Text = "Stock Baixo";
            // 
            // cardValue
            // 
            this.cardValue.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.cardValue.AccentWidth = 4;
            this.cardValue.BorderColor = System.Drawing.Color.Empty;
            this.cardValue.Controls.Add(this.labelCardValueValue);
            this.cardValue.Controls.Add(this.labelCardValueTitle);
            this.cardValue.Controls.Add(this.labelCardValueIcon);
            this.cardValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.cardValue.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(54)))));
            this.cardValue.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.cardValue.Location = new System.Drawing.Point(222, 8);
            this.cardValue.Name = "cardValue";
            this.cardValue.Radius = 12;
            this.cardValue.ShowShadow = true;
            this.cardValue.Size = new System.Drawing.Size(205, 100);
            this.cardValue.TabIndex = 1;
            // 
            // labelCardValueValue
            // 
            this.labelCardValueValue.BackColor = System.Drawing.Color.Transparent;
            this.labelCardValueValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelCardValueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.labelCardValueValue.Location = new System.Drawing.Point(16, 42);
            this.labelCardValueValue.Name = "labelCardValueValue";
            this.labelCardValueValue.Size = new System.Drawing.Size(176, 48);
            this.labelCardValueValue.TabIndex = 2;
            this.labelCardValueValue.Text = "0,00 €";
            // 
            // labelCardValueTitle
            // 
            this.labelCardValueTitle.Location = new System.Drawing.Point(0, 0);
            this.labelCardValueTitle.Name = "labelCardValueTitle";
            this.labelCardValueTitle.Size = new System.Drawing.Size(0, 0);
            this.labelCardValueTitle.TabIndex = 1;
            this.labelCardValueTitle.Visible = false;
            // 
            // labelCardValueIcon
            // 
            this.labelCardValueIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelCardValueIcon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCardValueIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.labelCardValueIcon.Location = new System.Drawing.Point(20, 16);
            this.labelCardValueIcon.Name = "labelCardValueIcon";
            this.labelCardValueIcon.Size = new System.Drawing.Size(170, 18);
            this.labelCardValueIcon.TabIndex = 0;
            this.labelCardValueIcon.Text = "Valor Stock";
            // 
            // cardTotal
            // 
            this.cardTotal.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.cardTotal.AccentWidth = 4;
            this.cardTotal.BorderColor = System.Drawing.Color.Empty;
            this.cardTotal.Controls.Add(this.labelCardTotalValue);
            this.cardTotal.Controls.Add(this.labelCardTotalTitle);
            this.cardTotal.Controls.Add(this.labelCardTotalIcon);
            this.cardTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.cardTotal.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(235)))));
            this.cardTotal.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.cardTotal.Location = new System.Drawing.Point(0, 8);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Radius = 12;
            this.cardTotal.ShowShadow = true;
            this.cardTotal.Size = new System.Drawing.Size(205, 100);
            this.cardTotal.TabIndex = 0;
            // 
            // labelCardTotalValue
            // 
            this.labelCardTotalValue.BackColor = System.Drawing.Color.Transparent;
            this.labelCardTotalValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelCardTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.labelCardTotalValue.Location = new System.Drawing.Point(14, 38);
            this.labelCardTotalValue.Name = "labelCardTotalValue";
            this.labelCardTotalValue.Size = new System.Drawing.Size(180, 52);
            this.labelCardTotalValue.TabIndex = 2;
            this.labelCardTotalValue.Text = "0";
            // 
            // labelCardTotalTitle
            // 
            this.labelCardTotalTitle.Location = new System.Drawing.Point(0, 0);
            this.labelCardTotalTitle.Name = "labelCardTotalTitle";
            this.labelCardTotalTitle.Size = new System.Drawing.Size(0, 0);
            this.labelCardTotalTitle.TabIndex = 1;
            this.labelCardTotalTitle.Visible = false;
            // 
            // labelCardTotalIcon
            // 
            this.labelCardTotalIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelCardTotalIcon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCardTotalIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.labelCardTotalIcon.Location = new System.Drawing.Point(20, 16);
            this.labelCardTotalIcon.Name = "labelCardTotalIcon";
            this.labelCardTotalIcon.Size = new System.Drawing.Size(170, 18);
            this.labelCardTotalIcon.TabIndex = 0;
            this.labelCardTotalIcon.Text = "Total Produtos";
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
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.labelSubtitle.Location = new System.Drawing.Point(4, 42);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(218, 19);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Gerencie seu inventário facilmente";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(158, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Produtos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
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
            this.panelNavProducts.ResumeLayout(false);
            this.panelNavProducts.PerformLayout();
            this.panelNavDashboard.ResumeLayout(false);
            this.panelNavDashboard.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelCards.ResumeLayout(false);
            this.cardCategories.ResumeLayout(false);
            this.cardLowStock.ResumeLayout(false);
            this.cardValue.ResumeLayout(false);
            this.cardTotal.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
