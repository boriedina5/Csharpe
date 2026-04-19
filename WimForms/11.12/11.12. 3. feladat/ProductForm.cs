using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._12._3._feladat
{
    public partial class ProductForm : Form
    {
        public Product Product;
        public List<Warehouse> Warehouse;
        public ProductForm(List<Warehouse> w)
        {
            InitializeComponent();
            Warehouse = w;

            WarehouseCB.DataSource = Warehouse;
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(productNameTB.Text) && WarehouseCB.SelectedItem != null) { 
                Warehouse selected = (Warehouse)WarehouseCB.SelectedItem;
                string productName = productNameTB.Text;
                double price = (double)priceN.Value;
                int quantity = (int)quantityN.Value;  
                
                Product newProduct = new Product(productName, price, quantity);

                selected.Products.Add(newProduct);

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
