using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var cards = new Dictionary<string, List<string>>();
            var commandRaw = Console.ReadLine()
                .Split(':')
                .ToArray();
            

            while (commandRaw[0] != "JOKER")
            {
                var command = commandRaw[1]
                .Split(new char[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                var player = commandRaw[0];
                if (cards.ContainsKey(player))
                {
                    for (int i = 0; i < command.Length; i++)
                    {
                        if (!cards[player].Contains(command[i]))
                        {
                            cards[player].Add(command[i]);
                        }
                    }
                }
                else
                {
                    cards.Add(player, new List<string>());
                    for (int i = 0; i < command.Length; i++)
                    {
                        if (!cards[player].Contains(command[i]))
                        {
                            cards[player].Add(command[i]);
                        }
                    }
                }
                commandRaw = Console.ReadLine()
                .Split(':')
                .ToArray();
            }

            var totals = new Dictionary<string, int>();
            foreach (var player in cards)
            {
                var listofCards = player.Value;
                int points = 0;
                int totalPoints = 0;
                for (int i = 0; i < listofCards.Count; i++)
                {
                    string currentCard = listofCards[i];                    
                    switch (currentCard[0])
                    {
                        case '1':
                            points = 10;
                            break;
                        case '2':
                            points = 2;
                            break;
                        case '3':
                            points = 3;
                            break;
                        case '4':
                            points = 4;
                            break;
                        case '5':
                            points = 5;
                            break;
                        case '6':
                            points = 6;
                            break;
                        case '7':
                            points = 7;
                            break;
                        case '8':
                            points = 8;
                            break;
                        case '9':
                            points = 9;
                            break;
                        case 'J':
                            points = 11;
                            break;
                        case 'Q':
                            points = 12;
                            break;
                        case 'K':
                            points = 13;
                            break;
                        case 'A':
                            points = 14;
                            break;
                    }
                    char multiplier = currentCard.Last();
                    switch (multiplier)
                    {
                        case 'S':
                            points *= 4;
                            break;
                        case 'H':
                            points *= 3;
                            break;
                        case 'D':
                            points *= 2;
                            break;
                        case 'C':
                            points *= 1;
                            break;
                    }

                    totalPoints += points;
                    points = 0;
                }
                totals.Add(player.Key, totalPoints);

            }

            foreach (var player in totals)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }
    }
}
