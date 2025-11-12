namespace _11._12._2._feladat
{
    public partial class Form1 : Form
    {
        List<BankAccount> Accounts;
        public Form1()
        {
            InitializeComponent();
            Accounts = new List<BankAccount>();
        }

        private void ListBoxLoader(List<BankAccount> a) { 
            lbAccounts.Items.Clear();
            foreach (var account in a) { 
                lbAccounts.Items.Add(account);
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            BankForm newForm = new BankForm();
            if (newForm.ShowDialog() == DialogResult.OK) {
                Accounts.Add(newForm.Account);
                ListBoxLoader(Accounts);
            }
        }

        private void depositBTN_Click(object sender, EventArgs e)
        {
            if (lbAccounts.SelectedItems != null) {
                double amout = (double)amountN.Value;
                Accounts[lbAccounts.SelectedIndex].Deposit(amout);
                ListBoxLoader(Accounts);
            }

            


        }

        private void withdrawBTN_Click(object sender, EventArgs e)
        {
            if (lbAccounts.SelectedItems != null)
            {
                double amout = (double)amountN.Value;
                Accounts[lbAccounts.SelectedIndex].Withdraw(amout);
                ListBoxLoader(Accounts);
            }
        }
    }
}
