using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(':');

            var playerHands = new Dictionary<string, List<int>>();

            while (input[0] != "JOKER")
            {
                var playerName = input[0];
                var playerCards = input[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(CalculateCardPower).ToArray();

                if (!playerHands.ContainsKey(playerName))
                {
                    playerHands.Add(playerName, new List<int>());
                }

                playerHands[playerName].AddRange(playerCards);

                input = Console.ReadLine().Split(':');
            }

            foreach (var item in playerHands)
            {
                var name = item.Key;
                var cards = item.Value;

                var sum = cards.Distinct().Sum();

                Console.WriteLine($"{name}: {sum}");
            }
        }

        private static int CalculateCardPower(string playerCards)
        {
            var cardPower = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                cardPower[i.ToString()] = i;
            }

            cardPower["J"] = 11;
            cardPower["Q"] = 12;
            cardPower["K"] = 13;
            cardPower["A"] = 14;


            var cardType = new Dictionary<string, int>();

            cardType["C"] = 1;
            cardType["D"] = 2;
            cardType["H"] = 3;
            cardType["S"] = 4;


            var power = playerCards.Substring(0, playerCards.Length - 1);
            var type = playerCards.Substring(playerCards.Length - 1);

            var value = cardPower[power] * cardType[type];
            return value;
        }
    }
}
