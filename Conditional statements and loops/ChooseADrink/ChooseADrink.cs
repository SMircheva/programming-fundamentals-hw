using System;

namespace ChooseADrink
{
    class ChooseADrink
    {
        static void Main(string[] args)
        {
            var proff = Console.ReadLine();

            switch (proff) {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
