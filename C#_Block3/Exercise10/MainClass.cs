using System;

namespace Exercise10
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("That program reads a string and prints in alphabetical order all words");
            Console.WriteLine("from the input string and how many times each one of them occurs in the string.\n");

            Console.Write("Enter your string: ");
            string stringInput = Console.ReadLine();
            object[,] words = CountWordInText.CountWords(stringInput);

            for (int index = 0; index < words.Length / 2; index++)
            {
                Console.WriteLine("{0}\t\t{1}.", words[index, 0], words[index, 1]);
            }
        }
    }
}
