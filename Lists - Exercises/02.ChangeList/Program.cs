using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "Odd" && command != "Even")
            {
                string[] toDo = command.Split(' ');
                if (toDo[0] == "Delete")
                {
                    int num = int.Parse(toDo[1]);
                    input.RemoveAll(item => item == num);
                }
                else if (toDo[0] == "Insert")
                {
                    int num = int.Parse(toDo[1]);
                    int index = int.Parse(toDo[2]);
                    input.Insert(index, num);
                }
                command = Console.ReadLine();
            }

            if (command == "Even")
            {
                foreach (var item in input)
                {
                    if(item % 2 == 0)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            else if (command == "Odd")
            {
                foreach (var item in input)
                {
                    if (item % 2 != 0)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
