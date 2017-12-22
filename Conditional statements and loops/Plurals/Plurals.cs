using System;

namespace Plurals
{
    class Plurals
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            string lastOne = word.Substring(word.Length - 1);
            string lastTwo = word.Substring(word.Length - 2);

            if (lastOne == "y")
            {
                word = word.Substring(0, word.Length - 1) + "ies";
            }
            else if (lastOne == "o" || lastOne == "s" || lastOne == "x" || lastOne == "z")
            {
                word += "es";
            }
            else if (lastTwo == "ch" || lastTwo == "sh")
            {
                word += "es";
            }
            else
            {
                word += "s";
            }

            Console.WriteLine(word);
                 
            

        }
    }
}
