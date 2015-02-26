using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler007
{
    internal class SumOfSquares
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
            int maxprime = 104743;
            ArrayList primelist = sieve(maxprime);
            foreach (var n in incomingLongs)
            {
                Console.WriteLine(primelist[(int)n - 1]);
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

        public static bool IsPrime(long number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);
            long root = (long)Math.Sqrt((long)number);
            for (long i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }


        //private static List<int> GetAllPrimesLessThan(int maxPrime)
        //{
        //    var primes = new List<int>() { 2 };
        //    var maxSquareRoot = Math.Sqrt(maxPrime);
        //    var eliminated = new BitArray(maxPrime + 1);

        //    for (int i = 3; i <= maxPrime; i += 2)
        //    {
        //        if (!eliminated[i])
        //        {
        //            primes.Add(i);
        //            if (i < maxSquareRoot)
        //            {
        //                for (int j = i * i; j <= maxPrime; j += 2 * i)
        //                {
        //                    eliminated[j] = true;
        //                }
        //            }
        //        }
        //    }
        //    return primes;
        //}


        //public static IEnumerable<int> Primes(int bound)
        //{

        //    if (bound < 2) yield break;
        //    //The first prime number is 2
        //    yield return 2;

        //    //Create a sieve of 'half size' starting at 3
        //    BitArray notPrime = new BitArray((bound - 1) >> 1);
        //    int limit = ((int)(Math.Sqrt(bound)) - 1) >> 1;
        //    for (int i = 0; i < limit; i++)
        //    {
        //        if (notPrime[i]) continue;
        //        //The first number not crossed out is prime
        //        int prime = 2 * i + 3;
        //        yield return prime;
        //        //cross out all multiples of this prime, starting at the prime squared
        //        for (int j = (prime * prime - 2) >> 1; j < notPrime.Count; j += prime)
        //        {
        //            notPrime[j] = true;
        //        }
        //    }
        //    //The remaining numbers not crossed out are also prime
        //    for (int i = limit; i < notPrime.Count; i++)
        //    {
        //        if (!notPrime[i]) yield return 2 * i + 3;
        //    }
        //}



        //static long NPrimeGenerator(long nPrime)
        //{
        //    List<long> primes = new List<long>();

        //    primes.Add(2);
        //    long nPrimeVal = 3;

        //    while (true)
        //    {
        //        int sqrtNPrimeVal = (int) Math.Sqrt(nPrimeVal);

        //        foreach (int i in primes)
        //        {
        //            if (nPrimeVal%i == 0)
        //            {
        //                break;
        //            }

        //            if (i >= sqrtNPrimeVal)
        //            {
        //                primes.Add(nPrimeVal);
        //                if (primes.Count == nPrime)
        //                {
        //                    break;
        //                }
        //                break;
        //            }
        //        }
        //        nPrimeVal += 2;
        //    }
        //    return primes[primes.Count - 1];
        //}


        //private static void Main(string[] args)
        //{
        //    long size = Convert.ToInt64(Console.ReadLine());
        //    long[] incomingLongs = new long[size];
        //    for (long i = 0; i < size; i++)
        //    {
        //        var input = Convert.ToInt64(Console.ReadLine());
        //        incomingLongs[i] = input;
        //    }
        //    foreach (var n in incomingLongs)
        //    {
        //        long[] primes = new long[10000];
        //        primes[0] = 2;
        //        primes[1] = 3;
        //        primes[2] = 5;
        //        primes[3] = 7;
        //        primes[4] = 11;
        //        primes[5] = 13;
        //        int counter = 6;
        //        for (long x = primes[counter - 1] + 2; counter < n; x += 2)
        //        {
        //            if (IsPrime(x, primes)) primes[counter++] = x;
        //        }
        //        Console.WriteLine(primes[n - 1]);
        //    }
        //    Console.ReadLine();
        //}

        //static bool IsPrime(Int64 p, long[] primes)
        //{
        //    Int64 max = (Int64)Math.Ceiling(Math.Sqrt(p));
        //    foreach (long divisor in primes)
        //    {
        //        if (divisor > max) break;
        //        if (p % divisor == 0) return false;
        //    }
        //    return true;
        //}
        //private static void calculatPrimeTerm(ulong n)
        //{
        //    ulong numPrimes = 1;
        //    ulong numm = 1;

        //    while (numPrimes < n)
        //    {
        //        numm = numm + 2;
        //        if (isPrime(numm))
        //        {
        //            numPrimes++;
        //        }
        //    }
        //    Console.WriteLine(numm);
        //}

        //private static int test(int n)
        //{
        //    bool[] notPrime = new bool[n];
        //    notPrime[0] = true;
        //    notPrime[1] = true;
        //    for (int i = 2; i <= Math.Sqrt(notPrime.Length); i++)
        //    {
        //        if (!notPrime[i])
        //        {
        //            for (int j = i * 2; j < notPrime.Length; j += i)
        //            {
        //                notPrime[j] = true;
        //            }
        //        }
        //    }
        //    return n;
        //}

        //private static bool isPrime(ulong numm)
        //{
        //    if (numm <= 1)
        //    {
        //        return false;
        //    }

        //    if (numm == 2)
        //    {
        //        return true;
        //    }

        //    if (numm % 2 == 0)
        //    {
        //        return false;
        //    }

        //    ulong counter = 3;

        //    while ((counter * counter) <= numm)
        //    {
        //        if (numm % counter == 0)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            counter += 2;
        //        }
        //    }

        //    return true;
        //}

    }
}
