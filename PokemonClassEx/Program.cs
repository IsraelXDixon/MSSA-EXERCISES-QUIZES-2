using System;

namespace CSharpEx6_dixon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C# Exercise 6");
            Pokemon Trainer = new Pokemon();
            PokeDark Umbreon = new PokeDark();
            PokePsy Espeon = new PokePsy();
            PokeElec Pikachu = new PokeElec();
            PokeFire Charizard = new PokeFire();



            Console.WriteLine(" ");
            Console.WriteLine("Pokemon Trainer Red has challenged you to a Pokemon Battle!");
            Console.WriteLine("I choose you Espeon and Umbreon!");
            Console.WriteLine("Pokemon Trainer Red selects Charizard and Pikachu.");
            Console.WriteLine(" ");
            Console.WriteLine("Your turn");
            Trainer.Attack("Espeon use 'Psybeam' on Charizard!");
            Espeon.Attack("Espeon hits Charizard with Psybeam");
            Trainer.Attack("Umbreon use 'Crunch' on Pikachu!");
            Umbreon.Attack("Umbreon hits Pikachu with Crunch");

            Console.WriteLine(" ");
            Console.WriteLine("Trainer Red's turn");
            Trainer.Attack("Charizard use 'FlameThrower' on Umbreon!");
            Charizard.Attack("Charizard hits Umbreon with FlameThrower");
            Trainer.Attack("Pikachu use 'Iron Tail' on Espeon!");
            Pikachu.Attack("Pikachu hits Espeon with Iron Tail");


            Console.WriteLine(" ");
            Console.WriteLine("Your turn");
            Trainer.Attack("Espeon use 'Future Sight' on Pikachu!");
            Espeon.Attack("Espeon hits Pikachu with Future Sight");
            Console.WriteLine("Pikachu will take damage two turns later");
            Trainer.Attack("Umbreon use 'Thief' on Charizard!");
            Umbreon.Attack("Umbreon hits Charizard with Thief");
            Console.WriteLine("Umbreon stole an Oran Berry.");

            Console.WriteLine(" ");
            Console.WriteLine("Trainer Red's turn");
            Trainer.Attack("Charizard use 'Flare Blitz' on Umbreon!");
            Charizard.Attack("Charizard hits Umbreon with Flare Blitz");
            Console.WriteLine("Umbreon is now Burned");
            Trainer.Heal("Pikachu drink this potion!");
            Pikachu.Heal("Pikachu drinks Hyper Potion(250 HP was recovered.)");

            Console.WriteLine(" ");
            Console.WriteLine("Your Turn");
            Trainer.Heal("Umbreon take this!");
            Umbreon.Heal("Umbreon drinks Max Potion(All HP was fully recovered.)");
            Trainer.Attack("Espeon use 'Pyschic' on Charizard!");
            Espeon.Attack("Espeon hits Charizard with Psychic(It was a Critical Hit!)");
            Charizard.Faint("Charizards HP is 0(Charizard Faints)");
            Trainer.Faint(" Trainer Red throws PokeBall at Charizard ''You did well Charizard.'' ");

            Console.WriteLine(" ");
            Console.WriteLine("Trainer Red's Turn");
            Trainer.Attack("Pikachu use 'Volt Tackle' on Espeon!");
            Pikachu.Attack("Pikachu hits Espeon with Volt Tackle");
            Console.WriteLine("Pikachu takes recoil damage");
            Espeon.Faint("Espeons HP is 0(Espeon Faints)");
            Trainer.Faint("You threw a PokeBall at Espeon ''Thank you for fighting.''");

            Console.WriteLine(" ");
            Console.WriteLine("Your turn");
            Console.WriteLine("Espeons Future Sight takes effect on Pikachu(Pikachu loses over half of its HP)");
            Trainer.Attack("Umbreon Finish this battle with 'Foul Play'");
            Umbreon.Attack("Umbreon hits Pikachu with Foul play");
            Pikachu.Faint("Pikachu HP is 0(Pikachu Faints)");
            Trainer.Faint("Trainer Red picks up Pikachu ''Get some rest Pikachu.''");

            Console.WriteLine(" ");
            Console.WriteLine("The battle is over. Congratulations on you victory!");
            Console.WriteLine("You won $50,000 Pokedollars.");
        }
    }
}
