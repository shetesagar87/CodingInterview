using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    public class ReverseString
    {
        // I want full stop in the end. 
        // Reverse string mentioned at specific index/ first word.
        // Even reverse every word.E.g Sam -- > Mas.
        // Resolve just string reverse in a single line of code.

        /// </summary>
        public static void Execute()
        {
            Console.WriteLine("Enter the string to reverse:");
            string actualString = Console.ReadLine();
            Console.WriteLine("Reverse String: " + ReverseStringWordByWord(actualString));
            //Console.WriteLine("Reverse String: " + ReverseStringFirstWord(actualString));
            //Console.WriteLine("Reverse String: " + string.Join("", actualString.ToCharArray().Reverse()));
            //Console.WriteLine("Reverse String: " + string.Join(" ", actualString.Split(' ').Reverse()));
            Console.ReadLine();
        }

        public static string ReverseStringWordByWord(string stringToReverse)
        {
            StringBuilder sb = new StringBuilder();

            string[] splitString = stringToReverse.Split(' ');
            for (int i = splitString.Length - 1; i >= 0; i--)
            {
                if (splitString[i].Contains('.'))
                {
                    splitString[i] = splitString[i].Trim('.');
                    splitString[0] = splitString[0] + ".";
                }

                sb = sb.Append(" " +  splitString[i]);
            }
            return sb.ToString();
        }

        public static string ReverseStringFirstWord(string stringToReverse)
        {
            StringBuilder sb = new StringBuilder();

            string[] splitString = stringToReverse.Split(' ');
            for (int i = splitString.Length - 1; i >= 0; i--)
            {
                if (splitString[i].Contains('.'))
                {
                    splitString[i] = splitString[i].Trim('.');
                    splitString[0] = splitString[0] + ".";
                }

                if (i == 0)
                {
                    sb = sb.Append(" " + string.Join("", splitString[i].ToCharArray().Reverse()));
                }
                else
                {
                    sb = sb.Append(" " + splitString[i]);
                }
            }
            return sb.ToString();
        }
    }
}
