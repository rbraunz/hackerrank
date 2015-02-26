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
            int maxprime = 1000000;
            ArrayList primelist = sieve(maxprime);
            foreach (var n in incomingLongs)
            {
                                Console.WriteLine();
                //Console.WriteLine("Count = " + primelist.Count);
            }
            Console.ReadLine();
        }



        static ArrayList sieve(int arg_max_prime)
        {
            BitArray al = new BitArray(arg_max_prime, true);

            int lastprime = 1;
            int lastprimeSquare = 1;

            while (lastprimeSquare <= arg_max_prime)
            {
                lastprime++;

                while (!(bool)al[lastprime])
                    lastprime++;

                lastprimeSquare = lastprime * lastprime;

                for (int i = lastprimeSquare; i < arg_max_prime; i += lastprime)
                    if (i > 0)
                        al[i] = false;
            }

            ArrayList sieve_2_return = new ArrayList();

            for (int i = 2; i < arg_max_prime; i++)
                if (al[i])
                    sieve_2_return.Add(i);

            return sieve_2_return;
        }
    }
}
