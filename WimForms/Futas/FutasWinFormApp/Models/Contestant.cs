using System;
using System.Collections.Generic;

namespace FutasWinFormApp.Models;

public partial class Contestant
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    public int Time { get; set; }

    public override string ToString()
    {
        return $"{Name} ({City}) - {Time} perc";
    }
}
