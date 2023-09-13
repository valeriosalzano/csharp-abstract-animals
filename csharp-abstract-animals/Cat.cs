using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cat : Animal
    {
        public override void RequiredFood()
        {
            Console.WriteLine("Carne");
        }

        public override void Verse()
        {
            Console.WriteLine("Miao");
        }
    }
}
