using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler008
{
    class LargestProduct
    {
        static void Main(string[] args)
        {
            int noOfTestCases = Int32.Parse(Console.ReadLine());
            BigInteger[] results = new BigInteger[noOfTestCases];
            for (int i = 0; i < noOfTestCases; i++)
            {
                var NandK = Console.ReadLine().Split(' ');
                var N = Convert.ToInt64(NandK[0]);
                var K = Convert.ToInt64(NandK[1]);
                var sequence = Convert.ToString(Console.ReadLine());
                results[i] = ComputeLargestProduct(N, K, sequence);
            }
            for (int i = 0; i < noOfTestCases; i++)
            {
                WriteBigInt(results[i]);
            }
            Console.ReadLine();
        }

        //N total digits in number sequence, K consecutive digits
        private static BigInteger ComputeLargestProduct(long n, long k, string stringSequence)
        {
            //var sequence = BigInteger.Parse(stringSequence);
            BigInteger largestProduct = 0;
            for (int i = 0; i < n - (k - 1); i++)
            {
                BigInteger currentProduct = 1;
                var currentSequence = stringSequence.Substring(i, (int)k).ToCharArray();
                for (int j = 0; j < currentSequence.Length; j++)
                {
                    currentProduct = BigInteger.Multiply(currentProduct, new BigInteger(Convert.ToInt64(currentSequence[j].ToString())));
                }
                if (currentProduct > largestProduct)
                {
                    largestProduct = currentProduct;
                }
            }
            return largestProduct;
        }

        private static void WriteBigInt(BigInteger b1)
        {
            if (BigInteger.Zero == b1)
            {
                Console.WriteLine("0");
                return;
            }
            var ans = new List<BigInteger>();
            var p10 = BigInteger.Pow(10, 100);
            while (b1 != 0)
            {
                ans.Add(b1 % p10);
                b1 /= p10;
            }
            Console.WriteLine(ans[ans.Count - 1]);
            var fmt = new string('0', 100);
            for (var i = ans.Count - 2; i >= 0; i--)
            {
                var str = ans[i].ToString();
                Console.WriteLine("{0}{1}", fmt.Substring(0, 100 - str.Length), str);
            }
        }
    }
}
