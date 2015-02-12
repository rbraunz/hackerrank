using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    class Solution
    {

        private static void Main(string[] args)
        {

            int size = Convert.ToInt32(Console.ReadLine());
            Int64[] incomingInts = new Int64[size];
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

        private static bool IsFibo(Int64 input, Int64 a = 1, Int64 b = 1)
        {
            if (input == 0 || input == 1)
                return true;
            Int64 nextFib = a + b;
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
