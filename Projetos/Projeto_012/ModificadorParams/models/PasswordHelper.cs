using System;
using System.Security.Cryptography;

namespace ModificadorParams
{
    // Classe auxiliar para hashing e verificação de senhas.
    // Usa PBKDF2 (Rfc2898DeriveBytes) com SHA-256.
    // Armazena a senha no formato: iterations:saltBase64:hashBase64
    // Observação: este código é didático — em produção revise parâmetros e considere Argon2.
    static class PasswordHelper
    {
        private const int SaltSize = 16; // bytes
        private const int HashSize = 32; // bytes (256 bits)
        private const int DefaultIterations = 100_000;

        // Gera hash no formato: iterations:salt:hash
        public static string HashPassword(string password, int iterations = DefaultIterations)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));

            using var rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[SaltSize];
            rng.GetBytes(salt);

            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            return iterations + ":" + Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        // Verifica se a senha informada confere com o hash armazenado
        public static bool VerifyPassword(string stored, string passwordToCheck)
        {
            if (string.IsNullOrEmpty(stored)) return false;
            if (passwordToCheck == null) return false;

            var parts = stored.Split(':');
            if (parts.Length != 3) return false;

            if (!int.TryParse(parts[0], out int iterations)) return false;
            byte[] salt;
            byte[] hash;

            try
            {
                salt = Convert.FromBase64String(parts[1]);
                hash = Convert.FromBase64String(parts[2]);
            }
            catch
            {
                return false;
            }

            using var pbkdf2 = new Rfc2898DeriveBytes(passwordToCheck, salt, iterations, HashAlgorithmName.SHA256);
            byte[] hashCheck = pbkdf2.GetBytes(hash.Length);

            return CryptographicOperations.FixedTimeEquals(hash, hashCheck);
        }
    }
}
