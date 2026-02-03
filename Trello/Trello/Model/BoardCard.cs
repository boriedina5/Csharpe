using System;
using System.Collections.Generic;

namespace Trello.Model;

public partial class BoardCard
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int? ColumnId { get; set; }

    public virtual BoardColumn? Column { get; set; }
}
