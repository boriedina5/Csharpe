using beolvFormApp.Context;
using beolvFormApp.Model;
using Microsoft.EntityFrameworkCore.Storage;
using System.Runtime.CompilerServices;

namespace beolvFormApp
{
    public partial class Form1 : Form
    {
        private AppDatabase Database;
        public Form1()
        {
            InitializeComponent();
            Database = new AppDatabase();
            string[] rows = File.ReadAllLines("adatok.txt");
            foreach (string row in rows.Skip(1)) {//első sor ugrása
                string[] s = row.Split(";");
                string name = s[0];
                int age = int.Parse(s[1]);
                string city = s[2];

                //Ne legyen többször
                bool exist = Database.People.Any(p => p.Name == name && p.Age == 18 && p.City == city);

                if (!exist) {
                    Person newPerson = new Person
                    {
                       Name = name,
                       Age = age,
                       City = city
                    };
                }

            }
            Database.SaveChanges();
            LoadListBox(Database.People.ToList());
        }

        private void LoadListBox(List<Person> people) { 
            listBox1.Items.Clear();
            foreach (var p in people) { 
                listBox1.Items.Add(p);
            }
        }
        

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            string city = textBox1.Text;
            var result = Database.People.Where(x => x.City == city).ToList();
            LoadListBox(result);
        }

        private void BTNOrder_Click(object sender, EventArgs e)
        {
            var sorted = Database.People.OrderBy(x => x.Name).ToList();
            LoadListBox(sorted);
        }
    }
}
