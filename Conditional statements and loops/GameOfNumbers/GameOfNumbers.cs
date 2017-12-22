using System;

namespace GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var numN = 0;
            var numM = 0;
            var combinations = 0;

            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    if ((i + j) == magicNum)
                    {
                        numN = i;
                        numM = j;
                    }
                    combinations++;
                }
            }

            if (numN == 0 && numM == 0)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
            else
            {
                Console.WriteLine($"Number found! {numN} + {numM} = {magicNum}");
            }
        }
    }
}
