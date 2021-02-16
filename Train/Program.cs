using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="end")
                {
                    break; 
                }

                string[] newData = input.Split()
                    .ToArray();
                

                if (newData[0]=="Add")
                {
                    numbers.Add(int.Parse(newData[1]));
                }

                else
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i]<=(maxCapacity - int.Parse(newData[0])))
                        {
                            numbers[i] +=int.Parse(newData[0]);
                            break;

                        }

                    }


                }
                

            }

            Console.WriteLine(string.Join(" ",numbers));


            //List<int> numbers=new List<int>();

            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(2);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(5);
            //numbers.Add(5);
            //numbers.Add(5);
            //numbers.Add(5);

            //var count = numbers.RemoveAll(x=> x==2);

            //Console.WriteLine(count);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            //numbers.RemoveRange(3, 2);

            //foreach (var item in numbers)
            //{
            //    Console.Write(item);
            //}

        }
    }
}
