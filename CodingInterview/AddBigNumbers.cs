using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    public class AddBigNumbers
    {
        public static void Execute()
        {
            Console.WriteLine("Enter First Number : ");
            string FirstNumber = Console.ReadLine();

            Console.WriteLine("Enter Second Number : ");
            string SecondNumber = Console.ReadLine();

            Add2BigNumbers(FirstNumber, SecondNumber);
            Console.ReadLine();
            
        }

        private static void Add2BigNumbers(string FirstNumber, string SecondNumber)
        {
            int maxLenght = FirstNumber.Length > SecondNumber.Length ? FirstNumber.Length : SecondNumber.Length;
            int[] bigNumber = new int[maxLenght];
            int carryForward = 0;
            for (int i=maxLenght;i>0;i--)
            {
                
                Int16.TryParse(FirstNumber.ToCharArray()[i-1].ToString(), out var fnumber);
                Int16.TryParse(SecondNumber.ToCharArray()[i-1].ToString(), out var snumber);
                int total = carryForward + fnumber + snumber; 

                if(total > 9)
                {
                    int lastnumber = total % 10;
                    carryForward = total / 10;
                    bigNumber[i-1] = lastnumber;
                }

            }
            for(int i=0;i< bigNumber.Length;i++)
            {
                if (i == 0)
                { Console.Write(carryForward + "" + bigNumber[i]); }
                else
                {
                    Console.Write(bigNumber[i]);
                }
            }
         
        }
    }
}
