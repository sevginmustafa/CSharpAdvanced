using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Trainer> trainers = new List<Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] info = input.Split();

                string trainerName = info[0];
                string pokemonName = info[1];
                string pokemonElement = info[2];
                int pokemonHealth = int.Parse(info[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.Any(x => x.Name == trainerName))
                {
                    foreach (var trainer in trainers)
                    {
                        if (trainer.Name == trainerName)
                        {
                            trainer.Pokemons.Add(pokemon);
                            break;
                        }
                    }
                }
                else
                {
                    Trainer trainer = new Trainer(trainerName);

                    trainer.Pokemons.Add(pokemon);

                    trainers.Add(trainer);
                }
            }


            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == input))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;

                            if (pokemon.Health <= 0)
                            {
                                trainer.Pokemons.Remove(pokemon);
                                break;
                            }
                        }
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
