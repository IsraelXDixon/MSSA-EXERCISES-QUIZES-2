using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx6_dixon
{
    class PokeDark : Pokemon
    {
        public override void Attack(string Action)
        {
            Console.WriteLine($"Umbreon:{Action}");
        }
        public override void Heal(string Action)
        {
            Console.WriteLine($"Umbreon:{Action}");
        }
        public override void Faint(string Action)
        {
            Console.WriteLine($"Umbreon:{Action}");
        }
    }
}
