using System;
using System.Security.Cryptography;
using System.Text;

namespace Chat.Api.HelpText;
public static class UuidVersao8
{
    public static Guid GenerateCustomUUID()
    {
        // Use SHA256 to create a hash from a unique string (e.g., timestamp + random number)
        using (SHA256 sha256 = SHA256.Create())
        {
            string uniqueString = DateTime.UtcNow.ToString("yyyyMMddHHmmssffff") + Guid.NewGuid().ToString();
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(uniqueString));
            byte[] truncatedHashBytes = new byte[16];
            Array.Copy(hashBytes, truncatedHashBytes, 16);
            return new Guid(truncatedHashBytes);
        }
    }
}