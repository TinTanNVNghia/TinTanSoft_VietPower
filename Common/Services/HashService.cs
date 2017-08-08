using System;
using System.Text;

namespace Common.Services
{
    public class HashService : IHashService
    {
        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

        public bool Compare(string inputPassword, string storedPasswordHashed)
        {
            var inputPasswordHashed = Hash(inputPassword);
            bool equal = false;
            if (inputPasswordHashed.Length == storedPasswordHashed.Length)
            {
                int i = 0;
                while ((i < inputPasswordHashed.Length) && (inputPasswordHashed[i] == storedPasswordHashed[i]))
                {
                    i += 1;
                }
                if (i == inputPasswordHashed.Length)
                {
                    equal = true;
                }
            }
            return equal;
        }
    }
}