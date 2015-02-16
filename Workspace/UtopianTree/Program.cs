using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            Int64[] incomingInts = new Int64[size];
            for (int i = 0; i < size; i++)
            {
                var input = Convert.ToInt64(Console.ReadLine());
                incomingInts[i] = input;
            }
            var result = CalculateGrowth(incomingInts);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i].ToString());
            }
            Console.ReadLine();
        }

        private static Int64[] CalculateGrowth(Int64[] cycleCounts)
        {
            return cycleCounts.Select(c => CalculateGrowth(c)).ToArray();
        }

        private static Int64 CalculateGrowth(Int64 cycleCount)
        {
            Int64 treeHeight = 1;
            var season = true;

            for (int i = 0; i < cycleCount; i++)
            {
                treeHeight = GrowTree(treeHeight, season);
                season = !season;
            }

            return treeHeight;
        }

        private static Int64 GrowTree(Int64 initialHeight, bool season)
        {
            return season ? initialHeight * 2 : initialHeight + 1;
        }


    }
}
