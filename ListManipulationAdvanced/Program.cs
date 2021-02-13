using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            bool ifChanges = false;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split()
                    .ToArray();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        ifChanges = true;
                        break;
                    case "Remove":
                        int numbersToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numbersToRemove);
                        ifChanges = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        ifChanges = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        ifChanges = true;
                        break;
                    case "Contains":
                        int numberToContain = int.Parse(tokens[1]);
                        if (numbers.Contains(numberToContain))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ",numbers.Where(x=> x%2==0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;

                    case "Filter":
                        switch (tokens[1])
                        {
                            case "<":
                                Console.WriteLine(string.Join(" ", numbers.Where(x=> x<int.Parse(tokens[2]))));
                                break;
                            case ">":
                                Console.WriteLine(string.Join(" ", numbers.Where(x => x > int.Parse(tokens[2]))));
                                break;
                            case ">=":
                                Console.WriteLine(string.Join(" ", numbers.Where(x => x >= int.Parse(tokens[2]))));
                                break;
                            case "<=":
                                Console.WriteLine(string.Join(" ", numbers.Where(x => x <= int.Parse(tokens[2]))));
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
            }

            if (ifChanges)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
           




        }
    }
}
