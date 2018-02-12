using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            while (commands[0] != "print")
            {
                if (commands[0] == "add")
                {
                    input.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if (commands[0] == "addMany")
                {
                    int index = int.Parse(commands[1]);
                    input.InsertRange(index, commands.Skip(2).Select(int.Parse));
                }
                else if (commands[0] == "contains")
                {
                    if (input.Contains(int.Parse(commands[1])))
                    {
                        Console.WriteLine(input.IndexOf(int.Parse(commands[1])));
                    } else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (commands[0] == "remove")
                {
                    input.RemoveAt(int.Parse(commands[1]));
                }
                else if (commands[0] == "shift")
                {
                    int index = int.Parse(commands[1]) % input.Count;
                    List<int> temp = input.Skip(index).ToList();
                    for (int i = 0; i < index; i++)
                    {
                        temp.Add(input[i]);
                    }
                    input = temp;
                }
                else if (commands[0] == "sumPairs")
                {
                    int cycles = input.Count/2;
                    for (int i = 0; i < cycles; i++)
                    {
                        input[i] += input[i + 1];
                        input.RemoveAt(i + 1);
                    }
                }

                commands = Console.ReadLine().Split(' ').ToArray();

            }
            
            Console.WriteLine($"[{string.Join(", ", input)}]");

        }
      
    }
}
