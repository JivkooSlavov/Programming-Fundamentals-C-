using System.Collections.Generic;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOneDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwoDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (playerOneDeck.Count > 0 && playerTwoDeck.Count > 0)
            {
                int playerOneCard = playerOneDeck[0];
                int playerTwoCard = playerTwoDeck[0];
                if (playerOneCard > playerTwoCard)
                {

                    playerOneDeck.Add(playerOneCard);
                    playerOneDeck.Add(playerTwoCard);
                    playerOneDeck.RemoveAt(0);
                    playerTwoDeck.RemoveAt(0);
                }
                else if (playerTwoCard > playerOneCard)
                {
                    playerTwoDeck.Add(playerTwoCard);
                    playerTwoDeck.Add(playerOneCard);
                    playerOneDeck.RemoveAt(0);
                    playerTwoDeck.RemoveAt(0);
                }
                else
                {
                    playerOneDeck.RemoveAt(0);
                    playerTwoDeck.RemoveAt(0);
                }

            }
            if (playerOneDeck.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerOneDeck.Sum()}");
            }
            else if (playerTwoDeck.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwoDeck.Sum()}");
            }
            else
            {
                Console.WriteLine("No player wins! Sum: 0");
            }

        }
    }
}