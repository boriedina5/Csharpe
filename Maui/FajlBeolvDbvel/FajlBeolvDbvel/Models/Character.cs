using System;
using System.Collections.Generic;

namespace FajlBeolvDbvel.Models;

public partial class Character
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Class { get; set; } = null!;

    public int Level { get; set; }
}
