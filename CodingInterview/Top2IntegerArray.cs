using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    public class Top2IntegerArray
    {
        
        public static void Execute()
        {
            int[] dataarray = new int[] { 4, 7, 2, 3, 10, 9 };
            int firstMaxValue, secondMaxValue = 0;
            Get2TopNumbersInArray(dataarray,out firstMaxValue, out secondMaxValue);
            Console.WriteLine("The first top value:" + firstMaxValue);
            Console.WriteLine("The second top value:"+ secondMaxValue);
            Console.ReadLine();

            Array.Sort(dataarray);
            Console.WriteLine("The first top value:" + dataarray[dataarray.Length-1]);
            Console.WriteLine("The second top value:" + dataarray[dataarray.Length-2]);
            Console.ReadLine();

            int[] dataarrayTest2 = new int[] { 4, 9, 2, 3, 10, 7 };
            firstMaxValue = 0;
            secondMaxValue = 0;
            Get2TopNumbersInArray(dataarrayTest2, out firstMaxValue, out secondMaxValue);
            Console.WriteLine("The first top value:" + firstMaxValue);
            Console.WriteLine("The second top value:" + secondMaxValue);
            Console.ReadLine();

        }

        public static void Get2TopNumbersInArray(int[] data,out int firstMaxValue, out int secondMaxValue)
        {
            firstMaxValue = 1;
            secondMaxValue = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if(data[i] > firstMaxValue)
                {
                    secondMaxValue = firstMaxValue;
                    firstMaxValue = data[i];
                }
                if(data[i] > secondMaxValue && data[i] != firstMaxValue)
                {
                    secondMaxValue=data[i];
                }
            }
        }

        
    }
}
