using System;
using System.Collections.Generic;

namespace beolvFormApp.Model;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string City { get; set; } = null!;

    public override string ToString()
    {
        return $"Név: {Name}, Kor: {Age} év, Város: {City}";
    }
}
