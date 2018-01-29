using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFilledSquare
{
    class Program
    {
        static void DrawLine(int num)
        {
            Console.WriteLine(new string('-', 2 * num));            
        }
        static void DrawSlashes(int num)
        {
            Console.Write("-");
            for (int i = 0; i < num - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DrawLine(n);
            for (int i = 0; i < n-2; i++)
            {
                DrawSlashes(n);
            }
            DrawLine(n);

        }
    }
}
