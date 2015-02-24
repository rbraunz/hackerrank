using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingTowns
{
    class ConnectingTowns
    {
        static void Main(string[] args)
        {

            int noOfTestCases = Int32.Parse(Console.ReadLine().Trim());
            long[] results = new long[noOfTestCases];
            for (int i = 0; i < noOfTestCases; i++)
            {
                var noOfTowns = Convert.ToInt64(Console.ReadLine());
                var routeLengthsAsString = Convert.ToString(Console.ReadLine()).Split(' ');
                results[i] = ComputeDistance(routeLengthsAsString);
            }
            for(int j = 0; j<results.Length; j++)
            {
              Console.WriteLine(results[j]);
            }
            Console.ReadLine();
        }
        private static long ComputeDistance(string[] routeLengths)
        {
            long result = 0;
            for (int j = 0; j < routeLengths.Length; j++)
            {
                    if (result == 0)
                    {
                        result = Int64.Parse(routeLengths[j]);
                    }

                    else
                    {
                        result *= Int64.Parse(routeLengths[j]);
                        result = result % 1234567;
                    }
            }
            return result;
        }
    }

}
