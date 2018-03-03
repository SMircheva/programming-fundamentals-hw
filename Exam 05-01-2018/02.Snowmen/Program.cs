using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split(' ').
                Select(int.Parse).ToList();
            List<bool> snowmenActive = new List<bool>();
            for (int i = 0; i < snowmen.Count; i++)
            {
                snowmenActive.Add(true);
            }

            while(snowmen.Count > 1)
            {            

            for (int i = 0; i < snowmen.Count; i++)
            {
                if (!snowmenActive[i])
                    {
                        continue;
                    }
                if (snowmenActive.Where(x => x == true).Count() == 1)
                    {
                        break;
                    }

                int atackerIndex = i;
                int targetIndex = snowmen[atackerIndex] % snowmen.Count;
                int indexDiff = Math.Abs(atackerIndex - targetIndex);

                if (indexDiff == 0)
                {
                    Console.WriteLine($"{atackerIndex} performed harakiri");
                    snowmenActive[atackerIndex] = false;
                }
                else if(indexDiff % 2 == 0)
                {
                    Console.WriteLine($"{atackerIndex} x {targetIndex} -> {atackerIndex} wins");
                    snowmenActive[targetIndex] = false;
                }
                else
                {
                    Console.WriteLine($"{atackerIndex} x {targetIndex} -> {targetIndex} wins");
                    snowmenActive[atackerIndex] = false;
                }
            }
            
                for (int i = 0; i < snowmenActive.Count; i++)
                {
                    if(!snowmenActive[i])
                    {
                        snowmen.RemoveAt(i);
                        snowmenActive.RemoveAt(i);
                       i--;
                    }
                }

            }
        }

        
    }
}
