using _DatabasePractice_.Context;
using _DatabasePractice_.Models;
using System.Runtime.InteropServices;

namespace _4._feladat___ez_már_kell_a_vizsgához
{
    public partial class Form1 : Form
    {
        AppDatabase Database;
        public Form1()
        {
            InitializeComponent();
            Database = new AppDatabase();
            ListBoxLoader(Database.Cars.ToList());//Car nevű tábla
        }
        public void ListBoxLoader(List<Car> cars) { 
            lbCars.Items.Clear();
            foreach (Car car in cars) {
                lbCars.Items.Add(car);
            }
        }

        private void lbCras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car selected = (Car)lbCars.SelectedItem;
            brandTB.Text = selected.Brand;
            modelTB.Text = selected.Model;
            yearN.Value = selected.Year;
            priceN.Value = (decimal)selected.Price;

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(brandTB.Text) && !string.IsNullOrEmpty(modelTB.Text)) { 
                string brand = brandTB.Text;
                string model = modelTB.Text;
                int year = (int)yearN.Value;
                float price = (float)priceN.Value;

                //nincs konstruktor -> explicit átadjuk
                Car newCar = new Car()
                {
                    Brand = brand,
                    Model = model,
                    Year = year,
                    Price = price,
                };
                Database.Cars.Add(newCar); //adatbázishoz hozzáadjuk
                Database.SaveChanges();//el is mentjük
                ListBoxLoader(Database.Cars.ToList()); //kiolvasuk az adatbázisból az autókat


            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (lbCars.SelectedItems != null && !string.IsNullOrEmpty(brandTB.Text) && !string.IsNullOrEmpty(modelTB.Text)) { 
                int id = lbCars.SelectedIndex;

                string brand = brandTB.Text;
                string model = modelTB.Text;
                int year = (int)yearN.Value;
                float price = (float)priceN.Value;

                Database.Cars.ToList()[id].Brand = brand;
                Database.Cars.ToList()[id].Model = model;
                Database.Cars.ToList()[id].Year = year;
                Database.Cars.ToList()[id].Price = price;
               
                Database.SaveChanges();
                ListBoxLoader(Database.Cars.ToList());

            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (lbCars.SelectedItems != null) {
                Car selected = (Car)lbCars.SelectedItem; //kokrét itemet kell átadni az adatbázisnak
                Database.Cars.Remove(selected);
                Database.SaveChanges();
                ListBoxLoader(Database.Cars.ToList());
            }
        }
    }
}
