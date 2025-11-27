namespace DevNooTools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.BindingSource bindingSourceProducts;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.bindingSourceProducts = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            this.SuspendLayout();

            // ============================================================
            // MODERN COLOR PALETTE
            // ============================================================
            System.Drawing.Color primaryColor = System.Drawing.Color.FromArgb(41, 128, 185);      // Blue
            System.Drawing.Color primaryDark = System.Drawing.Color.FromArgb(31, 97, 141);        // Darker Blue
            System.Drawing.Color successColor = System.Drawing.Color.FromArgb(39, 174, 96);       // Green
            System.Drawing.Color successDark = System.Drawing.Color.FromArgb(30, 132, 73);        // Darker Green
            System.Drawing.Color dangerColor = System.Drawing.Color.FromArgb(231, 76, 60);        // Red
            System.Drawing.Color dangerDark = System.Drawing.Color.FromArgb(176, 58, 46);         // Darker Red
            System.Drawing.Color warningColor = System.Drawing.Color.FromArgb(243, 156, 18);      // Orange
            System.Drawing.Color warningDark = System.Drawing.Color.FromArgb(185, 119, 14);       // Darker Orange
            System.Drawing.Color bgLight = System.Drawing.Color.FromArgb(248, 249, 250);          // Light Gray BG
            System.Drawing.Color bgDark = System.Drawing.Color.FromArgb(52, 73, 94);              // Dark Header
            System.Drawing.Color textLight = System.Drawing.Color.White;
            System.Drawing.Color textDark = System.Drawing.Color.FromArgb(44, 62, 80);
            System.Drawing.Color borderColor = System.Drawing.Color.FromArgb(189, 195, 199);

            // ============================================================
            // FONTS
            // ============================================================
            System.Drawing.Font fontTitle = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontLabel = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontInput = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fontButton = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontGrid = new System.Drawing.Font("Segoe UI", 9F);

            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 180;
            this.panelTop.Padding = new System.Windows.Forms.Padding(20);
            this.panelTop.BackColor = bgLight;

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Text = "📦 Gerenciador de Produtos";
            this.labelTitle.Font = fontTitle;
            this.labelTitle.ForeColor = textDark;

            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 55);
            this.labelName.Text = "NOME *";
            this.labelName.Font = fontLabel;
            this.labelName.ForeColor = textDark;

            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(20, 75);
            this.textName.Size = new System.Drawing.Size(220, 28);
            this.textName.Font = fontInput;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(260, 55);
            this.labelDescription.Text = "DESCRIÇÃO";
            this.labelDescription.Font = fontLabel;
            this.labelDescription.ForeColor = textDark;

            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(260, 75);
            this.textDescription.Size = new System.Drawing.Size(320, 28);
            this.textDescription.Font = fontInput;
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(600, 55);
            this.labelPrice.Text = "PREÇO (R$)";
            this.labelPrice.Font = fontLabel;
            this.labelPrice.ForeColor = textDark;

            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(600, 75);
            this.textPrice.Size = new System.Drawing.Size(100, 28);
            this.textPrice.Font = fontInput;
            this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(720, 55);
            this.labelQuantity.Text = "QTD";
            this.labelQuantity.Font = fontLabel;
            this.labelQuantity.ForeColor = textDark;

            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(720, 75);
            this.textQuantity.Size = new System.Drawing.Size(70, 28);
            this.textQuantity.Font = fontInput;
            this.textQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 120);
            this.btnAdd.Size = new System.Drawing.Size(110, 38);
            this.btnAdd.Text = "➕ Adicionar";
            this.btnAdd.Font = fontButton;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.BackColor = successColor;
            this.btnAdd.ForeColor = textLight;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 120);
            this.btnSave.Size = new System.Drawing.Size(100, 38);
            this.btnSave.Text = "💾 Salvar";
            this.btnSave.Font = fontButton;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.BackColor = primaryColor;
            this.btnSave.ForeColor = textLight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(250, 120);
            this.btnDelete.Size = new System.Drawing.Size(100, 38);
            this.btnDelete.Text = "🗑️ Excluir";
            this.btnDelete.Font = fontButton;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.BackColor = dangerColor;
            this.btnDelete.ForeColor = textLight;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(360, 120);
            this.btnClear.Size = new System.Drawing.Size(100, 38);
            this.btnClear.Text = "🔄 Limpar";
            this.btnClear.Font = fontButton;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.BackColor = warningColor;
            this.btnClear.ForeColor = textLight;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.Location = new System.Drawing.Point(20, 195);
            this.dataGridViewProducts.Size = new System.Drawing.Size(860, 320);
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
            this.dataGridViewProducts.GridColor = borderColor;
            this.dataGridViewProducts.DefaultCellStyle.SelectionBackColor = primaryColor;
            this.dataGridViewProducts.DefaultCellStyle.SelectionForeColor = textLight;
            this.dataGridViewProducts.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = bgDark;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = textLight;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = fontLabel;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(8);
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.ColumnHeadersHeight = 40;
            this.dataGridViewProducts.RowTemplate.Height = 35;
            this.dataGridViewProducts.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.BackColor = bgLight;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.panelTop);
            this.Text = "DevNooTools - Gerenciador de Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Add controls to panelTop
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.labelName);
            this.panelTop.Controls.Add(this.textName);
            this.panelTop.Controls.Add(this.labelDescription);
            this.panelTop.Controls.Add(this.textDescription);
            this.panelTop.Controls.Add(this.labelPrice);
            this.panelTop.Controls.Add(this.textPrice);
            this.panelTop.Controls.Add(this.labelQuantity);
            this.panelTop.Controls.Add(this.textQuantity);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.btnSave);
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnClear);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

