using Konyvtar.Context;
using Konyvtar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konyvtar
{
    public partial class BorrowerForms : Form
    {
        AppDatabase Database;
        public BorrowerForms()
        {
            InitializeComponent();
            Database = new AppDatabase();
            ListBoxLoader(Database.Borrowers.ToList());
        }
        public void ListBoxLoader(List<Borrower> borrowers) { 
            lbBorrowers.Items.Clear();
            foreach (Borrower b in borrowers) { 
                lbBorrowers.Items.Add(b);
            }

        }
        private void addBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrEmpty(tbEmail.Text))
            {
                string email = tbEmail.Text;
                string name = tbName.Text;
                string phone = tbPhone.Text;

                Borrower newBorrower = new Borrower()
                {
                    Name = name,
                    Email = email,
                    Phone = phone,


                };
                Database.Borrowers.Add(newBorrower);
                Database.SaveChanges();
                ListBoxLoader(Database.Borrowers.ToList());
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrEmpty(tbEmail.Text))
            {
                string email = tbEmail.Text;
                string name = tbName.Text;
                string phone = tbPhone.Text;

                int ind = lbBorrowers.SelectedIndex;

                Database.Borrowers.ToList()[ind].Email = email;
                Database.Borrowers.ToList()[ind].Name = name;
                Database.Borrowers.ToList()[ind].Phone = phone;
               

                Database.SaveChanges();
                ListBoxLoader(Database.Borrowers.ToList());
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (lbBorrowers.SelectedItem != null)
            {
                Borrower selected = lbBorrowers.SelectedItem as Borrower;
                Database.Borrowers.Remove(selected);
                Database.SaveChanges();
                ListBoxLoader(Database.Borrowers.ToList());
            }
        }

        private void lbBorrowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBorrowers.SelectedItems != null)
            {
                //Visszatöltjük a mezőbe a kijelölt könyvek az adatait
                Borrower selected = lbBorrowers.SelectedItem as Borrower;
                tbEmail.Text = selected.Email;
                tbName.Text = selected.Name;
                tbPhone.Text = selected.Phone;

            }
        }
    }
}
