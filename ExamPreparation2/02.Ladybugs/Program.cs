using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];
            var ladybugIndexes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(i => i >= 0 && i < size).ToArray();

            foreach (var index in ladybugIndexes)
            {
                field[index] = 1; //has ladybug
            }


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] commandsArray = command.Split(' ').ToArray();
                int startPosition = int.Parse(commandsArray[0]);
                string direction = commandsArray[1];
                int moveBy = int.Parse(commandsArray[2]);

                if (direction == "left")
                {
                    moveBy *= -1;
                }

                if (startPosition < 0 || startPosition >= ladybugIndexes.Length)
                {
                    continue;
                }

                if (ladybugIndexes[startPosition] == 0)
                {
                    continue;
                }

                ladybugIndexes[startPosition] = 0;
                int indexToFlyTo = startPosition + moveBy;


                command = Console.ReadLine();
            }

        }
    }
}
