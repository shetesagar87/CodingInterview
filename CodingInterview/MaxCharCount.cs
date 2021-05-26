using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    public class MaxCharCount
    {
        public static void Execute()
        {
            Console.WriteLine("Enter the string/word to calculate the char that appeared max number of times :");
            string actualString = Console.ReadLine();
            CalculateCharCountUsingLinq(actualString);
            Console.WriteLine("===================================");
            CalculateCharCountUsingDictionary(actualString);
            Console.WriteLine("===================================");
            CalculateCharCountUsingArray(actualString);
            Console.ReadLine();
        }

        private static void CalculateCharCountUsingLinq(string actualString)
        {
            var charArray = actualString.ToCharArray().GroupBy(a => a);
            foreach (var r in charArray)
            {
                Console.WriteLine("This " + r.Key + " appeared " + r.Count() + "  times in a string.");
            }
        }


        private static void CalculateCharCountUsingDictionary(string actualString)
        {
            char[] charArray = actualString.ToCharArray();
            Dictionary<char, int> dictCount = new Dictionary<char, int>();
            foreach (var r in charArray)
            {
                if (dictCount.ContainsKey(r))
                {
                    dictCount[r] = dictCount[r] + 1;
                }
                else
                {
                    dictCount.Add(r, 1);
                }
            }
            foreach (var r in dictCount)
            {
                Console.WriteLine("This character " + r.Key + " appeared " + r.Value + "  times in a string.");
            }
        }

        private static void CalculateCharCountUsingArray(string actualString)
        {
            char[] charArray = actualString.ToCharArray();

            int[] arr = new int[256];
            int maxCount = 0;
            char maxChar = ' ';
            foreach (var r in charArray)
            {
                arr[r] = arr[r] + 1;
                if (maxCount < arr[r])
                {
                    maxCount = arr[r];
                    maxChar = r;
                }
            }
            Console.WriteLine("This character " + maxChar + " that appeared maximum times : " + maxCount);

            IEnumerable<char> distinctCharArray = charArray.Distinct();

            foreach(var r in distinctCharArray)
            {
                Console.WriteLine("This character " + r + " that appeared  times " + arr[r]  + " in a string");

            }
        }

    }
}
