using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Dolphin : Animal, ICanSwim
    {
        public void Swim()
        {
            Console.Write("Nuota e nuota, zitto e nuota. ");
            this.Verse();
        }
        public override void RequiredFood()
        {
            Console.WriteLine("Pesce");
        }

        public override void Verse()
        {
            Console.WriteLine(".#?!@#!*");
        }
    }
}
