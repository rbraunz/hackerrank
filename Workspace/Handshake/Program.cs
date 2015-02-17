using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handshake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long size = Convert.ToInt64(Console.ReadLine());
            long[] incomingLongs = new long[size];
            for (int i = 0; i < size; i++)
            {
                var input = Convert.ToInt64(Console.ReadLine());
                incomingLongs[i] = input;
            }

            foreach (var incomingLong in incomingLongs)
            {
                Console.WriteLine(NumberOfHandShakes(incomingLong));
            }
        }

        private static long NumberOfHandShakes(long numberOfPeople)
        {
            if (numberOfPeople == 1)
            {
                return 0;
            }
            else
            {
                var result = ((numberOfPeople - 1)*(numberOfPeople))/2;
                return result;
            }
        }
    }
}
