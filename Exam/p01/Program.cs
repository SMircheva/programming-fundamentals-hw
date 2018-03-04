using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robesPrise = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double moneyNeeded = 0.0;
            int sabresNeeded = (int)Math.Ceiling(students * 1.1);
            int freeBelts = students / 6;

            moneyNeeded = sabresNeeded * sabrePrice + students * robesPrise + (students - freeBelts) * beltsPrice;

            double diff = money - moneyNeeded;

            if (diff < 0)
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(diff):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
        }
    }
}
