using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    class IsFibo
    {

        private static void Main(string[] args)
        {

            int size = Convert.ToInt32(Console.ReadLine());
            long[] incomingInts = new long[size];
            for (int i = 0; i < size; i++)
            {
                var input = Convert.ToInt64(Console.ReadLine());
                incomingInts[i] = input;
            }
            foreach (var integer in incomingInts)
            {
                if (IsFibo(integer))
                {
                    Console.WriteLine("IsFibo");
                }
                else
                {
                    Console.WriteLine("IsNotFibo");
                }
            }
            Console.ReadLine();
        }

        private static bool IsFibo(long input, long a = 1, long b = 1)
        {
            if (input == 0 || input == 1)
                return true;
            long nextFib = a + b;
            if (nextFib > input)
                return false;
            else if (nextFib == input)
                return true;
            else
            {
                return IsFibo(input, b, nextFib);
            }
        }

    }
}
