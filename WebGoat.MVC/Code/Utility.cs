using System;
using System.Security.Cryptography;
using System.Text;
using EnhancedEncryption;

namespace WebGoat.MVC.Code
{
    public class Utility
    {
        #region Encryption Methods

        private static string _iv;
        public static string Encrypt(string stringToEncrypt)
        {
            string pp = MachineKeySettings.MachineKey;

            GBRandomNumberGenerator.Generator generator = new GBRandomNumberGenerator.Generator(16);
            _iv = generator.GeneratePassword();

            RijndaelEnhanced crypto = new RijndaelEnhanced(pp, _iv);
            return crypto.Encrypt(stringToEncrypt);
        }

        public static string Decrypt(string stringToDecrypt, string iv)
        {
            string pp = MachineKeySettings.MachineKey;

            RijndaelEnhanced crypto = new RijndaelEnhanced(pp, iv);
            return crypto.Decrypt(stringToDecrypt);
        }

        public static string GetIV()
        {
            return _iv;
        } 
        #endregion

        #region Common Methods

        public static string MaskCreditCardNumber(string ccNumber)
        {
            string stars = "****";
            string firstTwo = ccNumber.Substring(0, 2);
            string lastFour = ccNumber.Substring(ccNumber.Length - 4, 4);

            return string.Concat(firstTwo, stars, lastFour);
        }

        #endregion
    }
}