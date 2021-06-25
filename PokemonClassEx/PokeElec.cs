using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx6_dixon
{
    class PokeElec : Pokemon
    {
        public override void Attack(string Action)
        {
            Console.WriteLine($"Pikachu:{Action}");
        }
        public override void Heal(string Action)
        {
            Console.WriteLine($"Pikachu:{Action}");
        }
        public override void Faint(string Action)
        {
            Console.WriteLine($"Pikachu:{Action}");
        }
    }
}
