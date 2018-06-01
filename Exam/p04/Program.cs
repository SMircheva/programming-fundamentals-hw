using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }
                string[] request = input.Split("|->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                                
                if (input.Contains("|")) //this is an add request
                {
                    string forceSide = request[0].Trim();
                    string forceUser = request[1].Trim();
                    if (!sides.ContainsKey(forceSide))
                    {
                        // this force side doesn't exist - add it
                        List<string> listToAdd = new List<string>();
                        listToAdd.Add(forceUser);
                        sides.Add(forceSide, listToAdd);
                    }
                    else if (!sides.Values.Any(x => x.Contains(forceUser)))
                    {
                        // this user is not on any side - add it to where he wants
                        sides[forceSide].Add(forceUser);
                    }
                    else
                    {
                        //he esists - don't do anything (probably - possible issue)
                        
                    }
                }
                else if (input.Contains("->")) // this is a move request
                {
                    string forceSide = request[1].Trim();
                    string forceUser = request[0].Trim();
                    if (!sides.ContainsKey(forceSide))
                    {
                        // remove him from wherever he is and create new force                        
                        foreach (var kvp in sides)
                        {
                            if (kvp.Value.Contains(forceUser))
                            {
                                kvp.Value.Remove(forceUser);
                            }
                        }
                        List<string> listToAdd = new List<string>();
                        listToAdd.Add(forceUser);
                        sides.Add(forceSide, listToAdd);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                    }
                   /* else if (!sides.Values.Any(x => x.Contains(forceUser)))
                    {
                        // this user is not currently on any side - add him to whereever he wants
                        sides[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }*/
                    else if (sides[forceSide].Contains(forceUser))
                    {
                        //he's already where he wants - do nothing                      
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                    }
                    else
                    {
                        //remove user from the side where he is and add to the one he requests
                        foreach (var kvp in sides)
                        {
                            if (kvp.Value.Contains(forceUser))
                            {
                                kvp.Value.Remove(forceUser);
                            }
                        }
                        sides[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                    }
                }
            }

            foreach (var side in sides.OrderByDescending(x => x.Value.Count).ThenBy(k => k.Key))
            {
                if (side.Value.Count == 0)
                {
                    //do nothing
                }
                else
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    foreach (var user in side.Value.OrderBy(u => u))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
