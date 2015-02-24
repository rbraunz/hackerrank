using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler002
{
    class EvenFiboNum
    {
        private static void Main(string[] args)
        {
            long size = Convert.ToInt64(Console.ReadLine());
            long[] incominggLongs = new long[size];
            for (long i = 0; i < size; i++)
            {
                var input = Convert.ToInt64(Console.ReadLine());
                incominggLongs[i] = input;
            }
            foreach (var n in incominggLongs)
            {
                Console.WriteLine(CalculateFib(n));
            }
        }

        private static long CalculateFib(long n)
        {
            long term1 = 2;
            long term2 = 0;
            long result = 2;
            long summed = 0;

            while (result < n)
            {
                summed += result;
                result = 4 * term1 + term2;
                term2 = term1;
                term1 = result;
            }
            return summed;
        }
    }
}
