using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            Int64[] incomingInts = new Int64[size];
            for (int i = 0; i < size; i++)
            {
                var input = Convert.ToInt64(Console.ReadLine());
                incomingInts[i] = input;
            }
            foreach (var item in incomingInts)
            {
                Console.WriteLine(FlippingBits(item));
            }
            Console.ReadLine();
        }

        private static uint FlippingBits(Int64 decimalNumber)
        {
            //var binaryNumber = DecimalToBinary(decimalNumber);
            var b = DecimalToBitArray(decimalNumber);
            return getIntFromBitArray(b.Not());
        }

        private static uint getIntFromBitArray(BitArray bitArray)
        {
            UInt32 res = 0;
            for (int i = 0; i != 32; i++)
            {
                if (bitArray[i])
                {
                    res |= (UInt32)(1 << i);
                }
            }
            return res;
        }

        private static BitArray DecimalToBitArray(Int64 decimalNumber)
        {
            var bytes =System.BitConverter.GetBytes(decimalNumber);
            BitArray b = new BitArray(bytes);
            return b;
        }

        //private static string DecimalToBinary(int decimalNumber)
        //{
        //    Console.Write("Decimal: ");

        //    int remainder;
        //    string result = string.Empty;
        //    while (decimalNumber > 0)
        //    {
        //        remainder = decimalNumber % 2;
        //        decimalNumber /= 2;
        //        result = remainder.ToString() + result;
        //    }
        //    Console.WriteLine("Binary:  {0}", result);
        //    return result;
        //}
    }
}
