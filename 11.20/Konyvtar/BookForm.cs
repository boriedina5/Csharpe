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
    public partial class BookForm : Form
    {
        AppDatabase Database;
        public BookForm()
        {
            InitializeComponent();
            Database = new AppDatabase();
            ListBoxLoader(Database.Books.ToList());
        }
        public void ListBoxLoader(List<Book> books)
        {
            lbBooks.Items.Clear();
            foreach (Book book in books)
            {
                lbBooks.Items.Add(book);
            }
        }
        private void addBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAuthor.Text) && !string.IsNullOrEmpty(tbTitle.Text))
            {
                string title = tbTitle.Text;
                string author = tbAuthor.Text;
                string genre = tbGenre.Text;
                int year = (int)nReleasedYear.Value;

                Book newbook = new Book()
                {
                    Title = title,
                    Author = author,
                    Genre = genre,
                    PublishedYear = year
                };

                Database.Books.Add(newbook);
                Database.SaveChanges();
                ListBoxLoader(Database.Books.ToList());
            }


        }

        private void updateBTN_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tbAuthor.Text) && !string.IsNullOrEmpty(tbTitle.Text) && lbBooks.SelectedItem != null)
            {
                string title = tbTitle.Text;
                string author = tbAuthor.Text;
                string genre = tbGenre.Text;
                int year = (int)nReleasedYear.Value;

                int ind = lbBooks.SelectedIndex;

                //Példány frissítés
                Database.Books.ToList()[ind].Title = title;
                Database.Books.ToList()[ind].Author = author;
                Database.Books.ToList()[ind].Genre = genre;
                Database.Books.ToList()[ind].PublishedYear = year;

                Database.SaveChanges();
                ListBoxLoader(Database.Books.ToList());
            }

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem != null)
            {
                Book selected = lbBooks.SelectedItem as Book;
                Database.Books.Remove(selected);
                Database.SaveChanges();
                ListBoxLoader(Database.Books.ToList());
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string query = tbSearch.Text;
            string condition = cbSearch.SelectedItem.ToString();
            List<Book> result = new List<Book>();

            switch (condition)
            {
                case "Title":
                    result = Database.Books.Where(x => x.Title.Contains(query)).ToList();
                    break;
                case "Author":
                    result = Database.Books.Where(x => x.Author.Contains(query)).ToList();
                    break;
                case "Genre":
                    result = Database.Books.Where(x => x.Genre.Contains(query)).ToList();
                    break;
            }
            ListBoxLoader(result);
        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItems != null) { 
                //Visszatöltjük a mezőbe a kijelölt könyvek az adatait
                Book selected = lbBooks.SelectedItem as Book;
                tbAuthor.Text = selected.Author;
                tbTitle.Text = selected.Title;
                tbGenre.Text = selected.Genre;
                nReleasedYear.Value = (decimal)selected.PublishedYear;

            }
        }
    }
}
