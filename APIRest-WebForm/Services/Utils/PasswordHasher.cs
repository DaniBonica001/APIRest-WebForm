using System.Security.Cryptography;
using System.Text;

namespace APIRest_WebForm.Services.Utils
{
    public class PasswordHasher
    {

        public static string ComputeHash(string password, int iteration)
        {

            if (iteration <= 0) return password;

            using var sha256 = SHA256.Create();
            string salt = GenerateSalt();
            string pepper = Environment.GetEnvironmentVariable("secret");
            
            var passwordSaltPepper = $"{password}{salt}{pepper}";
            var byteValue = Encoding.UTF8.GetBytes(passwordSaltPepper);
            var byteHash = sha256.ComputeHash(byteValue);
            var hash = Convert.ToBase64String(byteHash);
            return ComputeHash(hash,iteration - 1);
        }

        public static string GenerateSalt()
        {
            using var rng = RandomNumberGenerator.Create();
            var byteSalt = new byte[16];
            rng.GetBytes(byteSalt);
            var salt = Convert.ToBase64String(byteSalt);
            return salt;
        }
    }
}
