using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class RecursiveSum
    {
        public static int Sum(int[] array) {

            if (array.Length == 1)
                return array[0];
            else
                return array[0] + Sum(GetArray(array));

        }

        public static int[] GetArray(int[] array)
        {
            int[] newArray = new int[array.Length - 1];

            Array.Copy(array, 1, newArray, 0, array.Length - 1);

            return newArray;
        }
    }
}
