using System;

namespace ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main(string[] args)
        {
            var proff = Console.ReadLine();
            var q = int.Parse(Console.ReadLine());
            var totalP = 0.0;
      
            switch (proff)
            {
                case "Athlete":
                    totalP = q * 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalP = q * 1;
                    break;
                case "SoftUni Student":
                    totalP = q * 1.7;
                    break;
                default:
                    totalP = q * 1.2;
                    break;
            }

            Console.WriteLine($"The {proff} has to pay {totalP:F2}.");
        }
    }
}
