using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 6, 5, 4, 3, -5, 1, 0 };

            //InsertionSort.Sort(ref array);
            //SelectionSort.Sort(ref array);
            var sum = RecursiveSum.Sum(array);

            Console.ReadKey();
        }
    }
}
