namespace _11._12._1._feladat
{
    public partial class Form1 : Form
    {
        List<Car> Cars;
        public Form1()
        {
            InitializeComponent();
            Cars = new List<Car>();
            //ListBoxLoader(Cars);
        }
        private void ListBoxLoader(List<Car> Cars)
        {
            ibCars.Items.Clear();
            foreach (Car car in Cars)
            {
                ibCars.Items.Add(car);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            CarForm newForm = new CarForm();
            if (newForm.ShowDialog() == DialogResult.OK) {
                Cars.Add(newForm.Car);
                ListBoxLoader(Cars);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (ibCars.SelectedItem != null) { 
                int index = ibCars.SelectedIndex;
                CarForm newForm = new CarForm(Cars[index]);

                if (newForm.ShowDialog() == DialogResult.OK)//newForm?
                {
                    ListBoxLoader(Cars);
                }
                
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (ibCars.SelectedItem != null) {
                int index = ibCars.SelectedIndex;
                Cars.RemoveAt(index);
                ListBoxLoader(Cars);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string condition = comboBox.SelectedItem.ToString();
            string query = textBox.Text;

            List<Car> result = new List<Car>();

            switch (condition) {
                case "Brand":
                    result = Cars.Where(x => x.Brand.Contains(query)).ToList();
                    break;
                case "Model":
                    result = Cars.Where(x => x.Model.Contains(query)).ToList();
                    break;
                case "Year":
                    if (int.TryParse(query, out int year)) { //Megpróbál átalalkítani, és kiköpi a az eredményt(out int - kiment)
                        result = Cars.Where(x => x.Year == year).ToList();
                    }
                    break;
            }
            ListBoxLoader(result);
        }
    }
}
