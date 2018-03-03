using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            ulong securityKey = ulong.Parse(Console.ReadLine());
            ulong securityToken = 1;
            decimal totalLoss = 0.0M;

            List<string> websites = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                websites.Add(input[0]);
                decimal currentLoss = ulong.Parse(input[1]) * decimal.Parse(input[2]);
                totalLoss += currentLoss;
                securityToken *= securityKey;
            }
            //securityToken = Math.Pow(securityKey, websites.Count);

            foreach (var site in websites)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }


    }
}
