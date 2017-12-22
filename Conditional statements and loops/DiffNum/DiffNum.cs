using System;

namespace DiffNum
{
    class DiffNum
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if ((b - a) < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = a; i <= b - 4; i++)
                {
                    for (int j = a + 1; j <= b - 3; j++)
                    {
                        for (int k = a + 2; k <= b - 2; k ++)
                        {
                            for (int l = a + 3; l <= b - 1; l++)
                            {
                                for (int m = a + 4; m <= b; m++)
                                {
                                    if (i < j && j < k && k < l && l < m)
                                    {
                                        Console.WriteLine($"{i} {j} {k} {l} {m}");
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
