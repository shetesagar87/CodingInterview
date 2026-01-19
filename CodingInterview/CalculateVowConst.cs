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
            CalculateIndVowConstInString(actualString);
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

            Console.WriteLine("The string length is :" + actualStringLength + " while the number of vowels in string :" + (stringLength - constantCount) + " and number of consonants : " + constantCount);
        }

        private static void CalculateIndVowConstInString(string actualString)
        {
            //char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int actualStringLength = actualString.Length;
            int[] list = new int[256];
            int stringLength = actualString.Replace(" ", "").Length;
            int constantCount = string.Join("", actualString.ToCharArray().Select(w =>
            {
               return VovelCount(w,ref list);
            }).ToArray()).Replace(" ", "").Length;

            Console.WriteLine("The string length is :" + actualStringLength + " while the number of vowels in string :" + (stringLength - constantCount) + " and number of consonants : " + constantCount);
            Console.WriteLine("Char a is appearing " + list['a'] + "times.");
            Console.WriteLine("Char e is appearing " + list['e'] + "times.");
            Console.WriteLine("Char i is appearing " + list['i'] + "times.");
            Console.WriteLine("Char o is appearing " + list['o'] + "times.");
            Console.WriteLine("Char u is appearing " + list['u'] + "times.");

        }

        private static void VovelCountusingList(string actualString)
        {
            string vowels = "aeiouAEIOU";

            int vowelCount = actualString.Count(c => char.IsLetter(c) && vowels.Contains(c));
            int consonantCount = actualString.Count(c => char.IsLetter(c) && !vowels.Contains(c));

            Console.WriteLine("Vovel Count: " + vowelCount + "times.");
            Console.WriteLine("Constant Count " + consonantCount + "times.");
        }

        private static void VovelCountusingSystem(string actualString)
        {

            int vowels = 0;
            int consonants = 0;

            foreach (char c in actualString)
            {
                if (!char.IsLetter(c))
                    continue;

                char ch = char.ToLower(c);

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowels++;
                else
                    consonants++;
            }

            Console.WriteLine($"Vowels: {vowels}");
            Console.WriteLine($"Consonants: {consonants}");
        }


        private static char VovelCount(char a, ref int[] list)
        {
            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
            {
                switch (a)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        list[a] = list[a] + 1;
                        break;
                    default:
                        break;
                }
                return ' ';
            }
            else
                return a;


        }
    }
}
