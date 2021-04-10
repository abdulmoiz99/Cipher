using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Cipher
    {
        static int systemSize = 26;
        public static void Shift_Encrypt(string Input, int Key)
        {
            string CipherText = string.Empty;


            Input = Input.Replace(" ", string.Empty);
            char[] plainText = Input.ToCharArray();

            for (int i = 0; i < plainText.Length; i++)
            {
                int value = Main.GetAlphabetValue(plainText[i]);
                value = value + Key;

                value = value % systemSize;

                CipherText += Main.GetAlphabetKey(value);
            }
            Console.WriteLine("ENCRYPTED TEXT= " + CipherText);

        }

        public static void Shift_Decrypt(string CipherText, int Key)
        {
            string PlainText = string.Empty;

            CipherText = CipherText.Replace(" ", string.Empty).ToUpper();
            char[] cipherText = CipherText.ToCharArray();

            for (int i = 0; i < cipherText.Length; i++)
            {
                int value = Main.GetAlphabetValue(cipherText[i]);
                value = (value - Key) % systemSize;

                PlainText += Main.GetAlphabetKey(value);
            }
            Console.WriteLine("DECRYPTED TEXT= " + PlainText);
        }
        public static void Atbash_Encrypt(string PlainText)
        {
            PlainText = PlainText.Replace(" ", string.Empty).ToUpper();
            char[] plainTextArray = PlainText.ToCharArray();

            string CipherText = string.Empty;

            for (int i = 0; i < plainTextArray.Length; i++)
            {
                CipherText += Main.GetAtbashValue(plainTextArray[i]);
            }
            Console.WriteLine("ENCRYPTED TEXT= " + CipherText);
        }
        public static void Atbash_Decrypt(string CipherText)
        {
            CipherText = CipherText.Replace(" ", string.Empty).ToUpper();
            char[] pcipherTextArray = CipherText.ToCharArray();

            string PlainText = string.Empty;

            for (int i = 0; i < pcipherTextArray.Length; i++)
            {
                PlainText += Main.GetAtbashValue(pcipherTextArray[i]);
            }
            Console.WriteLine("DECRYPTED TEXT= " + PlainText);
        }
        public static void Rot13_Encrypt(string PlainText)
        {
            PlainText = PlainText.Replace(" ", string.Empty).ToUpper();
            char[] plainTextArray = PlainText.ToCharArray();
            string CipherText = string.Empty;
            int value = 0;
            for (int i = 0; i < plainTextArray.Length; i++)
            {
                value = Main.GetAlphabetValue(plainTextArray[i]);

                value += 13;
                if (value >= systemSize) value -= systemSize;

                CipherText += Main.GetAlphabetKey(value);
            }
            Console.WriteLine("ENCRYPTED TEXT= " + CipherText);
        }
        public static void Rot13_Decrypt(string CipherTet)
        {
            CipherTet = CipherTet.Replace(" ", string.Empty).ToUpper();
            char[] cipherTextArray = CipherTet.ToCharArray();
            string PlainText = string.Empty;
            int value = 0;
            for (int i = 0; i < cipherTextArray.Length; i++)
            {
                value = Main.GetAlphabetValue(cipherTextArray[i]);

                value -= 13;
                if (value <= -1) value += systemSize;

                PlainText += Main.GetAlphabetKey(value);
            }
            Console.WriteLine("DECRYPTED TEXT= " + PlainText);
        }
        public static void Affine_Encrypt(string PlainText, int a, int b)
        {
            PlainText = PlainText.Replace(" ", string.Empty).ToUpper();
            char[] plainTextArray = PlainText.ToCharArray();

            string CipherText = string.Empty;

            int value = 0;
            for (int i = 0; i < plainTextArray.Length; i++)
            {
                value = Main.GetAlphabetValue(plainTextArray[i]);

                value = (value * a) + b;

                value = value % systemSize;

                CipherText += Main.GetAlphabetKey(value);
            }
            Console.WriteLine("ENCRYPTED TEXT= " + CipherText);
        }
        public static void Affine_Decrypt(string cipherText, int a, int b)
        {
            string PlainText = "";

            // Get Multiplicative Inverse of a
            int aInverse = MultiplicativeInverse(a);

            char[] cipherTextArray = cipherText.ToUpper().ToCharArray();

            // Computer d(x) = aInverse * (e(x)  b)(mod m)
            for (int i = 0; i < cipherTextArray.Length; i++)
            {
                if (cipherTextArray[i] != ' ')
                {
                    int x = Convert.ToInt32(cipherTextArray[i] - 65);
                    if (x - b < 0) x = Convert.ToInt32(x) + 26;
                    PlainText += Convert.ToChar(((aInverse * (x - b)) % 26) + 65);
                }
                else
                {
                    PlainText += ' ';
                }
            }
            Console.WriteLine("DECRYPTED TEXT= " + PlainText);

        }

        public static int MultiplicativeInverse(int a)
        {
            for (int x = 1; x < 27; x++)
            {
                if ((a * x) % 26 == 1)
                    return x;
            }

            throw new Exception("No multiplicative inverse found!");
        }
    }
}
