namespace DevNooTools
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Sidebar
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelLogoSub;
        private RoundedPanel panelNavDashboard;
        private System.Windows.Forms.Label lblNavDashboard;
        private RoundedPanel panelNavProducts;
        private System.Windows.Forms.Label lblNavProducts;
        private RoundedPanel panelNavCategories;
        private System.Windows.Forms.Label lblNavCategories;
        private RoundedPanel panelNavReports;
        private System.Windows.Forms.Label lblNavReports;
        private RoundedPanel panelNavSettings;
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ===== DARK INDIGO COLOR SCHEME =====
            System.Drawing.Color bgDark = System.Drawing.Color.FromArgb(15, 23, 42);
            System.Drawing.Color bgSidebar = System.Drawing.Color.FromArgb(30, 41, 59);
            System.Drawing.Color bgCard = System.Drawing.Color.FromArgb(51, 65, 85);
            System.Drawing.Color bgInput = System.Drawing.Color.FromArgb(30, 41, 59);
            System.Drawing.Color accent = System.Drawing.Color.FromArgb(99, 102, 241);
            System.Drawing.Color accentLight = System.Drawing.Color.FromArgb(129, 140, 248);
            System.Drawing.Color accentGreen = System.Drawing.Color.FromArgb(34, 197, 94);
            System.Drawing.Color accentRed = System.Drawing.Color.FromArgb(239, 68, 68);
            System.Drawing.Color accentOrange = System.Drawing.Color.FromArgb(249, 115, 22);
            System.Drawing.Color textWhite = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color textGray = System.Drawing.Color.FromArgb(148, 163, 184);
            System.Drawing.Color textMuted = System.Drawing.Color.FromArgb(100, 116, 139);
            System.Drawing.Color border = System.Drawing.Color.FromArgb(71, 85, 105);

            System.Drawing.Font fontLogo = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontLogoSub = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fontNav = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontNavActive = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontTitle = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontSubtitle = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontCardIcon = new System.Drawing.Font("Segoe UI", 20F);
            System.Drawing.Font fontCardTitle = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fontCardValue = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontFormTitle = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontLabel = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontButton = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontGrid = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fontVersion = new System.Drawing.Font("Segoe UI", 8F);

            this.bindingSourceProducts = new System.Windows.Forms.BindingSource(this.components);

            // ===== SIDEBAR =====
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelLogoSub = new System.Windows.Forms.Label();
            this.panelNavDashboard = new RoundedPanel();
            this.lblNavDashboard = new System.Windows.Forms.Label();
            this.panelNavProducts = new RoundedPanel();
            this.lblNavProducts = new System.Windows.Forms.Label();
            this.panelNavCategories = new RoundedPanel();
            this.lblNavCategories = new System.Windows.Forms.Label();
            this.panelNavReports = new RoundedPanel();
            this.lblNavReports = new System.Windows.Forms.Label();
            this.panelNavSettings = new RoundedPanel();
            this.lblNavSettings = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();

            this.panelSidebar.BackColor = bgSidebar;
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Width = 230;
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(12);

            this.labelLogo.Text = "DevNooTools";
            this.labelLogo.Font = fontLogo;
            this.labelLogo.ForeColor = textWhite;
            this.labelLogo.Location = new System.Drawing.Point(20, 28);
            this.labelLogo.AutoSize = true;

            this.labelLogoSub.Text = "Gestao de Produtos";
            this.labelLogoSub.Font = fontLogoSub;
            this.labelLogoSub.ForeColor = textMuted;
            this.labelLogoSub.Location = new System.Drawing.Point(22, 60);
            this.labelLogoSub.AutoSize = true;

            // Nav items
            int navY = 110;
            int navH = 44;
            int navGap = 8;

            this.panelNavDashboard.BackColor = System.Drawing.Color.Transparent;
            this.panelNavDashboard.Location = new System.Drawing.Point(12, navY);
            this.panelNavDashboard.Size = new System.Drawing.Size(206, navH);
            this.panelNavDashboard.Radius = 10;
            this.panelNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavDashboard.Text = "   Dashboard";
            this.lblNavDashboard.Font = fontNav;
            this.lblNavDashboard.ForeColor = textGray;
            this.lblNavDashboard.Location = new System.Drawing.Point(12, 12);
            this.lblNavDashboard.AutoSize = true;
            this.panelNavDashboard.Controls.Add(this.lblNavDashboard);

            navY += navH + navGap;
            this.panelNavProducts.BackColor = accent;
            this.panelNavProducts.Location = new System.Drawing.Point(12, navY);
            this.panelNavProducts.Size = new System.Drawing.Size(206, navH);
            this.panelNavProducts.Radius = 10;
            this.panelNavProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavProducts.Text = "   Produtos";
            this.lblNavProducts.Font = fontNavActive;
            this.lblNavProducts.ForeColor = textWhite;
            this.lblNavProducts.Location = new System.Drawing.Point(12, 12);
            this.lblNavProducts.AutoSize = true;
            this.panelNavProducts.Controls.Add(this.lblNavProducts);

            navY += navH + navGap;
            this.panelNavCategories.BackColor = System.Drawing.Color.Transparent;
            this.panelNavCategories.Location = new System.Drawing.Point(12, navY);
            this.panelNavCategories.Size = new System.Drawing.Size(206, navH);
            this.panelNavCategories.Radius = 10;
            this.panelNavCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavCategories.Text = "   Categorias";
            this.lblNavCategories.Font = fontNav;
            this.lblNavCategories.ForeColor = textGray;
            this.lblNavCategories.Location = new System.Drawing.Point(12, 12);
            this.lblNavCategories.AutoSize = true;
            this.panelNavCategories.Controls.Add(this.lblNavCategories);

            navY += navH + navGap;
            this.panelNavReports.BackColor = System.Drawing.Color.Transparent;
            this.panelNavReports.Location = new System.Drawing.Point(12, navY);
            this.panelNavReports.Size = new System.Drawing.Size(206, navH);
            this.panelNavReports.Radius = 10;
            this.panelNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavReports.Text = "   Relatorios";
            this.lblNavReports.Font = fontNav;
            this.lblNavReports.ForeColor = textGray;
            this.lblNavReports.Location = new System.Drawing.Point(12, 12);
            this.lblNavReports.AutoSize = true;
            this.panelNavReports.Controls.Add(this.lblNavReports);

            navY += navH + navGap;
            this.panelNavSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelNavSettings.Location = new System.Drawing.Point(12, navY);
            this.panelNavSettings.Size = new System.Drawing.Size(206, navH);
            this.panelNavSettings.Radius = 10;
            this.panelNavSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavSettings.Text = "   Configuracoes";
            this.lblNavSettings.Font = fontNav;
            this.lblNavSettings.ForeColor = textGray;
            this.lblNavSettings.Location = new System.Drawing.Point(12, 12);
            this.lblNavSettings.AutoSize = true;
            this.panelNavSettings.Controls.Add(this.lblNavSettings);

            this.labelVersion.Text = "v1.0.0";
            this.labelVersion.Font = fontVersion;
            this.labelVersion.ForeColor = textMuted;
            this.labelVersion.Location = new System.Drawing.Point(20, 670);
            this.labelVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
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
            this.panelMain.BackColor = bgDark;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Padding = new System.Windows.Forms.Padding(30, 24, 30, 24);

            // ===== HEADER =====
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.textSearch = new RoundedTextBox();
            this.btnExport = new RoundedButton();

            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 80;

            this.labelTitle.Text = "Produtos";
            this.labelTitle.Font = fontTitle;
            this.labelTitle.ForeColor = textWhite;
            this.labelTitle.Location = new System.Drawing.Point(0, 8);
            this.labelTitle.AutoSize = true;

            this.labelSubtitle.Text = "Gerencie seu inventario";
            this.labelSubtitle.Font = fontSubtitle;
            this.labelSubtitle.ForeColor = textMuted;
            this.labelSubtitle.Location = new System.Drawing.Point(2, 48);
            this.labelSubtitle.AutoSize = true;

            this.textSearch.Location = new System.Drawing.Point(420, 18);
            this.textSearch.Size = new System.Drawing.Size(280, 42);
            this.textSearch.BackColor = bgInput;
            this.textSearch.ForeColor = textWhite;
            this.textSearch.Text = "Buscar produtos...";
            this.textSearch.BorderColor = border;
            this.textSearch.FocusBorderColor = accent;
            this.textSearch.Radius = 12;
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
            this.textSearch.Leave += new System.EventHandler(this.textSearch_Leave);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);

            this.btnExport.Location = new System.Drawing.Point(720, 18);
            this.btnExport.Size = new System.Drawing.Size(120, 42);
            this.btnExport.Text = "Exportar";
            this.btnExport.Font = fontButton;
            this.btnExport.ForeColor = textWhite;
            this.btnExport.BackColor = accent;
            this.btnExport.HoverColor = accentLight;
            this.btnExport.Radius = 12;
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.labelSubtitle);
            this.panelHeader.Controls.Add(this.textSearch);
            this.panelHeader.Controls.Add(this.btnExport);

            // ===== CARDS =====
            this.panelCards = new System.Windows.Forms.Panel();
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

            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCards.Height = 120;
            this.panelCards.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);

            int cardW = 190;
            int cardH = 100;
            int cardGap = 20;

            // Card Total
            this.cardTotal.BackColor = bgCard;
            this.cardTotal.Location = new System.Drawing.Point(0, 0);
            this.cardTotal.Size = new System.Drawing.Size(cardW, cardH);
            this.cardTotal.Radius = 16;
            this.cardTotal.BorderColor = border;
            this.cardTotal.BorderSize = 1;

            this.labelCardTotalIcon.Text = "#";
            this.labelCardTotalIcon.Font = fontCardIcon;
            this.labelCardTotalIcon.ForeColor = accent;
            this.labelCardTotalIcon.Location = new System.Drawing.Point(16, 16);
            this.labelCardTotalIcon.AutoSize = true;

            this.labelCardTotalTitle.Text = "Total Produtos";
            this.labelCardTotalTitle.Font = fontCardTitle;
            this.labelCardTotalTitle.ForeColor = textGray;
            this.labelCardTotalTitle.Location = new System.Drawing.Point(50, 22);
            this.labelCardTotalTitle.AutoSize = true;

            this.labelCardTotalValue.Text = "0";
            this.labelCardTotalValue.Font = fontCardValue;
            this.labelCardTotalValue.ForeColor = accent;
            this.labelCardTotalValue.Location = new System.Drawing.Point(16, 52);
            this.labelCardTotalValue.AutoSize = true;

            this.cardTotal.Controls.Add(this.labelCardTotalIcon);
            this.cardTotal.Controls.Add(this.labelCardTotalTitle);
            this.cardTotal.Controls.Add(this.labelCardTotalValue);

            // Card Value
            this.cardValue.BackColor = bgCard;
            this.cardValue.Location = new System.Drawing.Point(cardW + cardGap, 0);
            this.cardValue.Size = new System.Drawing.Size(cardW, cardH);
            this.cardValue.Radius = 16;
            this.cardValue.BorderColor = border;
            this.cardValue.BorderSize = 1;

            this.labelCardValueIcon.Text = "E";
            this.labelCardValueIcon.Font = fontCardIcon;
            this.labelCardValueIcon.ForeColor = accentGreen;
            this.labelCardValueIcon.Location = new System.Drawing.Point(16, 16);
            this.labelCardValueIcon.AutoSize = true;

            this.labelCardValueTitle.Text = "Valor Estoque";
            this.labelCardValueTitle.Font = fontCardTitle;
            this.labelCardValueTitle.ForeColor = textGray;
            this.labelCardValueTitle.Location = new System.Drawing.Point(50, 22);
            this.labelCardValueTitle.AutoSize = true;

            this.labelCardValueValue.Text = "0,00 EUR";
            this.labelCardValueValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelCardValueValue.ForeColor = accentGreen;
            this.labelCardValueValue.Location = new System.Drawing.Point(16, 52);
            this.labelCardValueValue.AutoSize = true;

            this.cardValue.Controls.Add(this.labelCardValueIcon);
            this.cardValue.Controls.Add(this.labelCardValueTitle);
            this.cardValue.Controls.Add(this.labelCardValueValue);

            // Card Low Stock
            this.cardLowStock.BackColor = bgCard;
            this.cardLowStock.Location = new System.Drawing.Point((cardW + cardGap) * 2, 0);
            this.cardLowStock.Size = new System.Drawing.Size(cardW, cardH);
            this.cardLowStock.Radius = 16;
            this.cardLowStock.BorderColor = border;
            this.cardLowStock.BorderSize = 1;

            this.labelCardLowStockIcon.Text = "!";
            this.labelCardLowStockIcon.Font = fontCardIcon;
            this.labelCardLowStockIcon.ForeColor = accentOrange;
            this.labelCardLowStockIcon.Location = new System.Drawing.Point(16, 16);
            this.labelCardLowStockIcon.AutoSize = true;

            this.labelCardLowStockTitle.Text = "Estoque Baixo";
            this.labelCardLowStockTitle.Font = fontCardTitle;
            this.labelCardLowStockTitle.ForeColor = textGray;
            this.labelCardLowStockTitle.Location = new System.Drawing.Point(50, 22);
            this.labelCardLowStockTitle.AutoSize = true;

            this.labelCardLowStockValue.Text = "0";
            this.labelCardLowStockValue.Font = fontCardValue;
            this.labelCardLowStockValue.ForeColor = accentOrange;
            this.labelCardLowStockValue.Location = new System.Drawing.Point(16, 52);
            this.labelCardLowStockValue.AutoSize = true;

            this.cardLowStock.Controls.Add(this.labelCardLowStockIcon);
            this.cardLowStock.Controls.Add(this.labelCardLowStockTitle);
            this.cardLowStock.Controls.Add(this.labelCardLowStockValue);

            // Card Categories
            this.cardCategories.BackColor = bgCard;
            this.cardCategories.Location = new System.Drawing.Point((cardW + cardGap) * 3, 0);
            this.cardCategories.Size = new System.Drawing.Size(cardW, cardH);
            this.cardCategories.Radius = 16;
            this.cardCategories.BorderColor = border;
            this.cardCategories.BorderSize = 1;

            this.labelCardCategoriesIcon.Text = "C";
            this.labelCardCategoriesIcon.Font = fontCardIcon;
            this.labelCardCategoriesIcon.ForeColor = accentLight;
            this.labelCardCategoriesIcon.Location = new System.Drawing.Point(16, 16);
            this.labelCardCategoriesIcon.AutoSize = true;

            this.labelCardCategoriesTitle.Text = "Categorias";
            this.labelCardCategoriesTitle.Font = fontCardTitle;
            this.labelCardCategoriesTitle.ForeColor = textGray;
            this.labelCardCategoriesTitle.Location = new System.Drawing.Point(50, 22);
            this.labelCardCategoriesTitle.AutoSize = true;

            this.labelCardCategoriesValue.Text = "0";
            this.labelCardCategoriesValue.Font = fontCardValue;
            this.labelCardCategoriesValue.ForeColor = accentLight;
            this.labelCardCategoriesValue.Location = new System.Drawing.Point(16, 52);
            this.labelCardCategoriesValue.AutoSize = true;

            this.cardCategories.Controls.Add(this.labelCardCategoriesIcon);
            this.cardCategories.Controls.Add(this.labelCardCategoriesTitle);
            this.cardCategories.Controls.Add(this.labelCardCategoriesValue);

            this.panelCards.Controls.Add(this.cardTotal);
            this.panelCards.Controls.Add(this.cardValue);
            this.panelCards.Controls.Add(this.cardLowStock);
            this.panelCards.Controls.Add(this.cardCategories);

            // ===== FORM PANEL =====
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

            this.panelForm.BackColor = bgCard;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Height = 180;
            this.panelForm.Radius = 16;
            this.panelForm.BorderColor = border;
            this.panelForm.BorderSize = 1;
            this.panelForm.Padding = new System.Windows.Forms.Padding(24);

            this.labelFormTitle.Text = "Adicionar / Editar Produto";
            this.labelFormTitle.Font = fontFormTitle;
            this.labelFormTitle.ForeColor = textWhite;
            this.labelFormTitle.Location = new System.Drawing.Point(24, 20);
            this.labelFormTitle.AutoSize = true;

            this.lblName.Text = "NOME";
            this.lblName.Font = fontLabel;
            this.lblName.ForeColor = textGray;
            this.lblName.Location = new System.Drawing.Point(24, 55);
            this.lblName.AutoSize = true;

            this.textName.Location = new System.Drawing.Point(24, 75);
            this.textName.Size = new System.Drawing.Size(170, 42);
            this.textName.BackColor = bgInput;
            this.textName.ForeColor = textWhite;
            this.textName.BorderColor = border;
            this.textName.FocusBorderColor = accent;
            this.textName.Radius = 10;

            this.lblDescription.Text = "DESCRICAO";
            this.lblDescription.Font = fontLabel;
            this.lblDescription.ForeColor = textGray;
            this.lblDescription.Location = new System.Drawing.Point(210, 55);
            this.lblDescription.AutoSize = true;

            this.textDescription.Location = new System.Drawing.Point(210, 75);
            this.textDescription.Size = new System.Drawing.Size(220, 42);
            this.textDescription.BackColor = bgInput;
            this.textDescription.ForeColor = textWhite;
            this.textDescription.BorderColor = border;
            this.textDescription.FocusBorderColor = accent;
            this.textDescription.Radius = 10;

            this.lblPrice.Text = "PRECO (EUR)";
            this.lblPrice.Font = fontLabel;
            this.lblPrice.ForeColor = textGray;
            this.lblPrice.Location = new System.Drawing.Point(446, 55);
            this.lblPrice.AutoSize = true;

            this.textPrice.Location = new System.Drawing.Point(446, 75);
            this.textPrice.Size = new System.Drawing.Size(120, 42);
            this.textPrice.BackColor = bgInput;
            this.textPrice.ForeColor = textWhite;
            this.textPrice.BorderColor = border;
            this.textPrice.FocusBorderColor = accent;
            this.textPrice.Radius = 10;
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.lblQuantity.Text = "QTD";
            this.lblQuantity.Font = fontLabel;
            this.lblQuantity.ForeColor = textGray;
            this.lblQuantity.Location = new System.Drawing.Point(582, 55);
            this.lblQuantity.AutoSize = true;

            this.textQuantity.Location = new System.Drawing.Point(582, 75);
            this.textQuantity.Size = new System.Drawing.Size(80, 42);
            this.textQuantity.BackColor = bgInput;
            this.textQuantity.ForeColor = textWhite;
            this.textQuantity.BorderColor = border;
            this.textQuantity.FocusBorderColor = accent;
            this.textQuantity.Radius = 10;
            this.textQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Location = new System.Drawing.Point(24, 128);
            this.panelButtons.Size = new System.Drawing.Size(640, 44);

            this.btnAdd.Text = "+ Adicionar";
            this.btnAdd.Font = fontButton;
            this.btnAdd.ForeColor = textWhite;
            this.btnAdd.BackColor = accentGreen;
            this.btnAdd.HoverColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Size = new System.Drawing.Size(120, 42);
            this.btnAdd.Radius = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.Text = "Salvar";
            this.btnSave.Font = fontButton;
            this.btnSave.ForeColor = textWhite;
            this.btnSave.BackColor = accent;
            this.btnSave.HoverColor = accentLight;
            this.btnSave.Location = new System.Drawing.Point(130, 0);
            this.btnSave.Size = new System.Drawing.Size(110, 42);
            this.btnSave.Radius = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDelete.Text = "Excluir";
            this.btnDelete.Font = fontButton;
            this.btnDelete.ForeColor = textWhite;
            this.btnDelete.BackColor = accentRed;
            this.btnDelete.HoverColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDelete.Location = new System.Drawing.Point(250, 0);
            this.btnDelete.Size = new System.Drawing.Size(110, 42);
            this.btnDelete.Radius = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Limpar";
            this.btnClear.Font = fontButton;
            this.btnClear.ForeColor = textWhite;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnClear.HoverColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnClear.Location = new System.Drawing.Point(370, 0);
            this.btnClear.Size = new System.Drawing.Size(110, 42);
            this.btnClear.Radius = 10;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnClear);

            this.panelForm.Controls.Add(this.labelFormTitle);
            this.panelForm.Controls.Add(this.lblName);
            this.panelForm.Controls.Add(this.textName);
            this.panelForm.Controls.Add(this.lblDescription);
            this.panelForm.Controls.Add(this.textDescription);
            this.panelForm.Controls.Add(this.lblPrice);
            this.panelForm.Controls.Add(this.textPrice);
            this.panelForm.Controls.Add(this.lblQuantity);
            this.panelForm.Controls.Add(this.textQuantity);
            this.panelForm.Controls.Add(this.panelButtons);

            // ===== GRID PANEL =====
            this.panelGrid = new RoundedPanel();
            this.labelGridTitle = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();

            this.panelGrid.BackColor = bgCard;
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Radius = 16;
            this.panelGrid.BorderColor = border;
            this.panelGrid.BorderSize = 1;
            this.panelGrid.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);

            this.labelGridTitle.Text = "Lista de Produtos";
            this.labelGridTitle.Font = fontFormTitle;
            this.labelGridTitle.ForeColor = textWhite;
            this.labelGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGridTitle.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.labelGridTitle.Height = 40;

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
            this.dataGridViewProducts.GridColor = border;
            this.dataGridViewProducts.DefaultCellStyle.BackColor = bgCard;
            this.dataGridViewProducts.DefaultCellStyle.ForeColor = textWhite;
            this.dataGridViewProducts.DefaultCellStyle.SelectionBackColor = accent;
            this.dataGridViewProducts.DefaultCellStyle.SelectionForeColor = textWhite;
            this.dataGridViewProducts.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = bgSidebar;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = textGray;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.ColumnHeadersHeight = 50;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProducts.RowTemplate.Height = 50;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);

            this.panelGrid.Controls.Add(this.dataGridViewProducts);
            this.panelGrid.Controls.Add(this.labelGridTitle);

            // ===== SPACER PANELS =====
            var spacer1 = new System.Windows.Forms.Panel { Height = 20, Dock = System.Windows.Forms.DockStyle.Top, BackColor = System.Drawing.Color.Transparent };
            var spacer2 = new System.Windows.Forms.Panel { Height = 20, Dock = System.Windows.Forms.DockStyle.Top, BackColor = System.Drawing.Color.Transparent };

            // ===== ASSEMBLY =====
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(spacer2);
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(spacer1);
            this.panelMain.Controls.Add(this.panelCards);
            this.panelMain.Controls.Add(this.panelHeader);

            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();

            // ===== FORM SETTINGS =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 720);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Text = "DevNooTools - Gestao de Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackColor = bgDark;

            this.ResumeLayout(false);
        }
    }
}
