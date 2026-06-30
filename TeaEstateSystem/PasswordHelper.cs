using System.Security.Cryptography;
using System.Text;

namespace TeaEstateSystem
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            byte[] bytes =
                sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}