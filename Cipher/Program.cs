using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {

            Cipher.Affine_Decrypt("piwqpgxu kbbgxi wgjniv owniei go oike hq di pgbbgwalh dah ikoy", 19, 10);

            Console.WriteLine("====== CIPHER ======");
            bool run = true;
            int choice = 0;
            while (run)
            {
                Console.WriteLine("1. Shift Cipher Encrypt");
                Console.WriteLine("2. Shift Cipher Decrypt");
                Console.WriteLine("3. Atbash Cipher Encrypt");
                Console.WriteLine("4. Atbash Cipher Decrypt");
                Console.WriteLine("5. Rot13 Cipher Encrypt");
                Console.WriteLine("6. Rot13 Cipher Decrypt");
                Console.WriteLine("\nEnter Choice: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {

                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
