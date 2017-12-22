using System;

namespace CakeIngredients
{
    class CakeIngerdients
    {
        static void Main(string[] args)
        {
            string ingredient;
            int numOfIngr = 0;

            do
            {
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    numOfIngr++;
                }
            }
            while (ingredient != "Bake!");

            Console.WriteLine($"Preparing cake with {numOfIngr} ingredients.");
        }
    }
}
