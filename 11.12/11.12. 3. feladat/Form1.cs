namespace _11._12._3._feladat
{
    public partial class Form1 : Form
    {
        List<Warehouse> Warehouses;
        public Form1()
        {
            InitializeComponent();
            Warehouses = new List<Warehouse>() {
                new Warehouse ("Budapest"),
                new Warehouse ("Miskolc"),
                new Warehouse ("Szombathely"),
                new Warehouse ("Sajóbábony"),
            };
            ListBoxLoader(Warehouses);
            
        }
        private void ListBoxLoader(List<Warehouse> warehouses)
        {
            WarhouseLB.Items.Clear();
            foreach (var w in warehouses) {
                WarhouseLB.Items.Add(w);
            }
        }
        private void addBTN_Click(object sender, EventArgs e)
        {
           
            ProductForm newForm = new ProductForm(Warehouses); //példány
            if (newForm.ShowDialog() == DialogResult.OK) {
                ListBoxLoader(Warehouses);
            }
        }

        private void modifyBTN_Click(object sender, EventArgs e)
        {

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if(ProductsLB.SelectedItems != null && WarhouseLB.SelectedItem != null)
            {
                int index = WarhouseLB.SelectedIndex;
                Product p = (Product)ProductsLB.SelectedItem;

                Warehouses[index].Products.Remove(p);
                ListBoxLoader(Warehouses);
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();

            if (WarhouseLB.SelectedItem != null) {
                List<Product> result = new List<Product>();
                int index = ProductsLB.SelectedIndex;

                result = Warehouses[index].Products
                    .Where(x => x.Name.Contains(searchTB.Text)).ToList();
                
                ProductsLB.Items.Clear();
                foreach (var item in result)
                {
                    ProductsLB.Items.Add(item);
                }
                
            }
            
        }

        private void WarhouseLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = WarhouseLB.SelectedIndex;
            ProductsLB.Items.Clear();
            foreach (var p in Warehouses[index].Products) {
                ProductsLB.Items.Add(p);
            }
        }
    }
}
