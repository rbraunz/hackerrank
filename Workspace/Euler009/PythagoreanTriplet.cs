using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler009
{
    class PythagoreanTriplet
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] incomingInts = new int[size];
            for (int i = 0; i < size; i++)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                incomingInts[i] = input;
            }
            foreach (var n in incomingInts)
            {
                //var result =calculate(n);
                //WriteBigInt(result);
                Console.WriteLine(DetermineIfTriplet(n));
            }


        }


        public static int gcd(int a, int b)
        {
            int y = 0;
            int x = 0;
            if (a > b)
            {
                x = a;
                y = b;
            }
            else
            {
                x = b;
                y = a;
            }
            while (x % y != 0)
            {
                int temp = x;
                x = y;
                y = temp % x;
            }
            return y;
        }

        private static long DetermineIfTriplet(int s)
        {
            int a = 0, b = 0, c = 0;
            int m = 0, k = 0, n = 0, d = 0;
            bool found = false;

            int mlimit = (int)Math.Sqrt(s / 2);
            for (m = 2; m <= mlimit; m++)
            {
                if ((s/2)%m == 0)
                {
                    // m found
                    if (m%2 == 0)
                    {
                        // ensure that we find an odd number for k
                        k = m + 1;
                    }
                    else
                    {
                        k = m + 2;
                    }
                    while (k < 2*m && k <= s/(2*m))
                    {
                        if (s/(2*m)%k == 0 && gcd(k, m) == 1)
                        {
                            d = s/2/(k*m);
                            n = k - m;
                            a = d*(m*m - n*n);
                            b = 2*d*n*m;
                            c = d*(m*m + n*n);
                            found = true;
                            break;
                        }
                        k += 2;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            if (found != true)
            {
                return -1;
            }
            var result = Math.BigMul(a,b);
            result = result*c;
            return result;
        }

        private static long DetermineIfTripletBrute(long s)
        {
            long a = 0, b = 0, c = 0;;
            bool found = false;
            for (a = 1; a < s / 3; a++)
            {
                for (b = a; b < s / 2; b++)
                {
                    c = s - a - b;

                    if (a * a + b * b == c * c)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }
            if (found != true)
            {
                return -1;
            }
            else
            {
                return a*b*c;
            }

        }
    }
}
