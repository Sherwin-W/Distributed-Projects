using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WcfProject1
{
    public sealed class Cryption
    {
        byte[] seed = ASCIIEncoding.ASCII.GetBytes("cse44598");
        public string encrypt (string plainString)
        {
            if (String.IsNullOrEmpty(plainString))
            {
                throw new ArgumentNullException("The input string for encryption cannot be empty or null!");
            }
            SymmetricAlgorithm saProvider = DES.Create();
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, saProvider.CreateEncryptor(seed,seed), CryptoStreamMode.Write);
            StreamWriter sWriter = new StreamWriter(cStream);
            sWriter.Write(plainString);
            sWriter.Flush();
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.GetBuffer(), 0, (int)mStream.Length);

        }
        public string decrypt (string encryptedString)
        {
            if (String.IsNullOrEmpty(encryptedString))
            {
                throw new ArgumentNullException("The string for decryption cannot be empty or null!");
            }
            SymmetricAlgorithm saProvider = DES.Create();
            MemoryStream memStream = new MemoryStream(Convert.FromBase64String(encryptedString));
            CryptoStream cStream = new CryptoStream(memStream, saProvider.CreateDecryptor(seed,seed), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cStream);
            return reader.ReadLine();
        }
    }
}