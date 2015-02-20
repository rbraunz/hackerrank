using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Euler063
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDigits = Convert.ToInt32(Console.ReadLine());
            List<BigInteger> results = new List<BigInteger>();
            BigInteger i = 1;
            while (i < 20)
            {
                var power = BigInteger.Pow(i, numberOfDigits);
                    if (power.ToString().Length == numberOfDigits)
                    {
                        results.Add(power);
                    }
                i++;
            }
            foreach (var result in results)
            {
                Console.WriteLine(result);
             }
            Console.ReadLine();
        }

    }
}
