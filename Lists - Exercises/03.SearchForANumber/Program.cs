using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> toDo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> processed = new List<int>();

            // shorter option
            //if (input.Take(toDo[0]).Skip(toDo[1]).Contains(toDo[2]))

            for (int i = 0; i < toDo[0]; i++)
            {
                processed.Add(input[i]);
            }
            for (int i = 0; i < toDo[1]; i++)
            {
                input.RemoveAt(0);
            }
            bool output = false;
            foreach (var item in input)
            {
                if (item == toDo[2])
                {
                    output = true;
                    break;
                }
            }
            if (output)
            {
                Console.WriteLine("YES!");
            } else
            {
                Console.WriteLine("NO!");

            }
        }
    }
}
