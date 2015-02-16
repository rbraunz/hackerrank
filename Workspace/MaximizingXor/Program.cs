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
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);
        }

        static int maxXor(int l, int r)
        {
            int max = 0;
            int xorValue = l ^ r;
            max = (max > xorValue) ? max : xorValue;
            return max;
        }
    }
}
