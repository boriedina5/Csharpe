using System;
using System.Collections.Generic;

namespace Dbgyakorlas.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>(); //navigation property - kapcsolatot biztosít az Order osztállyal    

    public override string ToString()
    {
        return $"{Name}, {Email}, {Phone}";
    }
}
