using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Eagle : Animal, ICanFly
    {
        public void Fly()
        {
            Console.Write("Sto volando, Jack! ");
            this.Verse();
        }
        public override void RequiredFood()
        {
            Console.WriteLine("Carne");
        }

        public override void Verse()
        {
            Console.WriteLine("Cra cra");
        }
    }
}
