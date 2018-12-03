using System;
using System.Text;

namespace CryptoDecrypter
{
    class BitManipulation : ConsoleMenu
    {
        readonly int szEncryptionKey = 200;
        string encryptedText;
        string decryptedText;

        public string Encrypt(string myText)
        {
            StringBuilder szInputStringBuild = new StringBuilder(myText);
            StringBuilder szOutStringBuild = new StringBuilder(myText.Length);
            char Textch;
            for (int i = 0; i < myText.Length; i++)
            {
                Textch = szInputStringBuild[i];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            encryptedText = szOutStringBuild.ToString();
            Console.WriteLine(encryptedText);

            return encryptedText;
        }

        public string Decrypt()
        {
            StringBuilder szInputStringBuild = new StringBuilder(encryptedText);
            StringBuilder szOutStringBuild = new StringBuilder(encryptedText.Length);
            char Textch;
            for (int i = 0; i < encryptedText.Length; i++)
            {
                Textch = szInputStringBuild[i];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            decryptedText = szOutStringBuild.ToString();
            Console.WriteLine(decryptedText);

            return decryptedText;
        }
    }
}
