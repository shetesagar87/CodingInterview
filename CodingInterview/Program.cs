using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Top2IntegerArray.Execute();
            QuickSort qs = new QuickSort();
            qs.Execute();

            BubbleSort bs = new BubbleSort();
            bs.Execute();
        }
    }
}
