using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMaximize
{
    class Program
    {
        static void Main(string[] args)
        {
            long noOfTestCases = Convert.ToInt64(Console.ReadLine());

            for(int i = 0; i<noOfTestCases;i++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                long[] Nums = new long[n];

                Nums = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

                long Len = Nums.Length - 1;
                long MaxFuturePrice = 0;
                long Profit = 0;

                for (long j = Len; j >= 0; --j)
                {
                    MaxFuturePrice = Math.Max(MaxFuturePrice, Nums[j]);
                    Profit += MaxFuturePrice - Nums[j];
                }

                Console.WriteLine(Profit);
            }
        }
    }
}
