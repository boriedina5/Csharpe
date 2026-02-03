using System;
using System.Collections.Generic;

namespace QuizzApp.Models;

public partial class Question
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public string AnswerA { get; set; } = null!;

    public string AnswerB { get; set; } = null!;

    public string AnswerC { get; set; } = null!;

    public string AnswerD { get; set; } = null!;

    public string CorrectAnswer { get; set; } = null!;
}
