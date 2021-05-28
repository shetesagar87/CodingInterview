using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    public class CalculateVowConst
    {
        public static void Execute()
        {
            Console.WriteLine("Enter the string/word to calculate the Vowels & constants in string :");
            string actualString = Console.ReadLine();
            CalculateVowConstInString(actualString);
            Console.WriteLine("===================================");
            Console.ReadLine();
        }

        private static void CalculateVowConstInString(string actualString)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int actualStringLength = actualString.Length;

            int stringLength = actualString.Replace(" ","").Length;
            int constantCount = string.Join("", actualString.ToCharArray().Select(w =>
            {
                if (!vowels.Contains(w))
                {
                    return w;
                }
                else
                {
                    return ' ';
                }
            }).ToArray()).Replace(" ","").Length;

            Console.WriteLine("The string lenght is :" + actualStringLength + " while the number of vowels in string :" + (stringLength - constantCount) + " and number of consonants : " + constantCount);
        }
    }
}
