using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximizingXor
{
    class Program
    {
        static void Main(string[] args)
        {
            long res;
            long _l;
            _l = Convert.ToInt64(Console.ReadLine());

            long _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);
        }

        private static long maxXor(long l, long r)
        {
            long max = 1;
            long xorValue = l ^ r;
            while (xorValue > 0)
            {
                max <<= 1;
                xorValue >>= 1;
            }
            return (max-1);
        }
    }
}
