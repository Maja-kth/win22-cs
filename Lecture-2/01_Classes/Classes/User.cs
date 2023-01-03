using System.Security.Cryptography;
using System.Text;

namespace _01_Classes.Classes
{
    internal class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; private set; }
        public byte[] Salt { get; private set; }


        public void GenerateSecurePassword(string password)
        {
            using var hmac = new HMACSHA512();
            Salt = hmac.Key;
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public bool ValidatePassword(string password)
        {
            using var hmac = new HMACSHA512(Salt);
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            for (int i = 0; i < hash.Length; i++)
            {
                if (hash[i] != PasswordHash[i])
                    return false;    
            }

            return true;
        }
    }
}
