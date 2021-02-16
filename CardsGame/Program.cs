using System;
using System.Linq;
using System.Collections.Generic;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given two hands of cards, which will be integer numbers.Assume that you have two players. You have to find out the winning deck and respectively the winner.
            //You start from the beginning of both hands. Compare the cards from the first deck to the cards from the second deck.
            //The player, who has the bigger card, takes both cards and puts them at the back of his hand
            // -the second player’s card is last, and the first person’s card(the winning one) is before it (second to last) and the player with the smaller card must remove the card from his deck. 
            //If both players’ cards have the same values - no one wins, and the two cards must be removed from the decks.
            //The game is over, when one of the decks is left without any cards. You have to print the winner on the console and the sum of the left cards: "{First/Second} player wins! Sum: {sum}".


            
        List<int> firstHandCards = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondHandCards = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();


            while (true)
            {

                if (firstHandCards.Count==0
                    ||
                    secondHandCards.Count==0)
                {
                    break;
                }

                if (firstHandCards[0]>secondHandCards[0])
                {
                    firstHandCards.Add(firstHandCards[0]);
                    firstHandCards.Add(secondHandCards[0]);
                    firstHandCards.Remove(firstHandCards[0]);
                    secondHandCards.Remove(secondHandCards[0]);
                }

                else if (firstHandCards[0] < secondHandCards[0])
                {

                    secondHandCards.Add(secondHandCards[0]);
                    secondHandCards.Add(firstHandCards[0]);
                    secondHandCards.Remove(secondHandCards[0]);
                    firstHandCards.Remove(firstHandCards[0]);
                }

                else if ((firstHandCards[0] == secondHandCards[0]))
                {
                    firstHandCards.Remove(firstHandCards[0]);
                    secondHandCards.Remove(secondHandCards[0]);
                }
            }
            if (secondHandCards.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHandCards.Sum()}");
            }

            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHandCards.Sum()}");
            }
            
        }
    }
}
