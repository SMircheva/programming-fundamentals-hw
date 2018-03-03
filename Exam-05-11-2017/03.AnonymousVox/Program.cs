using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([a-zA-Z]+)(.+)(\1)";
            string encodedText = Console.ReadLine();
            string[] placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            MatchCollection matches = Regex.Matches(encodedText, pattern);

            for (int i = 0; i < Math.Min(placeholders.Length, matches.Count); i++)
            {
                string currentValue = matches[i].Value.ToString();
                string changeTo = matches[i].Groups[1].Value + placeholders[i] + matches[i].Groups[3].Value;
                encodedText = ReplaceFirst(encodedText, currentValue, changeTo);                
            }
            Console.WriteLine(encodedText);
        }

        static string ReplaceFirst(string oldText, string oldValue, string newValue)
        {
            string firstSubstring = oldText.Substring(0, oldText.IndexOf(oldValue) + oldValue.Length);
            string secondSubstring = oldText.Substring(oldText.IndexOf(oldValue) + oldValue.Length, oldText.Length - firstSubstring.Length);
            Regex regex = new Regex(oldValue);

            firstSubstring = regex.Replace(firstSubstring, newValue);
            return firstSubstring + secondSubstring;

        }
    }
}
