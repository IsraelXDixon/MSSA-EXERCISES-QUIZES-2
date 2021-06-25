using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx6_dixon
{
    class PokePsy : Pokemon
    {
        public override void Attack(string Action)
        {
            Console.WriteLine($"Espeon:{Action}");
        }
        public override void Heal(string Action)
        {
            Console.WriteLine($"Espeon:{Action}");
        }
        public override void Faint(string Action)
        {
            Console.WriteLine($"Espeon:{Action}");
        }
    }
}
