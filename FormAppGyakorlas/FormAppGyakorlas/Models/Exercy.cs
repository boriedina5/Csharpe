using System;
using System.Collections.Generic;

namespace FormAppGyakorlas.Models;

public partial class Exercy
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public override string ToString()
    {
        return Name;
    }
}
