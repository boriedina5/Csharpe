using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _11._12._2._feladat
{
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string Owner { get; private set; }
        public double Balance { get; private set; } //közvetlenül nem lehet beállítani -> osztály, így közvetet lesz
        public BankAccount(string an, string o, double b) { 
            AccountNumber = an;
            Owner = o;
            Balance = b;
        }
        public void Deposit(double amount) { 
            Balance += amount;
        }
        public void Withdraw(double amount) {
            if (Balance < amount)
            {
                MessageBox.Show("Nincs elég pénz a számlán");
            } else {
                Balance -= amount;
            }
        }
        public override string ToString()
        {
            return $"{AccountNumber} - {Owner}, {Balance} Ft";
        }

    }
}
