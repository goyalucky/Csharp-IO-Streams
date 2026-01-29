/* Encrypt and Decrypt CSV Data
● Encrypt the sensitive fields (e.g., Salary, Email) while writing to a CSV file.
● Decrypt them when reading the file. */


using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class CryptoHelper
{
    private static readonly string key = "ThisIsASecretKey"; 
    private static readonly string iv = "ThisIsAnInitVect"; 

    public static string Encrypt(string plainText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = Encoding.UTF8.GetBytes(iv);

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new())
            using (CryptoStream cs = new(ms, encryptor, CryptoStreamMode.Write))
            using (StreamWriter sw = new(cs))
            {
                sw.Write(plainText);
                sw.Close();
                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }

    public static string Decrypt(string cipherText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = Encoding.UTF8.GetBytes(iv);

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new(Convert.FromBase64String(cipherText)))
            using (CryptoStream cs = new(ms, decryptor, CryptoStreamMode.Read))
            using (StreamReader sr = new(cs))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
