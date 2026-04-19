using FormAppGyakorlas.Context;
using FormAppGyakorlas.Models;

namespace FormAppGyakorlas
{
    public partial class Form1 : Form
    {
        AppDatabase Database;
        public Form1()
        {
            Database = new AppDatabase();
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbExercies.Items.Clear();
            var selectedCategoryId = cbCategory.SelectedIndex;
            if (cbCategory.SelectedIndex != -1) //ha valami nincs kiválasztva akkor nem null, habem -1
            {
                foreach (var item in Database.Exercies)
                {
                    if (item.CategoryId == selectedCategoryId+1)//azért kell a +1 mert a kódban 0-tól indul az indexelés a adatbázisban pedig 1-tól
                    {
                        
                        lbExercies.Items.Add(item);
                    }

                }
            }
            else {                 
                MessageBox.Show("Please select a category.");
            }


        }
    }
}
