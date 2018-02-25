using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultuplyer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string w1 = input[0];
            string w2 = input[1];

            Console.WriteLine(CharMultiply(w1, w2));
        }

        static int CharMultiply (string w1, string w2)
        {
            int sum = 0;
            for (int i = 0; i < Math.Min(w1.Length, w2.Length); i++)
            {
                sum += w1[i] * w2[i];
            }

            for (int i = Math.Min(w1.Length, w2.Length); i < Math.Max(w1.Length, w2.Length); i++)
            {
                try
                {
                    sum += w1[i];
                }
                catch
                {
                    sum += w2[i];
                }
            }

            return sum;
        }
    }
}
