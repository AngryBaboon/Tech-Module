using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Regex.Split(Console.ReadLine(), @"\s*,\s*").ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                var ticket = input[i].Trim();

                if (ticket.Count() == 20)
                {
                    var leftSide = ticket.Substring(0, 10);
                    var rightSide = ticket.Substring(9, 10);

                    if (CheckIfJackpot(ticket) == true)
                    {
                        var symbol = ticket.First();
                        Console.WriteLine($"ticket \"{ticket}\" - 10{symbol} Jackpot!");
                    }
                    else if (CheckIfSidesMatch(leftSide, rightSide) == true)
                    {
                        var charArr = ticket.ToCharArray();
                        var symbol = charArr[4];
                        var count = FindCount(leftSide, rightSide, symbol);

                        Console.WriteLine($"ticket \"{ticket}\" - {count}{symbol}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                    Console.WriteLine("invalid ticket");
            }
        }

        private static bool CheckIfSidesMatch(string leftSide, string rightSide)
        {
            // $$$$$$$^$$$$$^$$$$$$ gre6no

            var leftSideMatch = Regex.Match(leftSide, @"\@{6,9}");
            var rightSideMatch = Regex.Match(rightSide, @"\@{6,9}");

            if (leftSideMatch.Success && rightSideMatch.Success)
                return true;

            leftSideMatch = Regex.Match(leftSide, @"\#{6,9}");
            rightSideMatch = Regex.Match(rightSide, @"\#{6,9}");

            if (leftSideMatch.Success && rightSideMatch.Success)
                return true;

            leftSideMatch = Regex.Match(leftSide, @"\${6,9}");
            rightSideMatch = Regex.Match(rightSide, @"\${6,9}");

            if (leftSideMatch.Success && rightSideMatch.Success)
                return true;

            leftSideMatch = Regex.Match(leftSide, @"\^{6,9}");
            rightSideMatch = Regex.Match(rightSide, @"\^{6,9}");

            if (leftSideMatch.Success && rightSideMatch.Success)
                return true;

            else
                return false;
        }

        private static bool CheckIfJackpot(string ticket)
        {
            if (Regex.Match(ticket, @"(\@{20}|\#{20}|\${20}|\^{20})").Success)
                return true;
            else
                return false;
        }

        private static object FindCount(string leftSide, string rightSide, char symbol)
        {
            var leftSideCount = 0;
            var rightSideCount = 0;

            for (int i = 0; i < leftSide.Length; i++)
            {
                if (leftSide[i] == symbol)
                    leftSideCount++;
            }

            for (int i = 0; i < rightSide.Length; i++)
            {
                if (rightSide[i] == symbol)
                    rightSideCount++;
            }

            return Math.Min(leftSideCount, rightSideCount);
        }
    }
}
