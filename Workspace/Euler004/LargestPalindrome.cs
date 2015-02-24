using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler004
{
    class LargestPalindrome
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
                FindLargestPalindromeProduct(n);
                //Console.WriteLine(test(n));
            }
            Console.ReadLine();
        }

        public static void FindLargestPalindromeProduct(ulong n)
        {
            bool found = false;
            ulong firstHalf = 998, palin = 0;
            ulong[] factors = new ulong[2];

            while (!found)
            {
                firstHalf--;
                palin = makePalindrome(firstHalf);
                for (ulong i = 999; i > 99; i--)
                {
                    if ((palin / i) > 999 || i * i < palin)
                    {
                        break;
                    }

                    if ((palin % i == 0) && palin < n)
                    {
                        found = true;
                        factors[0] = palin / i;
                        factors[1] = i;
                        break;
                    }
                }
            }
            Console.WriteLine(palin);
        }

        private static ulong makePalindrome(ulong firstHalf)
        {
            char[] reversed = firstHalf.ToString().Reverse().ToArray();
            return Convert.ToUInt64(firstHalf + new string(reversed));
        }
    }
}
