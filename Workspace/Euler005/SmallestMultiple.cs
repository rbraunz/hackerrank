using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler005
{
    class SmallestMultiple
    {
        static void Main(string[] args)
        {
            ulong size = Convert.ToUInt64(Console.ReadLine());
            ulong[] incomingLongs = new ulong[size];
            for (ulong i = 0; i < size; i++)
            {
                var input = Convert.ToUInt64(Console.ReadLine());
                incomingLongs[i] = input;
            }
            foreach (var n in incomingLongs)
            {
                ulong[] p = generatePrimes(n);
                ulong result = 1;

                for (int i = 0; i < p.Length; i++)
                {
                    ulong a = (ulong)Math.Floor(Math.Log(n) / Math.Log(p[i]));
                    result = result * ((ulong)Math.Pow(p[i], a));
                }
                //FindSmallestMultiple(n);
                Console.WriteLine(result);
            }
        }

        private static ulong[] generatePrimes(ulong upperLimit)
        {
            List<ulong> primes = new List<ulong>();
            bool isPrime;
            int j;
            primes.Add(2);
            for (ulong i = 3; i <= upperLimit; i += 2)
            {
                j = 0;
                isPrime = true;
                while (primes[j] * primes[j] <= i)
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes.ToArray<ulong>();
        }
    }


}
