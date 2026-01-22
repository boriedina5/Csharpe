using System;
using System.Collections.Generic;

namespace RecipeApp.Models;

public partial class UserPantry
{
    public int Id { get; set; }

    public int? IngredientId { get; set; }

    public virtual Ingredient? Ingredient { get; set; }

    public override string ToString()
    {
        return $"{Ingredient.Name}";

    }
}
