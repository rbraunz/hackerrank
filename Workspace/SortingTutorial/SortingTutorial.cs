using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTutorial
{
    class SortingTutorial
    {

        private int _count; 

        static void Main(string[] args)
        {
            long soughtValue = Convert.ToInt64(Console.ReadLine());
            long size = Convert.ToInt64(Console.ReadLine());
            string[] array = Console.ReadLine().Split(' ');
            int i = 0;
            long[] intArray = new long[size];
            foreach (var element in array)
            {
                intArray[i] = Convert.ToInt64(element);
                i++;
            }

            var index = Array.BinarySearch(intArray, soughtValue);
            Console.WriteLine(index);
        }
    }
}
