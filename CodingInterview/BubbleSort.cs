using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    internal class BubbleSort
    {
        private int[] dataarray;
        public void Execute()
        {
            dataarray = new int[] { 4, 7, 2, 3, 10, 9 };

            if (dataarray == null || dataarray.Length == 0)
            {
                Console.WriteLine("Kindly enter the dataarray value");
                return;
            }
            
            BubbleSortFunct(dataarray);
            foreach (int data in dataarray)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }

        private void BubbleSortFunct(int[] input)
        {
            var itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;
                    }
                }
                foreach (int data in dataarray)
                {
                    Console.WriteLine(data);
                }
                Console.ReadLine();
            } while (itemMoved);
        }
    }

    
}
