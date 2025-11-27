using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevNooTools
{
    public partial class Form1 : Form
    {
        private ProductRepository repository;
        private BindingList<Product> products;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repository = new ProductRepository();
            var list = repository.LoadAll();
            products = new BindingList<Product>(list);
            bindingSourceProducts.DataSource = products;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Nome é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textPrice.Text, out var price)) price = 0m;
            if (!int.TryParse(textQuantity.Text, out var qty)) qty = 0;

            var p = new Product
            {
                Name = textName.Text.Trim(),
                Description = textDescription.Text.Trim(),
                Price = price,
                Quantity = qty
            };

            products.Add(p);
            repository.SaveAll(new List<Product>(products));
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bindingSourceProducts.Current is Product cur)
            {
                cur.Name = textName.Text.Trim();
                cur.Description = textDescription.Text.Trim();
                if (!decimal.TryParse(textPrice.Text, out var price)) price = 0m;
                if (!int.TryParse(textQuantity.Text, out var qty)) qty = 0;
                cur.Price = price;
                cur.Quantity = qty;
                bindingSourceProducts.ResetBindings(false);
                repository.SaveAll(new List<Product>(products));
                MessageBox.Show("Produto atualizado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSourceProducts.Current is Product cur)
            {
                var res = MessageBox.Show($"Excluir '{cur.Name}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    products.Remove(cur);
                    repository.SaveAll(new List<Product>(products));
                    ClearFields();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            dataGridViewProducts.ClearSelection();
        }

        private void ClearFields()
        {
            textName.Text = string.Empty;
            textDescription.Text = string.Empty;
            textPrice.Text = string.Empty;
            textQuantity.Text = string.Empty;
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (bindingSourceProducts.Current is Product cur)
            {
                textName.Text = cur.Name;
                textDescription.Text = cur.Description;
                textPrice.Text = cur.Price.ToString();
                textQuantity.Text = cur.Quantity.ToString();
            }
            else
            {
                ClearFields();
            }
        }
    }
}
