using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SealBank.Logic
{
    public static class Validator
    {
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }

        public static bool EmailExists(string email, List<UserBase> users)
        {
            return users.Any(u => u.Email == email);
        }

        public static bool IsEmailAvailable(string email, List<UserBase> users)
        {
            return !EmailExists(email, users);
        }
    }
}
