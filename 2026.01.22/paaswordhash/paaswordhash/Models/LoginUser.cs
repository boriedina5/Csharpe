using System;
using System.Collections.Generic;

namespace paaswordhash.Models;

public partial class LoginUser
{
    public int Id { get; set; }

    public string NickName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PasswordHash { get; set; }
}
