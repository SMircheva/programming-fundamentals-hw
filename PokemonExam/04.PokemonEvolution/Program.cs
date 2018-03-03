using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Pokemon>> pokemons = new Dictionary<string, List<Pokemon>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "wubbalubbadubdub")
                {
                    break;
                }
                var inputArr = input.Split(new char[] {' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputArr.Length == 1)
                {
                    //check if pokemon exists
                    if (!pokemons.ContainsKey(input))
                    {
                        continue;
                    }

                    var pokemonToPrint = pokemons[inputArr[0]];

                    //print pokemon
                    Console.WriteLine($"# {inputArr[0]}");
                    foreach (var pok in pokemonToPrint)
                    {
                        Console.WriteLine($"{pok.Evolution} <-> {pok.EvIndex}");
                    }
                    continue;
                }

                string name = inputArr[0];
                string evolution = inputArr[1];
                int index = int.Parse(inputArr[2]);

                var currentPokemon = new Pokemon();
                currentPokemon.Evolution = evolution;
                currentPokemon.EvIndex = index;
                if (!pokemons.ContainsKey(name))
                {
                    //create pokemon                    
                    List<Pokemon> pList = new List<Pokemon>();
                    pList.Add(currentPokemon);
                    pokemons.Add(name, pList);
                }
                else
                {
                    //add evolution
                    pokemons[name].Add(currentPokemon);
                }

            }

            foreach (var pokemonEvolutions in pokemons)
            {
                Console.WriteLine($"# {pokemonEvolutions.Key}");
                foreach (var pokemon in pokemonEvolutions.Value.OrderByDescending(x => x.EvIndex))
                {
                    Console.WriteLine($"{pokemon.Evolution} <-> {pokemon.EvIndex}");
                }
            }

        }

        class Pokemon
        {
            public string Evolution { get; set; }
            public int EvIndex { get; set; }
        }
    }
}
