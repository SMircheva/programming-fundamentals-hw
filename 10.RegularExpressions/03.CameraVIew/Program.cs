using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CameraView
{
    class Program
    {
        public static object MatchCollection { get; private set; }

        static void Main(string[] args)
        {
            var indexes = Console.ReadLine().Split(' ').ToArray();
            var toSkip = indexes[0];
            var toTake = indexes[1];
            string text = Console.ReadLine();

            string pattern = @"\|<([\w]{" + toSkip + @"})([\w]{0," + toTake + 
            @"})";

            MatchCollection matches = Regex.Matches(text, pattern);

            List<string> result = new List<string>();

            foreach (Match m in matches)
            {
                result.Add(m.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
