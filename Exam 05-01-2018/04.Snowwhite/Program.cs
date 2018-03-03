using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<Dictionary<string, int>>> dwarves = new Dictionary<string, List<Dictionary<string, int>>>();

            while (input != "Once upon a time")
            {
                string[] dwarfProperties = input.Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currentName = dwarfProperties[0];
                string currentColor = dwarfProperties[1];
                int currentPhysics = int.Parse(dwarfProperties[2]);

                if (!dwarves.ContainsKey(currentColor))
                {
                    Dictionary<string, int> currentDwarf = new Dictionary<string, int>();
                    currentDwarf.Add(currentName, currentPhysics);
                    dwarves.Add(currentColor, new List<Dictionary<string, int>>());
                    dwarves[currentColor].Add(currentDwarf);
                }
                else if (!dwarves[currentColor].Any(x => x.ContainsKey(currentName)))
                {
                    Dictionary<string, int> currentDwarf = new Dictionary<string, int>();
                    currentDwarf.Add(currentName, currentPhysics);
                    dwarves[currentColor].Add(currentDwarf);
                }
                else
                {
                    
                }
                input = Console.ReadLine();
            }

            foreach (var color in dwarves)
            {
                foreach (var dwarf in color.Value)
                {
                    foreach (var item in dwarf)
                    {
                        Console.WriteLine($"({color.Key}) {item.Key} <-> {item.Value}");
                    }
                }
            }
        }

        
    }
}
