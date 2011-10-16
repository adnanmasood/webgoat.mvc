using System.IO;
using System.Security.Cryptography;
using System.Text;
using System;

namespace WebGoat.MVC.Code
{
    public class Encryption
    {
        private static string _salt = null;
        private static byte[] _key;
        private static byte[] _iv;
        private static byte[] saltBytes;
        private static SymmetricAlgorithm algorithm;

        private static void GetKeyAndIVFromPasswordAndSalt(string password, byte[] salt,
            SymmetricAlgorithm symmetricAlgorithm, ref byte[] key, ref byte[] iv)
        {
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt);
            key = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.KeySize / 8);
            iv = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.BlockSize / 8);
        }

        public static byte[] Encrypt(string clearText)
        {
            Prepare();

            var clearTextBytes = Encoding.Default.GetBytes(clearText);
            var rijndael = new RijndaelManaged();
            var transform = rijndael.CreateEncryptor(_key, _iv);
            var outputStream = new MemoryStream();
            var inputStream = new CryptoStream(outputStream, transform,
              CryptoStreamMode.Write);
            inputStream.Write(clearTextBytes, 0, clearText.Length);
            inputStream.FlushFinalBlock();
            return outputStream.ToArray();
        }

        public static string Decrypt(byte[] cipherText, byte[] iv)
        {
            //Prepare();

            var rijndael = new RijndaelManaged();
            var transform = rijndael.CreateDecryptor(_key, iv);
            var outputStream = new MemoryStream();
            var inputStream = new CryptoStream(outputStream, transform,
              CryptoStreamMode.Write);
            inputStream.Write(cipherText, 0, cipherText.Length);
            inputStream.FlushFinalBlock();
            var outputBytes = outputStream.ToArray();
            return Encoding.Default.GetString(outputBytes);
        }

        public static byte[] GetIV()
        {
            return _iv;
        }

        private static string CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        static void Prepare()
        {
            _key = new byte[16];
            _iv = new byte[16];
            
            saltBytes = Encoding.Default.GetBytes(CreateSalt(8));
            algorithm = SymmetricAlgorithm.Create("AES");

            GetKeyAndIVFromPasswordAndSalt(MachineKeySettings.MachineKey, saltBytes, algorithm, ref _key, ref _iv);
        }
    }
}