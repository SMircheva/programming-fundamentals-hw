using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Snowwhite
{
    class Program
    {
        class DwarfInfo
        {
            string Name { get; set; }
            string Color { get; set; }
            int Physics { get; set; }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var colorsToDwarf = new Dictionary<string, DwarfInfo>();
            var allDwarves = new List<DwarfInfo>();

            while (input != "Once upon a time")
            {
                string[] dwarfProperties = input.Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currentName = dwarfProperties[0];
                string currentColor = dwarfProperties[1];
                int currentPhysics = int.Parse(dwarfProperties[2]);

                if (!colorsToDwarf.ContainsKey(currentColor))
                {
                    colorsToDwarf[currentColor] = new List<DwarfInfo>();

                }
            }
        }   


    }
}
