using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animal
    {
        public int SleepCyclesCounter { get; private set; } = 0;
        public void Sleep()
        {
            Console.WriteLine("Zzz");
            this.SleepCyclesCounter++;
        }

        public abstract void Verse();

        public abstract void RequiredFood();

    }
}
