using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SnowwhiteDwarfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dwarf>> dwarvesToColor = new Dictionary<string, List<Dwarf>>();
            List<Dwarf> dwarves = new List<Dwarf>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Once upon a time")
                {
                    break;
                }

                var dwarvesInfo = input.Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = dwarvesInfo[0];
                string color = dwarvesInfo[1];
                int physics = int.Parse(dwarvesInfo[2]);

                Dwarf dwarf = new Dwarf();
                dwarf.Name = name;
                dwarf.Color = color;
                dwarf.Physics = physics;

                if (!dwarvesToColor.ContainsKey(color))
                {
                    // add dwarf and color
                    dwarvesToColor[color] = new List<Dwarf>();
                    dwarves.Add(dwarf);
                    dwarvesToColor[color].Add(dwarf);
                }
                else if (!dwarves.Any(x => x.Name == name))
                {
                    //add dwarf only
                    dwarvesToColor[color].Add(dwarf);
                    dwarves.Add(dwarf);
                }
                else
                {
                    //check physics
                    
                }


            }

            dwarves = dwarves.OrderByDescending(d => d.Physics)
                .ThenByDescending(d => dwarvesToColor[d.Color].Count)
                .ToList();

            foreach (var item in dwarves)
            {
                Console.WriteLine($"({item.Color}) {item.Name} <-> {item.Physics}");
            }

        }


        class Dwarf
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public int Physics { get; set; }
        }
    }
}
