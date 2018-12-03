using System;

//+1 symbol in alphabet
namespace CryptoDecrypter
{
    class Substitution : ConsoleMenu
    {
        char shift = 'a';

        public void Encrypt(string myText)
        {
            string encrypt = myText;

            bool tbNull = myText == "";

            if (tbNull)
                Console.WriteLine("There is nothing to encrypt.");

            else
            {
                char[] array = encrypt.ToCharArray();

                for (int i = 0; i < array.Length; i++)
                {
                    int num = (int)array[i];
                    if (num >= 'a' && num <= 'z')
                    {
                        num += (Convert.ToInt32(shift.ToString().ToLower()[0]) - Convert.ToInt32('a') + 1);

                        if (num > 'z')
                        {
                            num = num - 26;
                        }
                    }
                    else if (num >= 'A' && num <= 'Z')
                    {
                        num += (Convert.ToInt32(shift.ToString().ToUpper()[0]) - Convert.ToInt32('A') + 1);

                        if (num > 'Z')
                        {
                            num = num - 26;
                        }
                    }
                    array[i] = (char)num;
                }

                encrypted = new string(array);
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
                char[] array = encrypted.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    int num = (int)array[i];
                    if (num >= 'a' && num <= 'z')
                    {
                        num -= (Convert.ToInt32(shift.ToString().ToLower()[0]) - Convert.ToInt32('a') + 1);

                        if (num > 'z')
                            num = num - 26;

                        if (num < 'a')
                            num = num + 26;
                    }
                    else if (num >= 'A' && num <= 'Z')
                    {
                        num -= (Convert.ToInt32(shift.ToString().ToUpper()[0]) - Convert.ToInt32('A') + 1);

                        if (num > 'Z')
                            num = num - 26;

                        if (num < 'A')
                            num = num + 26;
                    }
                    array[i] = (char)num;
                }
                decrypted = new string(array);
            }
            Console.WriteLine(decrypted);
        }
    }
}
