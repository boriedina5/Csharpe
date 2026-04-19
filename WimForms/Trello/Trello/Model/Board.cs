using System;
using System.Collections.Generic;

namespace Trello.Model;

public partial class Board
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<BoardColumn> BoardColumns { get; set; } = new List<BoardColumn>();
}
