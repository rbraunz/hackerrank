using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonelyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;

            int _a_size = Convert.ToInt32(Console.ReadLine());
            int[] _a = new int[_a_size];
            int _a_item;
            String move = Console.ReadLine();
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                _a[_a_i] = _a_item;
            }

            res = lonelyinteger(_a);
            Console.WriteLine(res);
        }
        private static int lonelyinteger(int[] a)
        {
            int?[] singleOccurance = new int?[a.Length];
            int?[] multipleOccurance = new int?[a.Length];
            int?[] copyOfInitialSet = new int?[a.Length];
            int result = 0;
            int copy = 0;
            int counter = 0;
            foreach (var element in a)
            {
                copyOfInitialSet[copy] = element;
                copy++;
                if (!singleOccurance.Contains(element))
                {
                    singleOccurance[counter] = element;
                    counter++;
                }
                else
                {
                    multipleOccurance[counter] = element;
                    counter++;
                }
            }
            var resultSet = copyOfInitialSet.Except(multipleOccurance);
            result = (int)resultSet.FirstOrDefault();
            return result;
        }
    }
}
