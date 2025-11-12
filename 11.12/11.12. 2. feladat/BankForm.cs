using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._12._2._feladat
{
    public partial class BankForm : Form
    {
        public BankAccount Account;
        public BankForm()
        {
            InitializeComponent();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(accountNumberTB.Text) && (!string.IsNullOrEmpty(ownerTB.Text))) { 
                string an = accountNumberTB.Text;
                string o = ownerTB.Text;
                double b = (double)balanceN.Value;

                Account = new BankAccount(an, o,  b);

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
