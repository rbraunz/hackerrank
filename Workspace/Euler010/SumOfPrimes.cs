using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler010
{
    class SumOfPrimes
    {
        private static void Main(string[] args)
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
                var totalsum = new Atkin(n);
                totalsum.FindPrimes();
                Console.WriteLine(totalsum.sum);
                //Console.WriteLine(GeneratePrimesParallel(n).Sum());
                //Console.WriteLine(ESieve(n));
                //Console.WriteLine("Count = " + primelist.Count);
            }
        }

  


    }
    public class Atkin
    {
        private readonly long limit;
        public long sum = 0;

        public Atkin(long limit)
        {
            this.limit = limit;
        }

        public void FindPrimes()
        {
            if (limit == 2)
            {
                sum = 2;
                return;
            }
            if (limit == 3)
            {
                sum = 5;
                return;
            }
            sum = 5;
            var isPrime = new bool[limit + 1];
            var sqrt = Math.Sqrt(limit);
            for (long x = 1; x <= sqrt; x++)
                for (long y = 1; y <= sqrt; y++)
                {
                    var n = 4 * x * x + y * y;
                    if (n <= limit && (n%12 == 1 || n%12 == 5))
                    {
                        isPrime[n] ^= true;
                        sum = sum + n;
                    }

                    n = 3 * x * x + y * y;
                    if (n <= limit && n%12 == 7)
                    {
                        isPrime[n] ^= true;
                        sum = sum + n;
                    }
                    n = 3 * x * x - y * y;
                    if (x > y && n <= limit && n%12 == 11)
                    {
                        isPrime[n] ^= true;
                        sum = sum + n;
                    }
                }
        }
    }
}
