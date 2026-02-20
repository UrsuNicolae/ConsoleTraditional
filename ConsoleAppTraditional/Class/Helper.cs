using System;
using System.Security.Cryptography;

namespace ConsoleAppTraditional.Class
{
    public static class Helper
    {
        public static string GenerareCodUnic(string prefix)
        {
            var random = new Random();
            return prefix + random.Next();
        }

        public static string GenerareCodUnicAdevarat(string prefix)
        {
            using RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            var randomNumber = new byte[4];
            rng.GetBytes(randomNumber);
            int randomInt = BitConverter.ToInt32(randomNumber, 0);
            return prefix + randomInt;
        }
    }
}
