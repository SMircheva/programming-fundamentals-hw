using System;

namespace NumOfInts
{
    class NumOfInts
    {
        static void Main(string[] args)
        {
            int n;
            bool isInt = true;
            int count = 0;

            do
            {
                var input = Console.ReadLine();
                isInt = int.TryParse(input, out n);
                count++;
            } while (isInt);
            Console.WriteLine(count - 1);
        }
    }
}
