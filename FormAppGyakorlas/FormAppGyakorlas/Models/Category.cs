using System;
using System.Collections.Generic;

namespace FormAppGyakorlas.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Exercy> Exercies { get; set; } = new List<Exercy>();
}
