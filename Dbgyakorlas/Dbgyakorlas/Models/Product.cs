using System;
using System.Collections.Generic;

namespace Dbgyakorlas.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public override string ToString()
    {
        return $"{Name}, {Price:F1} Ft";//egy formátumkód, ahol az F a "Fixed-point" (fixpontos) megjelenítést jelenti, az 1-es szám pedig azt mondja meg, hogy pontosan 1 tizedesjegyre kerekítve jelenjen meg az érték.
    }
}
