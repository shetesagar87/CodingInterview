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
            Console.WriteLine("Solving the sorting by Bubble Sort");
            BubbleSortFunct(dataarray);
            foreach (int data in dataarray)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }

        private void BubbleSortFunct(int[] input)
        {
            int n = input.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        // Swap
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                        swapped = true;
                    }
                }

                // Optimization: stop if already sorted
                if (!swapped)
                    break;
            }

        }
    }
}
