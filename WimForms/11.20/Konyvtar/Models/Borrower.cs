using System;
using System.Collections.Generic;

namespace Konyvtar.Models;

public partial class Borrower
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();

    public override string ToString()
    {
        return $"{Name} - {Email}, {Phone}";
    }
}
