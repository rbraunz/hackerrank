using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class FindDigits
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] incomingInts = new int[size];
            for (int i = 0; i < size; i++)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                incomingInts[i] = input;
            }
            foreach (var integer in incomingInts)
            {
                ComputeResult(integer);
            }
        }

        private static void ComputeResult(int input)
        {
            int result = 0;
            int inputAsInt = input;
            int inputLengthCounter = 0;
            while (input.ToString().Length > inputLengthCounter)
            {
                int currentDigit = int.Parse(input.ToString().Substring(inputLengthCounter, 1));
                inputLengthCounter++;
                if (currentDigit != 0 && currentDigit != inputAsInt && inputAsInt % currentDigit == 0)
                {
                    result++;
                }
            }
            if (result != 0)
            {
                Console.WriteLine(result.ToString());
            }
        }
    }
}
