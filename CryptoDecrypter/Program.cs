using System;

namespace CryptoDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMenu menu = new ConsoleMenu();
            bool again = true;

            while (again == true)
            {
                menu.InputText();
                menu.ChooseMethod();
                Console.WriteLine("Do you want to change text or decrypt method? [y/n]");
                
                string answer = Console.ReadLine().ToUpper();

                again = (answer == "Y") ? again = true : again = false; 
            }
        }
    }
}
