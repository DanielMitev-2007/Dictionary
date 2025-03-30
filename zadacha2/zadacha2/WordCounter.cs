using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    internal class WordCounter
    {
        private Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        public void CountWords(string text)
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                string lowerWord = word.ToLower();

                if (wordFrequency.ContainsKey(lowerWord))
                {
                    wordFrequency[lowerWord]++;
                }
                else
                {
                    wordFrequency[lowerWord] = 1;
                }
            }
        }

        public void DisplayWordCount()
        {
            Console.WriteLine("\nFrequency of the word: ");

            foreach (var entry in  wordFrequency)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
