using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class UtopianTree
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            long[] incomingInts = new long[size];
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

        private static long[] CalculateGrowth(long[] cycleCounts)
        {
            return cycleCounts.Select(c => CalculateGrowth(c)).ToArray();
        }

        private static long CalculateGrowth(long cycleCount)
        {
            long treeHeight = 1;
            var season = true;

            for (int i = 0; i < cycleCount; i++)
            {
                treeHeight = GrowTree(treeHeight, season);
                season = !season;
            }

            return treeHeight;
        }

        private static long GrowTree(long initialHeight, bool season)
        {
            return season ? initialHeight * 2 : initialHeight + 1;
        }


    }
}
