using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDecrypter
{
    public class ConsoleMenu
    {
        private string myText = "";
        public string encrypted = "";
        public string decrypted = "";
        private string method;

        public string InputText()
        {
            Console.WriteLine("Enter text for decrypt:");
            myText = Console.ReadLine();
            return myText;
        }

        public string ChooseMethod()
        {
            Console.Write("Choose chipher method (substitution or transposition): ");
            method = Console.ReadLine().ToLower(); 
            bool rightMethod = false;

            while (rightMethod == false)
            {
                if (method == "substitution")
                {
                    Substitution substitution = new Substitution();
                    substitution.Encrypt(myText);
                    substitution.Decrypt();
                    rightMethod = true;
                }
                else if (method == "transposition")
                {
                    Transposition transposition = new Transposition();
                    transposition.Encrypt(myText);
                    transposition.Decrypt();
                    rightMethod = true;
                }
                else if (method == "bit")
                {
                    BitManipulation bitEncryption = new BitManipulation();
                    bitEncryption.Encrypt(myText);
                    bitEncryption.Decrypt();
                    rightMethod = true;
                }
                else
                {
                    Console.WriteLine("You choose wrong method, try again: ");
                    rightMethod = true;
                }
            }
            return method;
        }
    }
}
