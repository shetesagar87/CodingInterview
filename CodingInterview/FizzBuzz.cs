using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
   static class FizzBuzz
    {
        public static void Execute()
        {
            for (int i = 0; i <= 100; i++)
            {
                FizzBuzzEx(i);
            }
            Console.ReadLine();
            for (int i = 0; i <= 100; i++)
            {
                FizzBuzzOpt1(i);
            }
            Console.ReadLine();
            for (int i = 0; i <= 100; i++)
            {
                FizzBuzzOpt2(i);
            }
            Console.ReadLine();
        }

        static void FizzBuzzEx(int n)
        {
            if (n % 3 == 0 && n % 5 == 0) { Console.WriteLine("FIZZBUZZ"); }
            else if (n % 5 == 0) { Console.WriteLine("BUZZ"); }
            else if (n % 3 == 0) { Console.WriteLine("FIZZ"); }
            else { Console.WriteLine(n); }
        }

        static void FizzBuzzOpt1(int i)
        {
            Console.WriteLine(i % 5 == 0 ? i % 3 == 0 ? "FIZZBUZZ" : "BUZZ" : i % 3 == 0 ? "FIZZ" : i.ToString());
        }

        static void FizzBuzzOpt2(int i)
        {
            Console.WriteLine(((i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "")) == String.Empty ? i.ToString() : (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : ""));
        }
    }
}
