using System;

namespace TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());

            var sum = 0;
            var combinationsNum = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    sum += i * j * 3;
                    combinationsNum++;
                    if (sum >= maxSum)
                    {
                        break;
                    }
                }
                if (sum >= maxSum)
                {
                    break;
                }
            }

            Console.WriteLine($"{combinationsNum} combinations");
            if (sum >= maxSum)
            {
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
