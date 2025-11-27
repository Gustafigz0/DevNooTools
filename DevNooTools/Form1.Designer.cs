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
        private System.Windows.Forms.Panel panelNavProducts;
        private System.Windows.Forms.Label labelNavProducts;

        // Main content
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.TextBox textSearch;

        // Stats cards
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel cardTotalProducts;
        private System.Windows.Forms.Label labelCardTotalTitle;
        private System.Windows.Forms.Label labelCardTotalValue;
        private System.Windows.Forms.Panel cardTotalValue;
        private System.Windows.Forms.Label labelCardValueTitle;
        private System.Windows.Forms.Label labelCardValueValue;
        private System.Windows.Forms.Panel cardLowStock;
        private System.Windows.Forms.Label labelCardLowStockTitle;
        private System.Windows.Forms.Label labelCardLowStockValue;

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
            // MODERN MINIMAL COLOR PALETTE
            // ============================================================
            System.Drawing.Color sidebarBg = System.Drawing.Color.FromArgb(17, 24, 39);
            System.Drawing.Color sidebarText = System.Drawing.Color.FromArgb(156, 163, 175);
            System.Drawing.Color sidebarActive = System.Drawing.Color.FromArgb(99, 102, 241);
            System.Drawing.Color mainBg = System.Drawing.Color.FromArgb(249, 250, 251);
            System.Drawing.Color cardBg = System.Drawing.Color.White;
            System.Drawing.Color textPrimary = System.Drawing.Color.FromArgb(17, 24, 39);
            System.Drawing.Color textSecondary = System.Drawing.Color.FromArgb(107, 114, 128);
            System.Drawing.Color accentBlue = System.Drawing.Color.FromArgb(59, 130, 246);
            System.Drawing.Color accentGreen = System.Drawing.Color.FromArgb(16, 185, 129);
            System.Drawing.Color accentRed = System.Drawing.Color.FromArgb(239, 68, 68);
            System.Drawing.Color accentYellow = System.Drawing.Color.FromArgb(245, 158, 11);
            System.Drawing.Color accentPurple = System.Drawing.Color.FromArgb(139, 92, 246);
            System.Drawing.Color borderLight = System.Drawing.Color.FromArgb(229, 231, 235);
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(243, 244, 246);

            // ============================================================
            // FONTS
            // ============================================================
            System.Drawing.Font fontLogo = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontNav = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontPageTitle = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontCardTitle = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fontCardValue = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontFormTitle = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontLabel = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fontInput = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontButton = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontGrid = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fontSearch = new System.Drawing.Font("Segoe UI", 10F);

            // ============================================================
            // INITIALIZE CONTROLS
            // ============================================================
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelNavProducts = new System.Windows.Forms.Panel();
            this.labelNavProducts = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.panelStats = new System.Windows.Forms.Panel();
            this.cardTotalProducts = new System.Windows.Forms.Panel();
            this.labelCardTotalTitle = new System.Windows.Forms.Label();
            this.labelCardTotalValue = new System.Windows.Forms.Label();
            this.cardTotalValue = new System.Windows.Forms.Panel();
            this.labelCardValueTitle = new System.Windows.Forms.Label();
            this.labelCardValueValue = new System.Windows.Forms.Label();
            this.cardLowStock = new System.Windows.Forms.Panel();
            this.labelCardLowStockTitle = new System.Windows.Forms.Label();
            this.labelCardLowStockValue = new System.Windows.Forms.Label();
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.bindingSourceProducts = new System.Windows.Forms.BindingSource(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            this.SuspendLayout();

            // ============================================================
            // SIDEBAR
            // ============================================================
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Width = 220;
            this.panelSidebar.BackColor = sidebarBg;
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(0);

            this.labelLogo.Text = "DevNooTools";
            this.labelLogo.Font = fontLogo;
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(20, 25);
            this.labelLogo.AutoSize = true;

            this.panelNavProducts.Location = new System.Drawing.Point(0, 80);
            this.panelNavProducts.Size = new System.Drawing.Size(220, 45);
            this.panelNavProducts.BackColor = sidebarActive;
            this.panelNavProducts.Cursor = System.Windows.Forms.Cursors.Hand;

            this.labelNavProducts.Text = "    Produtos";
            this.labelNavProducts.Font = fontNav;
            this.labelNavProducts.ForeColor = System.Drawing.Color.White;
            this.labelNavProducts.Location = new System.Drawing.Point(15, 12);
            this.labelNavProducts.AutoSize = true;

            this.panelNavProducts.Controls.Add(this.labelNavProducts);
            this.panelSidebar.Controls.Add(this.labelLogo);
            this.panelSidebar.Controls.Add(this.panelNavProducts);

            // ============================================================
            // MAIN PANEL
            // ============================================================
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.BackColor = mainBg;
            this.panelMain.Padding = new System.Windows.Forms.Padding(30);

            // ============================================================
            // HEADER
            // ============================================================
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 70;
            this.panelHeader.BackColor = mainBg;
            this.panelHeader.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);

            this.labelPageTitle.Text = "Produtos";
            this.labelPageTitle.Font = fontPageTitle;
            this.labelPageTitle.ForeColor = textPrimary;
            this.labelPageTitle.Location = new System.Drawing.Point(0, 15);
            this.labelPageTitle.AutoSize = true;

            this.textSearch.Location = new System.Drawing.Point(500, 15);
            this.textSearch.Size = new System.Drawing.Size(280, 35);
            this.textSearch.Font = fontSearch;
            this.textSearch.BackColor = inputBg;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSearch.ForeColor = textSecondary;
            this.textSearch.Text = "Buscar produtos...";
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
            this.textSearch.Leave += new System.EventHandler(this.textSearch_Leave);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);

            this.panelHeader.Controls.Add(this.labelPageTitle);
            this.panelHeader.Controls.Add(this.textSearch);

            // ============================================================
            // STATS CARDS
            // ============================================================
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Height = 110;
            this.panelStats.BackColor = mainBg;
            this.panelStats.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);

            this.cardTotalProducts.Location = new System.Drawing.Point(0, 0);
            this.cardTotalProducts.Size = new System.Drawing.Size(200, 90);
            this.cardTotalProducts.BackColor = cardBg;
            this.cardTotalProducts.Padding = new System.Windows.Forms.Padding(15);

            this.labelCardTotalTitle.Text = "Total de Produtos";
            this.labelCardTotalTitle.Font = fontCardTitle;
            this.labelCardTotalTitle.ForeColor = textSecondary;
            this.labelCardTotalTitle.Location = new System.Drawing.Point(15, 15);
            this.labelCardTotalTitle.AutoSize = true;

            this.labelCardTotalValue.Text = "0";
            this.labelCardTotalValue.Font = fontCardValue;
            this.labelCardTotalValue.ForeColor = accentBlue;
            this.labelCardTotalValue.Location = new System.Drawing.Point(15, 40);
            this.labelCardTotalValue.AutoSize = true;

            this.cardTotalProducts.Controls.Add(this.labelCardTotalTitle);
            this.cardTotalProducts.Controls.Add(this.labelCardTotalValue);

            this.cardTotalValue.Location = new System.Drawing.Point(220, 0);
            this.cardTotalValue.Size = new System.Drawing.Size(200, 90);
            this.cardTotalValue.BackColor = cardBg;
            this.cardTotalValue.Padding = new System.Windows.Forms.Padding(15);

            this.labelCardValueTitle.Text = "Valor em Estoque";
            this.labelCardValueTitle.Font = fontCardTitle;
            this.labelCardValueTitle.ForeColor = textSecondary;
            this.labelCardValueTitle.Location = new System.Drawing.Point(15, 15);
            this.labelCardValueTitle.AutoSize = true;

            this.labelCardValueValue.Text = "R$ 0,00";
            this.labelCardValueValue.Font = fontCardValue;
            this.labelCardValueValue.ForeColor = accentGreen;
            this.labelCardValueValue.Location = new System.Drawing.Point(15, 40);
            this.labelCardValueValue.AutoSize = true;

            this.cardTotalValue.Controls.Add(this.labelCardValueTitle);
            this.cardTotalValue.Controls.Add(this.labelCardValueValue);

            this.cardLowStock.Location = new System.Drawing.Point(440, 0);
            this.cardLowStock.Size = new System.Drawing.Size(200, 90);
            this.cardLowStock.BackColor = cardBg;
            this.cardLowStock.Padding = new System.Windows.Forms.Padding(15);

            this.labelCardLowStockTitle.Text = "Estoque Baixo";
            this.labelCardLowStockTitle.Font = fontCardTitle;
            this.labelCardLowStockTitle.ForeColor = textSecondary;
            this.labelCardLowStockTitle.Location = new System.Drawing.Point(15, 15);
            this.labelCardLowStockTitle.AutoSize = true;

            this.labelCardLowStockValue.Text = "0";
            this.labelCardLowStockValue.Font = fontCardValue;
            this.labelCardLowStockValue.ForeColor = accentYellow;
            this.labelCardLowStockValue.Location = new System.Drawing.Point(15, 40);
            this.labelCardLowStockValue.AutoSize = true;

            this.cardLowStock.Controls.Add(this.labelCardLowStockTitle);
            this.cardLowStock.Controls.Add(this.labelCardLowStockValue);

            this.panelStats.Controls.Add(this.cardTotalProducts);
            this.panelStats.Controls.Add(this.cardTotalValue);
            this.panelStats.Controls.Add(this.cardLowStock);

            // ============================================================
            // FORM PANEL
            // ============================================================
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Height = 160;
            this.panelForm.BackColor = cardBg;
            this.panelForm.Padding = new System.Windows.Forms.Padding(20);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);

            this.labelFormTitle.Text = "Adicionar / Editar Produto";
            this.labelFormTitle.Font = fontFormTitle;
            this.labelFormTitle.ForeColor = textPrimary;
            this.labelFormTitle.Location = new System.Drawing.Point(20, 15);
            this.labelFormTitle.AutoSize = true;

            this.labelName.Text = "Nome *";
            this.labelName.Font = fontLabel;
            this.labelName.ForeColor = textSecondary;
            this.labelName.Location = new System.Drawing.Point(20, 50);
            this.labelName.AutoSize = true;

            this.textName.Location = new System.Drawing.Point(20, 70);
            this.textName.Size = new System.Drawing.Size(180, 30);
            this.textName.Font = fontInput;
            this.textName.BackColor = inputBg;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.labelDescription.Text = "Descricao";
            this.labelDescription.Font = fontLabel;
            this.labelDescription.ForeColor = textSecondary;
            this.labelDescription.Location = new System.Drawing.Point(220, 50);
            this.labelDescription.AutoSize = true;

            this.textDescription.Location = new System.Drawing.Point(220, 70);
            this.textDescription.Size = new System.Drawing.Size(250, 30);
            this.textDescription.Font = fontInput;
            this.textDescription.BackColor = inputBg;
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.labelPrice.Text = "Preco (R$)";
            this.labelPrice.Font = fontLabel;
            this.labelPrice.ForeColor = textSecondary;
            this.labelPrice.Location = new System.Drawing.Point(490, 50);
            this.labelPrice.AutoSize = true;

            this.textPrice.Location = new System.Drawing.Point(490, 70);
            this.textPrice.Size = new System.Drawing.Size(100, 30);
            this.textPrice.Font = fontInput;
            this.textPrice.BackColor = inputBg;
            this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.labelQuantity.Text = "Qtd";
            this.labelQuantity.Font = fontLabel;
            this.labelQuantity.ForeColor = textSecondary;
            this.labelQuantity.Location = new System.Drawing.Point(610, 50);
            this.labelQuantity.AutoSize = true;

            this.textQuantity.Location = new System.Drawing.Point(610, 70);
            this.textQuantity.Size = new System.Drawing.Size(70, 30);
            this.textQuantity.Font = fontInput;
            this.textQuantity.BackColor = inputBg;
            this.textQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.panelFormButtons.Location = new System.Drawing.Point(20, 110);
            this.panelFormButtons.Size = new System.Drawing.Size(660, 40);
            this.panelFormButtons.BackColor = cardBg;

            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.Font = fontButton;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.BackColor = accentGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.Location = new System.Drawing.Point(110, 0);
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.Text = "Salvar";
            this.btnSave.Font = fontButton;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.BackColor = accentBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDelete.Location = new System.Drawing.Point(220, 0);
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.Text = "Excluir";
            this.btnDelete.Font = fontButton;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.BackColor = accentRed;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Location = new System.Drawing.Point(330, 0);
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.Text = "Limpar";
            this.btnClear.Font = fontButton;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(107, 114, 128);
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
            this.panelGrid.Padding = new System.Windows.Forms.Padding(0);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);

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
            this.dataGridViewProducts.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = textSecondary;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.ColumnHeadersHeight = 50;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProducts.RowTemplate.Height = 45;
            this.dataGridViewProducts.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);

            this.panelGrid.Controls.Add(this.dataGridViewProducts);

            // ============================================================
            // ASSEMBLE MAIN PANEL
            // ============================================================
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.panelStats);
            this.panelMain.Controls.Add(this.panelHeader);

            // ============================================================
            // FORM
            // ============================================================
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.BackColor = mainBg;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Text = "DevNooTools - Gerenciador de Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
