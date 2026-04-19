using System;
using System.Collections.Generic;

namespace Trello.Model;

public partial class BoardColumn
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? BoardId { get; set; }

    public virtual Board? Board { get; set; }

    public virtual ICollection<BoardCard> BoardCards { get; set; } = new List<BoardCard>();
}
