using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        string textOriginal = "pepsi";
        string clau = "12345678"; // 8 caràcters = 64 bits (requerit per DES)

        Console.WriteLine("Text original: " + textOriginal);

        string textXifrat = EncriptarDES(textOriginal, clau);
        Console.WriteLine("Text xifrat (Base64): " + textXifrat);

        string textDesxifrat = DesencriptarDES(textXifrat, clau);
        Console.WriteLine("Text desxifrat: " + textDesxifrat);
    }

    static string EncriptarDES(string textPla, string clau)
    {
        using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
        {
            des.Key = Encoding.UTF8.GetBytes(clau);
            des.IV = Encoding.UTF8.GetBytes(clau); // En aquest exemple, IV = clau (només per simplicitat)
            des.Mode = CipherMode.CBC;
            des.Padding = PaddingMode.PKCS7;

            byte[] bytesText = Encoding.UTF8.GetBytes(textPla);

            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cs.Write(bytesText, 0, bytesText.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }

    static string DesencriptarDES(string textXifratBase64, string clau)
    {
        using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
        {
            des.Key = Encoding.UTF8.GetBytes(clau);
            des.IV = Encoding.UTF8.GetBytes(clau);
            des.Mode = CipherMode.CBC;
            des.Padding = PaddingMode.PKCS7;

            byte[] bytesXifrats = Convert.FromBase64String(textXifratBase64);

            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cs.Write(bytesXifrats, 0, bytesXifrats.Length);
                cs.FlushFinalBlock();
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }
    }
}

