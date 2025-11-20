using Konyvtar.Context;
using Konyvtar.Models;

namespace Konyvtar
{
    public partial class Form1 : Form
    {
        AppDatabase Database;
        public Form1()
        {
            InitializeComponent();
            Database = new AppDatabase();
            ListBoxLoader(Database.Loans.ToList());
            ComboboxLoader();
        }
        public void ComboboxLoader() { 
            cbBooks.DataSource = Database.Books.ToList();
            cbBorrower.DataSource = Database.Borrowers.ToList();
         }
        public void ListBoxLoader(List<Loan> loans) { 
            lbLoans.Items.Clear();
            foreach (Loan loan in loans) { 
                lbLoans.Items.Add(loan);
            }
        }

        private void booksBTN_Click(object sender, EventArgs e)
        {
            BookForm newForm = new BookForm();
#pragma warning disable WFO5002
            await newForm.ShowAsync();
#pragma warning disable WFO5002
            ComboboxLoader();

        }

        private void borrowersBTN_Click(object sender, EventArgs e)
        {

            BorrowerForms newForm = new BorrowerForms();
#pragma warning disable WFO5002
            await newForm.ShowAsync();
#pragma warning disable WFO5002
            ComboboxLoader();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            Book book = cbBooks.SelectedItem as Book;
            Borrower borrower = cbBorrower.SelectedItem as Borrower;
            DateTime date = dateTimePicker.Value;
            Loan newloan = new Loan
            {
                Book = book,
                BookId = book.Id,
                Borrow = borrower,
                BorrowId = borrower.Id,
                LoanDate = date,
            };
            Database.Add(newloan);
            Database.SaveChanges();
            ListBoxLoader(Database.Loans.ToList());


        }
    }
}
