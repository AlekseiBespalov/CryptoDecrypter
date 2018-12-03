using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDecrypter
{
    class Transposition : ConsoleMenu
    {

        public void Encrypt(string myText)
        {
            string encrypt = myText;
             bool tbNull = myText == "";
            if (tbNull)
                Console.WriteLine("There is nothing to encrypt.");

            else
            {
                char[] textArray = encrypt.ToCharArray();

                for (int i = 0; i < textArray.Length - 1; i++)
                {
                    char temp = textArray[i];
                    textArray[i] = textArray[i + 1];
                    textArray[i + 1] = temp;
                }
                encrypted = new string(textArray);
            }
            Console.WriteLine(encrypted);
        }

        public void Decrypt()
        {
            string decrypt = encrypted;

            bool tbNull = encrypted == "";

            if (tbNull)
                Console.WriteLine("There is nothing to decrypt");

            else
            {
                char[] textArray = decrypt.ToCharArray();

                for (int i = textArray.Length - 1; i > 0; i--)
                {
                    char temp = textArray[i];
                    textArray[i] = textArray[i - 1];
                    textArray[i - 1] = temp;
                }
                decrypt = new string(textArray);
            }
            Console.WriteLine(decrypt);
        }
    }
}
