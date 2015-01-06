using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using System.IO;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int Encrypt(string input)
        {


            byte[] bytes = Encoding.ASCII.GetBytes(input);
            int result = BitConverter.ToInt32(bytes, 0);
            return result;
        }


        public static string Decrypt(int result)
        {
            int i = result;
            byte[] bytes2 = BitConverter.GetBytes(i);
            string s2 = Encoding.ASCII.GetString(bytes2);
            return s2;

        }

        public static string getCelsius(Int32 f)
        {
            Double c = (f - 32) * 5 / 9;
            return Convert.ToString(c);
            // return Convert.ToInt32(c);
        }

        public static string EncryptPassword(string plainText)
        {
            // string EncryptionKey = keyGenerator();
            string encryptioNkey = "ABHWIK268HHJK78GB3";
            // string encryptioNkey = keyGenerator();
            byte[] plaintextInBytes = Encoding.Unicode.GetBytes(plainText);
            Aes aesObj = Aes.Create();

            Rfc2898DeriveBytes rfcObj = new Rfc2898DeriveBytes(encryptioNkey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            aesObj.Key = rfcObj.GetBytes(32);
            aesObj.IV = rfcObj.GetBytes(16);
            MemoryStream mstream = new MemoryStream();

            CryptoStream cryptostream = new CryptoStream(mstream, aesObj.CreateEncryptor(), CryptoStreamMode.Write);

            cryptostream.Write(plaintextInBytes, 0, plaintextInBytes.Length);
            cryptostream.Close();

            plainText = Convert.ToBase64String(mstream.ToArray());


            return plainText;
        }

        public static string DecryptPassword(string encyptedText)
        {

            string DecryptionKey = "ABHWIK268HHJK78GB3";
            // string DecryptionKey = keyGenerator();
            byte[] CcipherTextasBytes = Convert.FromBase64String(encyptedText);
            Aes aesObj = Aes.Create();

            Rfc2898DeriveBytes rfcObj = new Rfc2898DeriveBytes(DecryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            aesObj.Key = rfcObj.GetBytes(32);
            aesObj.IV = rfcObj.GetBytes(16);
            MemoryStream mstream = new MemoryStream();
            CryptoStream cryptostream = new CryptoStream(mstream, aesObj.CreateDecryptor(), CryptoStreamMode.Write);

            cryptostream.Write(CcipherTextasBytes, 0, CcipherTextasBytes.Length);
            cryptostream.Close();

            encyptedText = Encoding.Unicode.GetString(mstream.ToArray());


            return encyptedText;
        }




    }
    public class myMath
    {
        public static long abs(long x)
        {
            if (x >= 0) return (x); else return (-x);
        }
    }



}

