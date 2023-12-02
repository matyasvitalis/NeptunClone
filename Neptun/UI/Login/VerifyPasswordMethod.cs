using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NeptunClone.UI.Login
{
    public class VerifyPasswordMethod
    {
       static int keySize = 64;
       static int iterations = 350000;
       static HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

       public static bool VerifyPassword(string password, string hash, byte[] salt)
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgorithm, keySize);
            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }

    }
}
