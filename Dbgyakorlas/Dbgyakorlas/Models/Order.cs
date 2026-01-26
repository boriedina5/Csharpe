using System;
using System.Collections.Generic;

namespace Dbgyakorlas.Models;

public partial class Order
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public DateTime OrderDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public override string ToString()
    {
        return $"{OrderDate.ToShortDateString()}, " + $"{Status}, {Customer.Name}";//etódus a dátumot egy rövidebb, tisztán szöveges formátummá alakítja, amely elhagyja az időt (óra, perc, másodperc), és csak az évet, hónapot és napot jeleníti meg.
    }
}
