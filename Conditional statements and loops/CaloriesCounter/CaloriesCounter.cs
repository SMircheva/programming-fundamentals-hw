using System;

namespace CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var kcal = 0;

            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine();

                switch (ingredient.ToLower())
                {
                    case "cheese": kcal += 500;
                        break;
                    case "tomato sauce": kcal += 150;
                        break;
                    case "salami": kcal += 600;
                        break;
                    case "pepper": kcal += 50;
                        break;
                }

            }
                Console.WriteLine($"Total calories: {kcal}");
        }
    }
}
