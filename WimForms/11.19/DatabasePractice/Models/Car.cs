using System;
using System.Collections.Generic;

namespace _DatabasePractice_.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public float Price { get; set; }

    public override string ToString()
    {
        return $"{Brand} - {Model}, {Year}, {Price} ft ";
    }
}
