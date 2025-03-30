using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    internal class Program
    {
        static void Main()
        {
            WordCounter wordcounter = new WordCounter();
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            wordcounter.CountWords(text);
            wordcounter.DisplayWordCount();

            Console.ReadKey();

        }
    }
}
