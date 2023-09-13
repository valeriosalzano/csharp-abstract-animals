using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animal
    {
        public static void Sleep()
        {
            Console.WriteLine("Zzz");
        }

        public abstract void Verse();

        public abstract void RequiredFood();

    }
}
