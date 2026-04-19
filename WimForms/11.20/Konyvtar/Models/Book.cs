using System;
using System.Collections.Generic;

namespace Konyvtar.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string? Genre { get; set; }

    public int? PublishedYear { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
    public override string ToString()
    {
        return $"{Title} - {Author}, {Genre}, {PublishedYear}";
    }
}
