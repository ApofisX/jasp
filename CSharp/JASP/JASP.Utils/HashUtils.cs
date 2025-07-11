using System.Security.Cryptography;

namespace JASP.Utils;

public class HashUtils
{
    public static string ComputeSha256(string filePath)
    {
        using SHA256 sha256 = SHA256.Create();
        using FileStream stream = File.OpenRead(filePath);
        byte[] hash = sha256.ComputeHash(stream);
        return Convert.ToHexString(hash);
    }
}
