using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryItems
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool ShadowmourneObtained = false;
            bool ValanyrObrained = false;
            bool DragonwrathObtained = false;
            string resourse;
            int quantity;
            Dictionary<string, int> resourcesPrimary = new Dictionary<string, int>();
            resourcesPrimary.Add("shards", 0);
            resourcesPrimary.Add("fragments", 0);
            resourcesPrimary.Add("motes", 0);
            string prize = "";
            
            Dictionary<string, int> Junk = new Dictionary<string, int>();
            while(!ShadowmourneObtained && !ValanyrObrained && !DragonwrathObtained)
            {
                var input = Console.ReadLine().ToLower().Split(' ').ToArray();
                for (int i = 0; i < input.Length; i+= 2)
                {                    
                    quantity = int.Parse(input[i]);
                    resourse = input[i + 1];
                    if (resourcesPrimary.ContainsKey(resourse))
                    {
                        resourcesPrimary[resourse] += quantity;
                    }
                    else if (Junk.ContainsKey(resourse))
                    {
                        Junk[resourse] += quantity;
                    }
                    else
                    {
                        Junk.Add(resourse, quantity);
                    }

                    if (resourcesPrimary["shards"] >= 250)
                    {
                        ShadowmourneObtained = true;
                        prize = "Shadowmourne";
                        resourcesPrimary["shards"] -= 250;
                        break;
                    }
                    else if (resourcesPrimary["fragments"] >= 250)
                    {
                        ValanyrObrained = true;
                        prize = "Valanyr";
                        resourcesPrimary["fragments"] -= 250;
                        break;

                    }
                    else if (resourcesPrimary["motes"] >= 250)
                    {
                        DragonwrathObtained = true;
                        prize = "Dragonwrath";
                        resourcesPrimary["motes"] -= 250;
                        break;

                    }
                }
                

            }

            Console.WriteLine($"{prize} obtained!");
            foreach (var metal in resourcesPrimary.OrderByDescending(p => p.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{metal.Key}: {metal.Value}");
            }
            foreach (var metal in Junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{metal.Key}: {metal.Value}");

            }
        }
    }
}
