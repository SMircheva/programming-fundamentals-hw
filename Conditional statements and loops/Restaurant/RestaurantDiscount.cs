using System;

namespace Restaurant
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            string hallSize;
            double totalPrice;
            double pricePerGuest;

            if (groupSize <= 50)
            {
                hallSize = "Small Hall";
                totalPrice = 2500;
            }
            else if (groupSize <= 100)
            {
                hallSize = "Terrace";
                totalPrice = 5000;
            }
            else if (groupSize <= 120)
            {
                hallSize = "Great Hall";
                totalPrice = 7500;
            }
            else
            {
                hallSize = "No hall";
                totalPrice = 0.0;
            }

            if (package == "Normal")
            {
                totalPrice += 500;
                totalPrice *= 0.95;
            }
            else if (package == "Gold")
            {
                totalPrice += 750;
                totalPrice *= 0.9;
            }
            else
            {
                totalPrice += 1000;
                totalPrice *= 0.85;
            }

            if (hallSize != "No hall")
            {
                pricePerGuest = totalPrice / groupSize;

                Console.WriteLine($"We can offer you the {hallSize}");
                Console.WriteLine($"The price per person is {pricePerGuest:F2}$");
            }

            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }


        }
    }
}
