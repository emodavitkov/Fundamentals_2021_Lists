using System;
using System.Linq;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that keeps track of guests, that are going to a house party. 
            //On the first line of input, you are going to receive the number of commands you are going to receive.

            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            //On the next lines you are going to receive one of the following messages:
            //-"{name} is going!"
            //- "{name} is not going!"
            //If you receive the first message, you have to add the person if he / she is not in the list and
            //if he / she is in the list print on the console: "{name} is already in the list!".
            //If you receive the second message, 
            //you have to remove the person if he / she is in the list and if not print: "{name} is not in the list!".
            //At the end print all the guests.

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] message = input.Split()
                    .ToArray();

                if (message.Length==3)
                {
                    if (!guests.Contains(message[0]))
                    {
                        guests.Add(message[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{message[0]} is already in the list!");
                    }

                    
                }

                else
                {
                    bool removed = guests.Remove(message[0]);

                    if (!removed)
                    {
                        Console.WriteLine($"{message[0]} is not in the list!");
                    }
                    
                    //if (guests.Contains(message[0]))
                    //{
                    //    guests.Remove(message[0]);
                    //}


                    //else
                    //{
                    //    Console.WriteLine($"{message[0]} is not in the list!");
                    //}
                }

            }

            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
