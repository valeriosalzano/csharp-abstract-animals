using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Cow : Animal
    {
        public override void RequiredFood()
        {
            Console.WriteLine("Erba");
        }

        public override void Verse()
        {
            Console.WriteLine("Muuuu");
        }
    }
}
