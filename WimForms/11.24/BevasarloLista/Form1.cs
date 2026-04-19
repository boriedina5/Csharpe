namespace BevasarloLista
{
    public partial class Main : Form
    {
        ShoppingItem newShoppingItem;
        List<ShoppingItem> shoppingItemsList;
        public Main()
        {
            InitializeComponent();
            shoppingItemsList = new List<ShoppingItem>();
            ListBoxShow(shoppingItemsList);
        }
        public void ListBoxShow(List<ShoppingItem> paramList)
        {
            lbShoppingList.Items.Clear();
            foreach (var item in paramList)
            {
                lbShoppingList.Items.Add(item);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbName.Text))
            {
                string name = tbName.Text;
                int quantity = (int)nudPrice.Value;
                double price = (double)nudPrice.Value;

                newShoppingItem = new ShoppingItem(name, quantity, price);
                shoppingItemsList.Add(newShoppingItem);
                ListBoxShow(shoppingItemsList);

                DialogResult = DialogResult.OK;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lbShoppingList.SelectedItem != null)
            {
                int index = lbShoppingList.SelectedIndex;

                shoppingItemsList[index].Name = tbName.Text;
                shoppingItemsList[index].Quantity = (int)nudQuantity.Value;
                shoppingItemsList[index].Price = (double)nudPrice.Value;

                ListBoxShow(shoppingItemsList); 
            }
        }

        private void lbShoppingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < shoppingItemsList.Count; i++) {
                sum += shoppingItemsList[i].Price * shoppingItemsList[i].Quantity;
            }
            lAmount.Text = $"The full amount: {sum.ToString()}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbShoppingList.SelectedItem != null)
            {
                int index = lbShoppingList.SelectedIndex;
                shoppingItemsList.Remove(shoppingItemsList[index]);
                ListBoxShow(shoppingItemsList);
            }
        }
    }
}
