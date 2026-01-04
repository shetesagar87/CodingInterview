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

            Console.WriteLine("Solving the sorting by Quick Sort");

            length = dataarray.Length-1;
            quickSort(0, length);
            foreach(int data in dataarray)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }

        private int partition(int low, int high)
        {

            // choose the pivot
            int pivot = dataarray[high];

            // index of smaller element and indicates 
            // the right position of pivot found so far
            int i = low - 1;

            // traverse arr[low..high] and move all smaller
            // elements to the left side. Elements from low to 
            // i are smaller after every iteration
            for (int j = low; j <= high - 1; j++)
            {
                if (dataarray[j] < pivot)
                {
                    i++;
                    swap(i, j);
                }
            }

            // move pivot after smaller elements and
            // return its position
            swap(i + 1, high);
            return i + 1;
        }

        private void quickSort(int low, int high)
        {
            if (low < high)
            {

                // pi is the partition return index of pivot
                int pi = partition(low, high);

                // recursion calls for smaller elements
                // and greater or equals elements
                quickSort(low, pi - 1);
                quickSort(pi + 1, high);
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
