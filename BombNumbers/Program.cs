using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombPowernumber = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombPowernumber[0];
            int bombPower = bombPowernumber[1];

           
            while (true)
            {

                int idx = numbers.IndexOf(bombNumber);

                if (idx==-1)
                {
                    break;
                }

                int startIdx = idx - bombPower;

                if (startIdx<0)
                {
                    startIdx = 0;
                }

                int count = 2 * bombPower + 1;

                if (count > numbers.Count-startIdx)
                {
                    count = numbers.Count - startIdx;
                }

                numbers.RemoveRange(startIdx, count);
            }

            

            Console.WriteLine(numbers.Sum());
            
        }
    }
}
