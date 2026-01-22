using System;
using System.Collections.Generic;

namespace RecipeApp.Models;

public partial class Ingredient
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();

    public virtual ICollection<UserPantry> UserPantries { get; set; } = new List<UserPantry>();

    public override string ToString()
    {
        return $"{Name}";
        
    }
}
