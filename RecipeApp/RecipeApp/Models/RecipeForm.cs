using RecipeApp.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeApp.Models
{
    public partial class RecipeForm : Form
    {
        AppDatabase Database;
        public RecipeForm()
        {
            InitializeComponent();
            Database = new AppDatabase();
            LoadIngredients();
        }
        private void LoadIngredients()
        {
            clbIngredients.Items.Clear();
            foreach (var item in Database.Ingredients)
            {
                clbIngredients.Items.Add(item);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string recipeName = name.Text;
            int diff = (int)NUDDifficulty.Value;
            int time = (int)NUDTime.Value;
            var newRecipe = new Recipe()
            {
                Name = recipeName,
                Difficulty = diff,
                TimeMinutes = time
            };
            Database.Recipes.Add(newRecipe);
            Database.SaveChanges();

            //hozzávalók hozzárendelése
            foreach (var selectedItem in clbIngredients.CheckedItems)
            {
                if (selectedItem is Ingredient ing) { 
                    var ri = new RecipeIngredient()
                    {
                        RecipeId = newRecipe.Id,
                        IngredientId = ing.Id
                    }; 
                }
            }
            Database.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();


        }
    }
}
