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
            Int64 res;
            Int64 _l;
            _l = Convert.ToInt64(Console.ReadLine());

            Int64 _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);
        }

        private static Int64 maxXor(Int64 l, Int64 r)
        {
            Int64 max = 1;
            Int64 xorValue = l ^ r;
            while (xorValue > 0)
            {
                max <<= 1;
                xorValue >>= 1;
            }
            return (max-1);
        }
    }
}
