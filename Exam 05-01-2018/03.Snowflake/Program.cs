using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string surfacePattern = @"^[\W_]+$";
            string mantlePattern = @"^[0-9_]+$";
            string corePattern = @"^[\W_]+[0-9_]+([a-zA-Z]+)[0-9_]+[\W_]+$";

            string surfaceOne = Console.ReadLine();
            string mantleOne = Console.ReadLine();
            string core = Console.ReadLine();
            string mantleTwo = Console.ReadLine();
            string surfaceTwo = Console.ReadLine();

            bool isValid = true;

            if (!Regex.IsMatch(surfaceOne, surfacePattern))
            {
                isValid = false;
            }
            else if (!Regex.IsMatch(surfaceTwo, surfacePattern))
            {
                isValid = false;
            }
            else if (!Regex.IsMatch(mantleOne, mantlePattern))
            {
                isValid = false;
            }
            else if (!Regex.IsMatch(mantleTwo, mantlePattern))
            {
                isValid = false;
            }

            if (!isValid || !Regex.IsMatch(core, corePattern))
            {
                Console.WriteLine("Invalid");
                return;
            }

            string corePart = Regex.Match(core, corePattern).Groups[1].Value;
            Console.WriteLine("Valid");
            Console.WriteLine(corePart.Length);
            

        }
    }
}
