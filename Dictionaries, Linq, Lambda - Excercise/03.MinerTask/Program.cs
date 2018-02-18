using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mined = new Dictionary<string, int>();
            string resource = Console.ReadLine();
            while (resource != "stop")
            {
                int q = int.Parse(Console.ReadLine());
                if (mined.ContainsKey(resource))
                {
                    mined[resource] += q;
                } else
                {
                    mined[resource] = q;
                }
                resource = Console.ReadLine();
            }

            foreach (var item in mined)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            } 


        }
    }
}
