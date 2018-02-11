using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> textList = Console.ReadLine()
                .Split('|')
                .ToList();
            textList.Reverse();

            foreach(var text in textList)
            {
                List<string> current = text.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();
                Console.Write(string.Join(" ", current) + " ");
            }
            Console.WriteLine();
        }
    }
}
