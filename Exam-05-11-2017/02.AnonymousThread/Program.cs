using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(' ').ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] toDo = input.Split(' ').ToArray();
                string command = toDo[0];
                int startPosition = int.Parse(toDo[1]);
                if (startPosition < 0)
                {
                    startPosition = 0;
                }
                if (startPosition >= data.Count)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (command == "merge")
                {
                    int endPosition = int.Parse(toDo[2]);
                    Merge(data, startPosition, endPosition);
                }
                else if (command == "divide")
                {
                    int parts = int.Parse(toDo[2]);
                    Divide(data, startPosition, parts);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", data));

        }

        static void Merge(List<string> data, int startPosition, int endPosition)
        {
            if (endPosition < 0)
            {
                return;
            }
            if (endPosition >= data.Count)
            {
                endPosition = data.Count - 1;
            }
            if (startPosition >= endPosition)
            {
                return;
            }

            for (int i = startPosition + 1; i <= endPosition; i++)
            {
                data[startPosition] += data[i];
            }
            data.RemoveRange(startPosition + 1, (endPosition - startPosition));

            return;
        }

        static void Divide(List<string> data, int startPosition, int pieces)
        {
            string word = data[startPosition];
            int lettersPerWord = word.Length / pieces;
            List<string> toInsert = new List<string>();

            if (lettersPerWord == 0)
            {
                for (int i = 0; i < pieces; i++)
                {
                    toInsert.Add("");
                }
                toInsert.Add(word);
                data.RemoveAt(startPosition);
                data.InsertRange(startPosition, toInsert);
                return;
            }
            string currentWord = "";
            for (int i = 0; i < pieces - 1; i++)
            {
                currentWord = word.Substring(i * lettersPerWord, lettersPerWord);
                toInsert.Add(currentWord);
            }
            currentWord = word.Substring((pieces - 1) * lettersPerWord, word.Length - (pieces - 1) * lettersPerWord);
            toInsert.Add(currentWord);

            data.RemoveAt(startPosition);
            data.InsertRange(startPosition, toInsert);
        }
    }
}
