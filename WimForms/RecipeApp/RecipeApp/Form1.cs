using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RecipeApp.Context;
using RecipeApp.Models;

namespace RecipeApp
{
    
    public partial class Form1 : Form
    {
        AppDatabase Database; //meghívjuk az adatbázist
        public Form1()
        {
            InitializeComponent();
            Database = new AppDatabase();
            LoadAllData();
        }

        private void LoadAllData()
        {
            LoadIngredients();
            LoadPantry();
            LoadReceipes();
            RefreshRecommendations();
        }
        private void btnAddPantry_Click(object sender, EventArgs e)
        {
            Ingredient selected = cbIngredients.SelectedItem as Ingredient; //kiválasztott hozzávaló
            bool alreadyThere = Database.UserPantries.Any(up => up.IngredientId == selected.Id); //létezik-e már a kamrában
            if (alreadyThere) {

                MessageBox.Show("Ez már benne van a kamrában");
                return;
             }
            UserPantry pantryItem = new UserPantry() //új kamra elem
            {
                IngredientId = selected.Id
            };
            Database.UserPantries.Add(pantryItem); //hozzáadás az adatbázishoz
            Database.SaveChanges(); //mentés
            LoadPantry(); //frissítés
            RefreshRecommendations();
        }

        private void btnSaveIngredient_Click(object sender, EventArgs e)
        {
            string name = TbingredientName.Text; //kell tb
            Ingredient newIngredient = new Ingredient() //új hozzávaló
            {
                Name = name
            };
            Database.Ingredients.Add(newIngredient); //hozzáadás az adatbázishoz
            Database.SaveChanges(); //mentés
            LoadIngredients(); //frissítés
        }

        private void btnRemoveFromPantry_Click(object sender, EventArgs e)
        {
            UserPantry item = lbPantry.SelectedItem as UserPantry;
            var q = Database.UserPantries.Find(item);
            if (q != null)
            {
                Database.UserPantries.Remove(q);
                Database.SaveChanges();
                LoadPantry();
                RefreshRecommendations();
            }
        }

        private void btnAddReceipe_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshRecommendations_Click(object sender, EventArgs e)
        {
            RefreshRecommendations();
        }

        private class ReceipeRecommendation //segédosztály, mi kell egy ajáláshoz, csak itt érhetõ el
        {
            public int ReceipeId { get; set; }
            public string Name { get; set; }
            public int Difficulty { get; set; }
            public int TimeMinutes { get; set; }
            public int AvailableCount { get; set; }
                
        }

        private void LoadIngredients() { 
            lbIngredients.Items.Clear();
            foreach (var item in Database.Ingredients)
            {
                lbIngredients.Items.Add(item);
            }
            cbIngredients.DataSource = Database.Ingredients.ToList();   
        }
        private void LoadPantry()
        {
            lbPantry.Items.Clear();
            foreach (var item in Database.UserPantries)
            {
                lbPantry.Items.Add(item);
            }
        }
        private void LoadReceipes()
        {
            lbReceipes.Items.Clear();
            foreach (var item in Database.Recipes)
            {
                lbReceipes.Items.Add(item);
            }
        }
        private void RefreshRecommendations()
        {
            //kimentjük mik vannak a kamrában (csak az id-t), meg kell számolni melyik recepthez melyik hozzávaló van
             var pantryIds = Database.UserPantries.Select(up => up.IngredientId).ToList();//id kimentse
            var query = Database.Recipes
                .Include(r => r.RecipeIngredients).//receptekhez tartozó hozzávalók
                ThenInclude(ri => ri.Ingredient)//alapanyok önmagában
                .Select(r => new { //új adatszerkezetet csinálok: teljes recept minden adata + melyik recepthez mennyi hozzávaló van
                    Recipe = r, //csak a recept kell
                    AvailableCount = r.RecipeIngredients.Count(ri => pantryIds.Contains((int)ri.IngredientId)) //mennyi recept elérhetõ a hozzávalók alapján
                });
            var list = query.AsEnumerable().Select(x => new ReceipeRecommendation //recept ajánló
            {
                ReceipeId = x.Recipe.Id,
                Name = x.Recipe.Name,
                Difficulty = x.Recipe.Difficulty,
                TimeMinutes = x.Recipe.TimeMinutes,
                AvailableCount = x.AvailableCount
            }).ToList();
            list = list.OrderByDescending(x => x.AvailableCount).ThenBy(x => x.TimeMinutes).ThenBy(x => x.Difficulty).ToList();
            lbRecommendations.DataSource = list;
        }

    }
}
