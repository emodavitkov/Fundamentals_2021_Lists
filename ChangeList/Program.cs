using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="end")
                {
                    break;
                }

                string[] commands = input.Split()
                    .ToArray();

// Delete { element} – delete all elements in the array, which are equal to the given element.
//•	Insert { element} { position} – insert an element and the given position.

                switch (commands[0])
                {
                    case "Delete":
                        numbers.RemoveAll(x => x == (int.Parse(commands[1])));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(commands[2]),int.Parse(commands[1]));
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
