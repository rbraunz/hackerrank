using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Euler001
{
    class MultiplesOf3And5
    {
        static void Main(string[] args)
        {
            long size = Convert.ToInt64(Console.ReadLine());
            long[] incomingInts = new long[size];
            for (long i = 0; i < size; i++)
            {
                var input = Convert.ToInt64(Console.ReadLine());
                incomingInts[i] = input;
            }
            foreach (var n in incomingInts)
            {
                //FindSum(n-1); //since all numbers below n

                Console.WriteLine(Solve(n-1));
            }
            Console.ReadLine();
        }

        //brute force
        public static void FindSum(long n)
        {
            long sum = 0;
            while (n > 0)
            {
                if (n % 5 == 0 || n % 3 == 0)
                {
                    sum = sum + n;
                }
                n--;
            }
            Console.WriteLine(sum);
        }

        private static long Solve(long n)
        {
            long result = SumDivisbleBy(3, n) + SumDivisbleBy(5, n) - SumDivisbleBy(15, n);
            return result;
        }

        private static long SumDivisbleBy(long n, long p)
        {
            return n*(p/n)*((p/n) + 1)/2;
        }


    }
}
