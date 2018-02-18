using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine()
                .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            while (commands[0] != "end")
            {
                var IP = commands[1];
                var username = commands[commands.Length - 1];
                if (users.ContainsKey(username))
                {
                    if (users[username].ContainsKey(IP))
                    {
                        users[username][IP]++;
                    } else
                    {
                        users[username].Add(IP, 1);
                    }

                } else
                {
                    var nestedDic = new Dictionary<string, int>();
                    nestedDic.Add(IP, 1);
                    users.Add(username, nestedDic);
                }
                commands = Console.ReadLine()
                .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.Key + ":");
                List<string> helper = new List<string>();
                foreach (var ipAddress in user.Value)
                {
                    helper.Add($"{ipAddress.Key} => {ipAddress.Value}");
                    
                }
                Console.Write(string.Join(", ", helper));
                Console.WriteLine(".");
            }
        }
    }
}
