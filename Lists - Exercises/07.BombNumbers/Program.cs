using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int[] commands = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int bombNumber = commands[0];
            int power = commands[1];
            while(numbers.Contains(bombNumber))
            {
                int position = numbers.IndexOf(bombNumber);
                if (position - power < 0 && position + power > numbers.Count)
                {
                    numbers.Clear();
                }
                else if (position - power < 0)
                {
                    numbers.RemoveRange(0, 1 + power + position);
                }
                else if (position + power >= numbers.Count)
                {
                    numbers.RemoveRange(position - power, 1 + power + numbers.Count - position - 1);             
                }
                else
                {
                    numbers.RemoveRange(position - power, power * 2 + 1);
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
