using System;
using System.Linq;
using System.Collections.Generic;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> numbers = new List<int>(firstList.Count+secondList.Count);
            int limit = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < limit; i++)
            {
                numbers.Add(firstList[i]);
                numbers.Add(secondList[i]);
            }

            if (firstList.Count!=secondList.Count)
            {
                if (firstList.Count > secondList.Count)
                {
                    numbers.AddRange(GetRemindingDigits(firstList,secondList));
                }

                else
                {
                    numbers.AddRange(GetRemindingDigits(secondList, firstList));
                }

            }


            Console.WriteLine(string.Join(" ",numbers));

    
        }

        private static List<int> GetRemindingDigits(List<int> longestlist, List<int> shorterList)
        {
            if (longestlist.Count<=shorterList.Count)
            {
                throw new ArgumentException();
            }

            List<int> result = new List<int>();

            for (int i = shorterList.Count; i < longestlist.Count; i++)
            {
                result.Add(longestlist[i]);
            }

            return result; 
        }
    }

}
