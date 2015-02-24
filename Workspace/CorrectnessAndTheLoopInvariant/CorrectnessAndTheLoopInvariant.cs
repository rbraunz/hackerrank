using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectnessAndTheLoopInvariant
{
    class CorrectnessAndTheLoopInvariant
    {
        public static int[] insertionSort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (A[j - 1] > A[j])
                    {
                        int temp = A[j - 1];
                        A[j - 1] = A[j];
                        A[j] = temp;
                    }
                }
            }
            return A;
        }

        static void Main(string[] args)
        {
            int _ar_size = Convert.ToInt32(Console.ReadLine());

            int[] _ar = (from s in Console.ReadLine().Split()
                         select Convert.ToInt32(s)).ToArray();
            _ar = insertionSort(_ar);

            int i = 0;
            foreach (var element in _ar)
            {
                Console.Write(_ar[i] + " ");
                i++;
            }
        }
    }
}
