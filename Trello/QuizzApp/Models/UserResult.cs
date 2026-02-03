using System;
using System.Collections.Generic;

namespace QuizzApp.Models;

public partial class UserResult
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int CorrectAnswers { get; set; }
}
