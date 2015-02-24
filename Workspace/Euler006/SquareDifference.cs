using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler006
{
    class SquareDifference
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
                ulong result = SumOfSquares(n) * SumOfSquares(n) - SumOfNaturalNumbers(n);
                Console.WriteLine(result);
            }

        }

        private static ulong SumOfSquares(ulong n)
        {
            ulong result = n*(n + 1)/2;
            return result;
        }

        private static ulong SumOfNaturalNumbers(ulong n)
        {
            ulong result = (n*(n + 1)*(2*n + 1))/6;
            return result;
        }
    }
}
