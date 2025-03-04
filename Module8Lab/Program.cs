using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Level { get; set; }
} //end class Pokemon

class PokemonLINQLab
{
    static void Main()
    {
        // list of pokemon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass", Level = 15 },
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 36 },
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10 },
            new Pokemon { Id = 4, Name = "Pikachu", Type = "Electric", Level = 22 },
            new Pokemon { Id = 5, Name = "Eevee", Type = "Normal", Level = 25 }
        };

        // LINQ Query to find pokemon ready to evolve (level 16 for first evolution)
        var readyToEvolveQuery = from p in pokemons // every item in list
                                 where p.Level >= 16
                                 orderby p.Level // order asc level
                                 select p; // assign

        // Execute the query and display the results
        Console.WriteLine("Pokémon Ready to Evolve:");
        foreach (var pokemon in readyToEvolveQuery) // loop thru each item in list
        {
            Console.WriteLine($"Name: {pokemon.Name}, Type: {pokemon.Type}, Level: {pokemon.Level}");
        }
        // part 2
        var firePokemons = from p in pokemons
                           where p.Type == "Fire" // "=" != "=="
                           orderby p.Name
                           select p;
        Console.WriteLine("Fire type Pokémons:");
        foreach (var pokemon in firePokemons) // loop thru each item in list
        {
            Console.WriteLine($"Name: {pokemon.Name}");
        }
    } // end Main()
} // end class PokemonLINQLab