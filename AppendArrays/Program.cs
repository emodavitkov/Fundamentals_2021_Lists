using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                 .Split("|", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            List<int> result = new List<int>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                int[] transform = numbers[i]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                result.AddRange(transform);

                //for (int j = 0; j <= transform.Length-1; j++)
                //{
                //    result.Add(transform[j]);
                //}
               

            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
