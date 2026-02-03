using System;
using System.Collections.Generic;

namespace AchievementTracker.Models;

public partial class Goal
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int Points { get; set; }

    public bool IsDone { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Points}, {Description}";
    }
}
