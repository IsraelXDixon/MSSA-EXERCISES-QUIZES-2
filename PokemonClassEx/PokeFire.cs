using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx6_dixon
{
    class PokeFire : Pokemon
    {
        public override void Attack(string Action)
        {
            Console.WriteLine($"Charizard:{Action}");
        }
        public override void Heal(string Action)
        {
            Console.WriteLine($"Charizard:{Action}");
        }
        public override void Faint(string Action)
        {
            Console.WriteLine($"Charizard:{Action}");
        }
    }
}
