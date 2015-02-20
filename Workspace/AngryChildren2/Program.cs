using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryChildren2
{
    class Program
    {
        private static int[] mySet;

        static string AngryChildren(int k)
        {
            Array.Sort(mySet);

            int currentMin = 0;
            int currentMax = k - 1;
            ulong unfairness = UInt64.MaxValue;
            ulong currentUnfairness = 0;
            int pointer;
            ulong temp = UInt64.MaxValue;

            while (currentMax < mySet.Length)
            {
                pointer = currentMin;
                if (temp == UInt64.MaxValue)
                {
                    while (pointer < currentMax)
                    {
                        for (int i = pointer + 1; i <= currentMax; i++)
                        {
                            currentUnfairness += (ulong)(mySet[i] - mySet[pointer]);
                        }

                        if (pointer == currentMin)
                        {
                            temp = currentUnfairness;
                        }

                        ++pointer;
                    }
                }
                else
                {
                    for (int i = currentMin; i < currentMax; i++)
                    {
                        currentUnfairness += (ulong)(mySet[currentMax] - mySet[i]);
                    }
                    currentUnfairness -= temp;
                    temp = 0;
                    for (int j = pointer + 1; j <= currentMax; j++)
                    {
                        temp += (ulong)(mySet[j] - mySet[pointer]);
                    }
                }

                if (currentUnfairness < unfairness)
                    unfairness = currentUnfairness;

                ++currentMax;
                ++currentMin;
            }

            return unfairness.ToString();
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            mySet = new int[n];
            int k = Int32.Parse(Console.ReadLine());

            while (n > 0)
            {
                n--;
                mySet[n] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine(AngryChildren(k));
        }
    }
}
