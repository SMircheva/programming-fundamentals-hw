using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex email = new Regex(@"(^|(?<=\s))([a-z0-9])+([_\.-]?[a-z0-9])*@[a-z0-9]+([-.a-z0-9])*\.([a-z0-9]+)([-.a-z0-9][a-z]+)*");
            string text = Console.ReadLine();
            var allEmails = email.Matches(text);

            foreach (Match item in allEmails)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
