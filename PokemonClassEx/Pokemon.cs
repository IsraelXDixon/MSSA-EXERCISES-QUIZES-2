using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx6_dixon
{
    class Pokemon
    {
        public virtual void Attack(string Action)
        {
            Console.WriteLine($"Select Move:{Action}");
        }
        public virtual void Heal(string Action)
        {
            Console.WriteLine($"Give Potion:{Action}");
        }
        public virtual void Faint(string Action)
        {
            Console.WriteLine($"Go back in Pokeball:{Action}");
        }
    }
}
