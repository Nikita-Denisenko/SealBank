using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SealBank
{
    public static class PasswordHelper
    {
        public static (string Hash, string Salt) HashPassword(string password)
        {
            byte[] salt = new byte[16];
            RandomNumberGenerator.Fill(salt);

            byte[] pwdBytes = Encoding.UTF8.GetBytes(password);
            byte[] combined = new byte[salt.Length + pwdBytes.Length];
            Buffer.BlockCopy(salt, 0, combined, 0, salt.Length);
            Buffer.BlockCopy(pwdBytes, 0, combined, salt.Length, pwdBytes.Length);

            using var sha = SHA256.Create();
            byte[] hashBytes = sha.ComputeHash(combined);

            return (Convert.ToBase64String(hashBytes), Convert.ToBase64String(salt));
        }

        public static string ComputeHash(string password, string base64Salt)
        {
            byte[] salt = Convert.FromBase64String(base64Salt);

            byte[] pwdBytes = Encoding.UTF8.GetBytes(password);
            byte[] combined = new byte[salt.Length + pwdBytes.Length];
            Buffer.BlockCopy(salt, 0, combined, 0, salt.Length);
            Buffer.BlockCopy(pwdBytes, 0, combined, salt.Length, pwdBytes.Length);

            using var sha = SHA256.Create();
            byte[] hashBytes = sha.ComputeHash(combined);

            return Convert.ToBase64String(hashBytes);
        }

    }
}
