using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            string textToSerach = Console.ReadLine();
            //string keys = @"([a-zA-Z]+)[|<\\]?.+[|.\\]([a-zA-Z]+)";
            string keys = @"([a-zA-Z]+)[|<\\]?.+[|.\\]([a-zA-Z]+)";


            string start = Regex.Match(input1,keys).Groups[1].ToString();
            string end = Regex.Match(input1, keys).Groups[2].Value;
            string patter2 = $@"{start}(.*?){end}";
            StringBuilder builder = new StringBuilder();

            MatchCollection results = Regex.Matches(textToSerach, patter2);
            
            
            
            foreach (Match m in results)
            {
                builder.Append(m.Groups[1].Value);
            }            

            if (builder.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(builder);
            }
        
        }
    }
}
