using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paaswordhash
{
    public static class LoginHelper
    {
        //Jelszó validátor
        public static string HashPassword(string password) { 
            return BCrypt.Net.BCrypt.HasPassword(password)
        }
        public static bool VerifyPassword(string password, string hashedPassword) {
            return BCrypt.Net.BCrypt.HasPassword(password, hashedPassword)
        }
        //Emiali validátor
        public static bool EmailValidator(string email) { 
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            return Regex.IsMatch(email, pattern) //A megadott emial megfelel-e a mintának
        }
    }
}

