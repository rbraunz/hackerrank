﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace FiboModified
{
    class FiboModified
    {
        private static int _termSought;

        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int i = 0;
            int[] intArray = new int[3];
            foreach (var element in array)
            {
                intArray[i] = Convert.ToInt16(element);
                i++;
            }
            _termSought = intArray[2];
            Console.Write(ComputeNthTerm(intArray[0], intArray[1], 2).ToString());
        }

        private static BigInteger ComputeNthTerm(BigInteger termA, BigInteger termB, int currentTerm)
        {
            if (Equals(currentTerm, _termSought))
            {
                var nextTerm = BigInteger.Add((BigInteger.Pow(termB, 2)),  termA);
                //Console.WriteLine("Term T(n+1)^2: " + termB + " Term T(n): " + termA + " Current Term: " + currentTerm);
                return ComputeNthTerm(termB, nextTerm, currentTerm + 1);
            }
            else
            {
                return termB;
            }
        }
    }
}
