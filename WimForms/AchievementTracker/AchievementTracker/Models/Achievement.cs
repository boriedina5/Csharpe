using System;
using System.Collections.Generic;

namespace AchievementTracker.Models;

public partial class Achievement
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int RequiredPoints { get; set; }
    public override string ToString()
    {
        return Name;
    }
}
