using System;
using System.Collections.Generic;

namespace Konyvtar.Models;

public partial class Loan
{
    public int Id { get; set; }

    public int? BookId { get; set; }

    public int? BorrowId { get; set; }

    public DateTime LoanDate { get; set; }

    public DateTime? RetutnDate { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Borrower? Borrow { get; set; }

    public override string ToString()
    {
        return $"{Book.Title}, {Borrow.Name}, {LoanDate.ToShortDateString()} -  {RetutnDate}";
    }
}
