using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OCSSCESu.helper
{
    public static class  PasswordHasher
    {
        // Configuration - adjust these values as needed
        private const int SaltSize = 16; // 128 bits
        private const int HashSize = 32; // 256 bits
        private const int Iterations = 100000; // Minimum recommended iterations

        // Format: iterations:salt:hash
        private const string SegmentDelimiter = ":";
        private const int SaltPosition = 1;
        private const int HashPosition = 2;

        public static string Hash(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be empty");

            // Generate random salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            // Hash the password
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // Combine salt and hash with iteration count
            return string.Join(
                SegmentDelimiter,
                Iterations,
                Convert.ToBase64String(salt),
                Convert.ToBase64String(hash)
            );
        }

        public static bool Verify(string password, string hashedPassword)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(hashedPassword))
                    return false;

                var segments = hashedPassword.Split(SegmentDelimiter.ToCharArray());
                if (segments.Length != 3)
                    return false;

                if (!int.TryParse(segments[0], out int iterations))
                    return false;

                byte[] salt = Convert.FromBase64String(segments[SaltPosition]);
                byte[] originalHash = Convert.FromBase64String(segments[HashPosition]);

                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
                byte[] inputHash = pbkdf2.GetBytes(originalHash.Length);

                return SlowEquals(inputHash, originalHash);
            }
            catch
            {
                // If any error occurs during verification (format issues, etc.)
                return false;
            }
        }

        public static bool NeedsUpgrade(string hashedPassword)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(hashedPassword))
                    return true;

                var segments = hashedPassword.Split(SegmentDelimiter.ToCharArray());
                if (segments.Length != 3)
                    return true;

                if (!int.TryParse(segments[0], out int iterations))
                    return true;

                return iterations < Iterations;
            }
            catch
            {
                return true;
            }
        }

        // Compares two byte arrays in length-constant time
        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }
            return diff == 0;
        }
    }
}
