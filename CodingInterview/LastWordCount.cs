using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    class LastWordCount
    {
        public static void Execute()
        {
            Console.WriteLine("This function with count the last word length.");
            Console.WriteLine("Enter the text.");
            string text = Console.ReadLine();
            Console.WriteLine("The text length is : {0}", TextCount(text));
            Console.ReadLine();
        }

        // What if the interviewver says don't count the . in charracter ? 
        // What if the interviewver asks to get the second last word count.
        
        static int TextCount(string text)
        {
            string[] spltText = text.Split(' ');
            string lastWord;
            if (spltText.Length - 2 < 0)
            {
                return 0;
            }
            else
            {
                lastWord = spltText[spltText.Length - 2];
            }
            int lastWordCount = 0;
            if(lastWord.Contains('.'))
            {
                // guy. // g.uy.
                string[] lastWordSplt = lastWord.Split('.');
                lastWordCount = lastWord.Length + 1 - lastWordSplt.Length;
            }
            else
            {
                lastWordCount = lastWord.Length;
            }
            return lastWordCount;
        }
    }
}
