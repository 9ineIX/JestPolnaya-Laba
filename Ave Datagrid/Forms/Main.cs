using ProductManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ave_Datagrid
{
    public partial class Main : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public Main()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = db.LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);

            if (db.AddProduct(name, price, quantity))
            {
                MessageBox.Show("Продукт добавлен!");
                LoadProducts();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int id = (int)dgvProducts.SelectedRows[0].Cells["Id"].Value;

                if (db.DeleteProduct(id))
                {
                    MessageBox.Show("Продукт удален!");
                    LoadProducts();
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int id = (int)dgvProducts.SelectedRows[0].Cells["Id"].Value;
                string name = txtName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);

                if (db.UpdateProduct(id, name, price, quantity))
                {
                    MessageBox.Show("Продукт обновлен!");
                    LoadProducts();
                }
            }
        }
    }
}
