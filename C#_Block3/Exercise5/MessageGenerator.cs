using System;

namespace Exercise5
{
    public class MessageGenerator
    {
        private static Random randomGen = new Random();
        public static string[] phrase = new string[] { "The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category." };
        public static string[] story = new string[] { "Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied." };
        public static string[] firstName = new string[] { "Dayan", "Stella", "Hellen", "Kate" };
        public static string[] lastName = new string[] { "Johnson", "Peterson", "Charles" };
        public static string[] city = new string[] { "London", "Paris", "Berlin", "New York", "Madrid" };

        public static string CreateMesssage(int[] randomIndex)
        {
            Message messageComercial = new Message(phrase[randomIndex[0]], story[randomIndex[1]], firstName[randomIndex[2]], lastName[randomIndex[3]], city[randomIndex[4]]);
            return messageComercial.ToString();
        }

        public static int[] GetArrayIndexRandom()
         {
            const int lengthMat = 5;
            int[] array = new int[lengthMat];

            for (int index = 0; index <= 4; index++)
             {
                if (index == 1 || index == 4)
                 {
                    array[index]= randomGen.Next(0, 4);
                }
                if (index == 2 || index == 3)
                {
                    array[index] = randomGen.Next(0, 2); 
                }
                if (index == 0)
                {
                    array[index] = randomGen.Next(0, 3);
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
        }
    }
}
