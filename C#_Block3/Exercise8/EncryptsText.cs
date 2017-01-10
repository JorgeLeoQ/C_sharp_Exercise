using System;
using System.Text;

namespace Exercise8
{
    public class EncryptsText
    {
        public static string Crypt(string stringToCrypt, string cipher)
        {
            int i = 0; //index for cipher string

            StringBuilder stringEncrypts = new StringBuilder(stringToCrypt.Length);

            for (int counter = 0; counter < stringToCrypt.Length; counter++)
            {
                uint letter = Convert.ToUInt16(stringToCrypt[counter]);
                uint cipherLetter = Convert.ToUInt16(cipher[i]);
                uint letterEncrypts = letter ^ cipherLetter;

                string convertFormat = String.Format(@"\u{0:x4}", letterEncrypts);

                stringEncrypts.Append(convertFormat);

                if (i == cipher.Length - 1)
                {
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            return stringEncrypts.ToString();
        }

        static void Main(string[] args)
        {
            string stringInput = "Nel mezzo del cammin di nostra vita mi ritrovai per una selva oscura ché la diritta via era smarrita";
            string cipher = "123456789";
            Console.WriteLine(Crypt(stringInput, cipher));
        }
    }
}
