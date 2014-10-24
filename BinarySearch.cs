using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 2, 1, 6, 3, 5 };
            Array.Sort(arr);
            int value = rank(3, arr);

        }
        public static int rank(int key, int[] values)
        {
            int lo = 0;
            int hi = values.Length - 1;
            while (lo <= hi)
            {
                int mid = (lo + hi) / 2;
                if (key < values[mid])
                    hi = mid - 1;
                else if (key > values[mid])
                    lo = mid + 1;
                else
                    return mid;
            }
            return -1;

        }



    }
}

