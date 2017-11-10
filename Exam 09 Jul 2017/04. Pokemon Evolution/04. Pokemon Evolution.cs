using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    public class Evolutions
    {
        public string EvolutionType { get; set; }
        public int EvolutionIndex { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Dictionary<string, List<Evolutions>> evolutionDict = new Dictionary<string, List<Evolutions>>();

            while (input != "wubbalubbadubdub")
            {
                var inputArgs = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputArgs.Length > 1)
                {
                    string pokemonName = inputArgs[0];
                    string evolutionType = inputArgs[1];
                    int index = int.Parse(inputArgs[2]);

                    Evolutions newEvo = new Evolutions();
                    newEvo.EvolutionType = evolutionType;
                    newEvo.EvolutionIndex = index;

                    if (!evolutionDict.ContainsKey(pokemonName))
                    {
                        evolutionDict[pokemonName] = new List<Evolutions>();
                    }

                    evolutionDict[pokemonName].Add(newEvo);
                }
                else
                {
                    string pokemonName = inputArgs[0];

                    if (evolutionDict.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");

                        foreach (var evolution in evolutionDict[pokemonName])
                        {
                            Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var name in evolutionDict)
            {
                Console.WriteLine($"# {name.Key}");

                foreach (var evolution in name.Value.OrderByDescending(x => x.EvolutionIndex))
                {
                    Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
                }
            }
        }
    }
}
