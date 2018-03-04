using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, DataSet> data = new Dictionary<string, DataSet>();
            Dictionary<string, DataSet> cache = new Dictionary<string, DataSet>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "thetinggoesskrra")
                {
                    break;
                }

                string[] commands = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands.Length == 1)
                {
                    // add dataset
                    string currentName = commands[0];
                    if (data.ContainsKey(currentName))
                    {
                        continue;
                    }
                    data.Add(currentName, new DataSet());
                    data[currentName].Keys = new List<string>();
                    //what if it exists? - possible issue

                    //chech if there is info for it in the cache and add it
                    if (cache.ContainsKey(currentName))
                    {
                        var cachedData = cache[currentName];
                        cache.Remove(currentName);
                        data[currentName] = cachedData;
                    }
                }

                else
                {
                    string currentName = commands[2];
                    string currentKey = commands[0];
                    long currentSize = long.Parse(commands[1]);

                    //check if dataset exists                    
                    //if it exists - add to data set
                    if (data.ContainsKey(currentName))
                    {                        
                        data[currentName].Keys.Add(currentKey);
                        data[currentName].Size += currentSize;
                    }

                    // if it doesn't exist - add to cache
                    else
                    {
                        if (cache.ContainsKey(currentName))
                        {
                            cache[currentName].Keys.Add(currentKey);
                            cache[currentName].Size += currentSize;
                        }
                        else
                        {
                            DataSet toAdd = new DataSet();
                            toAdd.Keys = new List<string>();
                            toAdd.Keys.Add(currentKey);
                            toAdd.Size = currentSize;
                            cache.Add(currentName, toAdd);
                        }
                    }
                }
            }

            var maxName = "";
            long maxSize = 0;
            var maxKeys = new List<string>();

            foreach (var dataItem in data)
            {
                if (dataItem.Value.Size > maxSize)
                {
                    maxSize = dataItem.Value.Size;
                    maxName = dataItem.Key;
                    maxKeys = dataItem.Value.Keys;
                }
            }

            if (data.Count == 0)
            {
                return;
            }
            if (maxSize == 0)
            {
                return;
            }


            Console.WriteLine($"Data Set: {maxName}, Total Size: {maxSize}");
            foreach (var key in maxKeys)
            {
                Console.WriteLine($"$.{key}");
            }
        }

        public class DataSet
        {
            public List<string> Keys { get; set; }
            public long Size { get; set; }
        }
    }
}
