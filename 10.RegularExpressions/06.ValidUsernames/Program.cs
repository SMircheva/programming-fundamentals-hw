using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"^[a-zA-Z][\w]{2,24}$";
            List <string> usernames = new List<string>();
            Regex checkMatch = new Regex(pattern);

            for (int i = 0; i < input.Length; i++)
            {
                if (checkMatch.IsMatch(input[i]))
                {
                    usernames.Add(input[i]);
                }
            }
                       

            var bestLenght = usernames[0].Length + usernames[1].Length;
            var bestUsername1 = usernames[0];
            var bestUsername2 = usernames[1];

            if (usernames.Count == 2)
            {
                Console.WriteLine(bestUsername1);
                Console.WriteLine(bestUsername2);
                return;
            }

            for (int i = 1; i < usernames.Count - 1; i++)
            {
                if (usernames[i].Length + usernames[i+1].Length > bestLenght)
                {
                    bestLenght = usernames[i].Length + usernames[i + 1].Length;
                    bestUsername1 = usernames[i];
                    bestUsername2 = usernames[i + 1];
                }
            }

            Console.WriteLine(bestUsername1);
            Console.WriteLine(bestUsername2);

        }
    }
}
