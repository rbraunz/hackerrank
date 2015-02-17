using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTree
{
    class Program
    {
        private static void Main(string[] args)
        {
           
            string[] array = Console.ReadLine().Split(' ');
            long n = Convert.ToInt64(array[0]); 
            long m = Convert.ToInt64(array[1]);


            long[] tree = new long[n];
            long[] count = new long[n];
            long j = 0;
            foreach (var element in count)
            {
                count[j] = 1;
                j++;
            }

            for (int i = 0; i < m; i++)
            {
                string[] nextPoint = Console.ReadLine().Split(' ');
                long u1 = Convert.ToInt64(nextPoint[0]);
                long v1 = Convert.ToInt64(nextPoint[1]);

                tree[u1 - 1] = v1;

                count[v1 - 1] += count[u1 - 1];

                long root = tree[v1 - 1];

                while (root != 0)
                {
                    count[root - 1] += count[u1 - 1];
                    root = tree[root - 1];
                }
            }

            int counter = -1;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i]%2 == 0)
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);

        }


        /**
         * @param args
         */

        //public static void main(String[] args) {
        //        // TODO Auto-generated method stub


        //        int N = scan.nextInt(); //points
        //        int M = scan.nextInt();

        //        tree = new int[N];
        //        count = new int[N];
        //        Arrays.fill(count, 1);

        //        for(int i=0;i<M;i++)
        //        {
        //                int u1 = scan.nextInt();
        //            int v1 = scan.nextInt();

        //            tree[u1-1] = v1;

        //            count[v1-1] += count[u1-1];

        //            int root = tree[v1-1];

        //            while(root!=0)
        //            {
        //                count[root-1] += count[u1-1];
        //                root = tree[root-1];
        //            }
        //        }

        //        System.out.println("");

        //    int counter = -1;
        //        for(int i=0;i<count.length;i++)
        //        {
        //                if(count[i]%2==0)
        //                {
        //                        counter++;
        //                }

        //        }
        //        System.out.println(counter);

        //}
    }
}
