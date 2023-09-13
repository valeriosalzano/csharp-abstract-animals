using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Goose : Animal, ICanFly, ICanSwim
    {
        public void Fly()
        {
            Console.Write("Sto volando, Jack! ");
            this.Verse();
        }

        public void Swim()
        {
            Console.Write("Nuota e nuota, zitto e nuota. ");
            this.Verse();
        }
        public override void RequiredFood()
        {
            Console.WriteLine("Semi");
        }

        public override void Verse()
        {
            Console.WriteLine("Qua Qua");
        }
    }
}
