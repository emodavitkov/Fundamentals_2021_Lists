using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOperations
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

                if (input=="End")
                {
                    break;
                }

                string[] command = input.Split()
                    .ToArray();

                //•	Add {number} – add number at the end.
                //•	Insert {number} {index} – insert number at given index.
                //•	Remove {index} – remove at index.
                //•	Shift left {count} – first number becomes last ‘count’ times.
                //•	Shift right {count} – last number becomes first ‘count’ times.

                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        if (!IsValid(command[2],numbers))
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Insert(int.Parse(command[2]),int.Parse(command[1]));
                        break;

                    case "Remove":
                        if (!IsValid(command[1],numbers))
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    default:
                        break;
                }

                if (command[0]=="Shift" && command[1]=="left")
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }

                else if (command[0] == "Shift" && command[1] == "right")
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        numbers.Insert(0, numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count - 1);

                    }
                }
                

            }

            Console.WriteLine(string.Join(" ",numbers));
        }

        private static bool IsValid(string idx, List<int> numbers)
        {
            return int.Parse(idx) >= 0 && int.Parse(idx) < numbers.Count;
        }
    }
}
