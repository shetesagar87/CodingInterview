using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    public class QuickSort
    {
        private int[] dataarray;
        private int length;
        public void Execute()
        {
            dataarray = new int[] { 4, 7, 2, 3, 10, 9 };
            
            if(dataarray == null || dataarray.Length == 0 )
            {
                Console.WriteLine("Kindly enter the dataarray value");
                return;
            }
            length = dataarray.Length-1;
            quickSort(0, length);
            foreach(int data in dataarray)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }

        private void quickSort(int low, int high)
        {
            int i = low;
            int j = high;

            // pivot is middle index
            int pivot = dataarray[low + (high - low) / 2];

            // Divide into two arrays
            while (i <= j)
            {
                /**
                 * As shown in above image, In each iteration, we will identify a
                 * number from left side which is greater then the pivot value, and
                 * a number from right side which is less then the pivot value. Once
                 * search is complete, we can swap both numbers.
                 */
                while (dataarray[i] < pivot)
                {
                    i++;
                }
                while (dataarray[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    swap(i, j);
                    // move index to next position on both sides
                    i++;
                    j--;
                }
            }

            // calls quickSort() method recursively
            if (low < j)
            {
                quickSort(low, j);
            }

            if (i < high)
            {
                quickSort(i, high);
            }
        }

        private void swap(int i, int j)
        {
            int temp = dataarray[i];
            dataarray[i] = dataarray[j];
            dataarray[j] = temp;
        }
    }
}
