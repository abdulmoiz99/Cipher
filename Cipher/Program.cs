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
            //Console.WriteLine("Cipher Text: yfnzjpflivogvizvetvnzkyjfcmzexwzijktzgyvikvok");
            //for (int i = 0; i < 26; i++)
            //{
            //    Console.WriteLine("Using Key: " + i);
            //    Cipher.Shift_Decrypt("yfnzjpflivogvizvetvnzkyjfcmzexwzijktzgyvikvok", i);
            //}
            //return;
            string CipherText = "", PlainText = "";
            int key = 0;
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

                    case 1: // Shift Encrypt
                        Console.Write("Enter Plain Text: ");
                        PlainText = Console.ReadLine();
                        Console.Write("Enter Key:");
                        key = int.Parse(Console.ReadLine());
                        Cipher.Shift_Encrypt(PlainText, key);
                        break;
                    case 2: // Shift Decrypt
                        Console.Write("Enter Cipher Text: ");
                        CipherText = Console.ReadLine();
                        Console.Write("Enter Key: ");
                        key = int.Parse(Console.ReadLine());
                        Cipher.Shift_Decrypt(CipherText, key);
                        break;
                    case 3: // ATBash Encrypt
                        Console.Write("Enter Plain Text: ");
                        PlainText = Console.ReadLine();
                        Cipher.Atbash_Encrypt(PlainText);
                        break;
                    case 4:// ATBash Decrypt
                        Console.Write("Enter Cipher Text: ");
                        CipherText = Console.ReadLine();
                        Cipher.Atbash_Decrypt(CipherText);
                        break;
                    case 5: // ROT13 Encrypt
                        Console.Write("Enter Plain Text: ");
                        PlainText = Console.ReadLine();
                        Cipher.Rot13_Encrypt(PlainText);
                        break;
                    case 6:// ROT13 Decrypt
                        Console.Write("Enter Cipher Text: ");
                        CipherText = Console.ReadLine();
                        Cipher.Rot13_Decrypt(CipherText);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
