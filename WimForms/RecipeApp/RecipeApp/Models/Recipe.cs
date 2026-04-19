using System;
using System.Collections.Generic;

namespace RecipeApp.Models;

public partial class Recipe
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Difficulty { get; set; }

    public int TimeMinutes { get; set; }

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
    public override string ToString()
    {
        return $"{Name}, idő: {TimeMinutes} perc, nehézség: {Difficulty}";

    }
}
