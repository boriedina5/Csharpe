using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._12._1._feladat
{
    public partial class CarForm : Form
    {
        public Car Car; //ezen keresztül lesz megvalósítva az adatátvitel a 2 formból
        public CarForm(Car car = null) //opcionális paraméter
        {
            InitializeComponent();
            if(car != null)//módosító állapot
            {
                addCars.Text = "Update";
                Car = car;
                brandTB.Text = Car.Brand;
                modelTB.Text = Car.Model;
                priceN.Value = (decimal)Car.Price;
                yearN.Value = Car.Year;

            }
        }

        private void addCars_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(brandTB.Text) && !string.IsNullOrEmpty(modelTB.Text)) { 
                string brand = brandTB.Text;
                string model = modelTB.Text;
                int year = (int)yearN.Value;
                double price = (double)priceN.Value;

                if (Car == null)//ilyenkor hozzáadunk, hiszen üres még == nincs mit módosítani
                {
                    Car = new Car(brand, model, year, price);
                }
                else { //Átállítjuk a meglévő autónak az adattagjait
                    Car.Brand = brand;
                    Car.Model = model;
                    Car.Price = price;
                    Car.Year = year;
                }

                DialogResult = DialogResult.OK; //?
                Close();

            }
        }
    }
}
