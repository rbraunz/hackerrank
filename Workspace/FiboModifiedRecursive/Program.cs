using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace FiboModifiedRecursive
{
    class Program
    {
        static void Main(String[] args)
        {
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            int a = Convert.ToInt32(split_elements[0]);
            int b = Convert.ToInt32(split_elements[1]);
            int n = Convert.ToInt32(split_elements[2]);
            BigInteger b1 = new BigInteger(b);
            BigInteger a1 = new BigInteger(a);



            for (int i = 3; i < n + 1; i++)
            {
                BigInteger temp = BigInteger.Pow(b1, 2) + a1;
                a1 = b1;
                b1 = temp;
            }
            var ans = new List<BigInteger>();
            var p10 = BigInteger.Pow(10, 100);
            while (b1 != 0)
            {
                ans.Add(b1 % p10);
                b1 /= p10;
            }
            Console.Write(ans[ans.Count - 1]);
            var fmt = new string('0', 100);
            for (var i = ans.Count - 2; i >= 0; i--)
            {
                var str = ans[i].ToString();
                Console.Write("{0}{1}", fmt.Substring(0, 100 - str.Length), str);
            }
            Console.WriteLine();
        }
    }
}
