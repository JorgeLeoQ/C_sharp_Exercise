using System;
using System.Collections.Generic;
using System.Text;


namespace Exercise10
{
    public class CountWordInText
    {
        public static object[,] CountWords(string stringInput)
        {
            SortedDictionary<string, int> words = WordsInText(stringInput);
            object[,] result = new object[words.Count, 2];
            int index = 0;
            foreach (var item in words)
            {
                result[index, 0] = item.Key;
                result[index, 1] = item.Value;
                index++;
            }
            return result;
        }

        private static SortedDictionary<string, int> WordsInText(string stringInput)
        {
            SortedDictionary<string, int> wordsDict = new SortedDictionary<string, int>();
            StringBuilder stringB = new StringBuilder();

            for (int index = 0; index < stringInput.Length; index++)
            {
                char c = stringInput[index];
                //ignore the following characters
                if (c == ' ' || c == '.' || c == ',' || c == '!' || c == '?' || c == '-')
                {
                    SaveWord(stringB, wordsDict);
                }
                else
                {
                    stringB.Append(c);
                }
            }
            SaveWord(stringB, wordsDict);

            return wordsDict;
        }

        private static void SaveWord(StringBuilder stringB, SortedDictionary<string, int> dictionary)
        {
            if (stringB.Length == 0)
            {
                return;
            }

            string word = stringB.ToString().ToLower(); //convert to lower every words
            stringB.Clear();
            if (dictionary.ContainsKey(word))
            {
                dictionary[word]++;
            }
            else
            {
                dictionary.Add(word, 1);
            }
        }
    }
}
