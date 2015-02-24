using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingCharacters
{
    class AlternatingCharacters
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] incomingStrings = new string[size];
            for (int i = 0; i < size; i++)
            {
                var input = Convert.ToString(Console.ReadLine());
                incomingStrings[i] = input;
            }
            foreach (var item in incomingStrings)
            {
                Console.WriteLine(CharactersToBeDeleted(item));
            }
            Console.ReadLine();
        }

        private static long CharactersToBeDeleted(string input)
        {
            var charArray = input.ToCharArray();
            long length = input.Length;
            int i = 0;
            long numberOfCharactersToBeDeleted = 0;
            while (i < length)
            {
                var currentLetter = charArray[i];
                if (currentLetter == 'A')
                {
                    if (i != 0)
                    {
                        if (charArray[i-1] == 'B')
                        {
                            //do nothing
                        }
                        else
                        {
                            numberOfCharactersToBeDeleted++;
                        }
                    }
                }
                else
                {
                    if (i != 0)
                    {
                        if (charArray[i - 1] == 'A')
                        {
                            //do nothing
                        }
                        else
                        {
                            numberOfCharactersToBeDeleted++;
                        }
                    }
                }
                i++;
            }
            return numberOfCharactersToBeDeleted;
        }
    }
}
