using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler012
{
    class TriangleDivisors
    {
        static void Main(string[] args)
        {
            long size = Convert.ToInt64(Console.ReadLine());
            long[] incomingLongs = new long[size];
            for (long i = 0; i < size; i++)
            {
                var input = Convert.ToInt64(Console.ReadLine());
                incomingLongs[i] = input;
            }
            foreach (var n in incomingLongs)
            {
                   determineFirstDivisor(n);
            }
        }

        private static void determineFirstDivisor(long n)
        {
            var count = 10000;
            int i = 1;
            while (i < count)
            {
                var result = SumOfSquares(i);
                if (GetFactorCount(result) > n)
                {
                    Console.WriteLine(result);
                    break;
                }
                i++;
            }
        }

        private static long SumOfSquares(long n)
        {
            long result = n * (n + 1) / 2;
            return result;
        }

        public static long GetFactorCount(long numberToCheck)
        {
            long factorCount = 0;
            long sqrt = (long)Math.Ceiling(Math.Sqrt(numberToCheck));

            // Start from 1 as we want our method to also work when numberToCheck is 0 or 1.
            for (long i = 1; i < sqrt; i++)
            {
                if (numberToCheck % i == 0)
                {
                    factorCount += 2; //  We found a pair of factors.
                }
            }

            // Check if our number is an exact square.
            if (sqrt * sqrt == numberToCheck)
            {
                factorCount++;
            }

            return factorCount;
        }
    }
}
