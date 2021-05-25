using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    public class MaxWordCount
    {
        public static void Execute()
        {
            Console.WriteLine("Enter the string to calculate the Max word count :");
            string actualString = Console.ReadLine();
            CalculateWordCount(actualString);
            Console.WriteLine("===================================");
            CalculateMaxWordCount(actualString);
            Console.WriteLine("===================================");
            CalculateMaxWordByLength(actualString);
            Console.ReadLine();
        }

        private static void CalculateWordCount(string actualString)
        {
            string[] splitString = actualString.Split(' ');
            var arrayCount = splitString.GroupBy(a => a);
            foreach (var r in arrayCount)
            {
                Console.WriteLine("This " + r.Key + " appeared " + r.Count() + "  times in a string.");
            }
        }

        private static void CalculateMaxWordCount(string actualString)
        {
            string[] splitString = actualString.Split(' ');
            var arrayCount = splitString.GroupBy(a => a).OrderByDescending(k => k.Count());
            Console.WriteLine("This " + arrayCount.FirstOrDefault().Key + " appeared " + arrayCount.FirstOrDefault().Count() + "  times in a string.");
        }

        private static void CalculateMaxWordByLength(string actualString)
        {
            string[] splitString = actualString.Split(' ');
            var arrayCount = splitString.GroupBy(a => a).OrderByDescending(k => k.Count());
            // Get the collection collection with Highest count.
            // Only reason for getting this is to minimize the iteration.
            var highestCountCollection = arrayCount.Where(a => a.Count() == arrayCount.FirstOrDefault().Count());


            // We can do this with Linq. Also can be done using for each loop. In this section we are going via the
            // for each loop.
            string longestWord = string.Empty;
            int wordLength = 0;
            int numberOfTimes = 0;
            foreach( var data in highestCountCollection)
            {
                if(wordLength < data.Key.Length)
                {
                    wordLength = data.Key.Length;
                    longestWord = data.Key;
                    numberOfTimes = data.Count();
                }
            }

            Console.WriteLine(longestWord + " appeared " + numberOfTimes + "  times in a string. While the string lenght is " + wordLength );
        }

    }
}
