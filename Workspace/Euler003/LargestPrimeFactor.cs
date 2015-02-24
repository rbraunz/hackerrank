using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler003
{
    class LargestPrimeFactor
    {
        static void Main(string[] args)
        {
            ulong size = Convert.ToUInt64(Console.ReadLine());
            ulong[] incominggLongs = new ulong[size];
            for (ulong i = 0; i < size; i++)
            {
                var input = Convert.ToUInt64(Console.ReadLine());
                incominggLongs[i] = input;
            }
            foreach (var n in incominggLongs)
            {
                Console.WriteLine(FindLargestPrimeFactor(n));
                //Console.WriteLine(test(n));
            }
           //Console.ReadLine();
        }

        //public static long NextPrimeFactor()
        //{
            
        //}

        //public static long FindLargestPrimeFactor2(long numm)
        //{
        //    long newnumm = numm;
        //    long largestFact = 0;

        //    int counter = 2;
        //    while (counter * counter <= newnumm)
        //    {
        //        if (newnumm % counter == 0)
        //        {
        //            newnumm = newnumm / counter;
        //            largestFact = counter;
        //        }
        //        else
        //        {
        //            counter++;
        //        }
        //    }
        //    if (newnumm > largestFact)
        //    { // the remainder is a prime number
        //        largestFact = newnumm;
        //    }
        //    return largestFact;
        //}

        public static ulong FindLargestPrimeFactor(ulong number)
        {
            ulong sqrt = number;
            ulong counter = 2;
            ulong largestFact = 0;
            while (counter * counter <= sqrt)
            {
                if (sqrt%counter == 0)
                {
                    sqrt = sqrt/counter;
                    largestFact = counter;
                }
                else
                {

                    counter++;
                }
            }
            if (sqrt > largestFact)
            {
                largestFact = sqrt;
            }
            return largestFact;
        }
    }
}
