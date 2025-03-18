using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PicasPiegadesSistema
{
    class Hashing
    {
        
        public static string GeneratePasswordHash(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] hashedBytes = HashAlgorithm.Create("SHA1").ComputeHash(bytes);

            return Convert.ToBase64String(hashedBytes);
        }
        public static bool CheckPasswordHash(string password, string hash) 
        {
            string passowrdHash = GeneratePasswordHash(password);
            return passowrdHash.Equals(hash);
        }
    }
}
