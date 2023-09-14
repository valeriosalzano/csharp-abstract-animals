using System.Runtime.CompilerServices;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Goldfish());
            animals.Add(new Goose());
            animals.Add(new Dolphin());
            animals.Add(new Eagle());
            animals.Add(new Cow());

            foreach (Animal animal in animals) 
            {
                animal.Verse();
                Console.Write("Ho fame! Dammi un po' di ");
                animal.RequiredFood();
                
                Console.Write("Mangiare mi ha fatto venire sonno...");
                animal.Sleep();

                Console.WriteLine("");
            }

            List<ICanFly> flyingAnimals = new List<ICanFly>();
            flyingAnimals.Add(new Goose());
            flyingAnimals.Add(new Eagle());

            foreach(ICanFly flyingAnimal in flyingAnimals)
            {
                DoFly(flyingAnimal);
            }

            List<ICanSwim> swimmingAnimals = new List<ICanSwim>();
            swimmingAnimals.Add(new Goldfish());
            swimmingAnimals.Add(new Goose());
            swimmingAnimals.Add(new Dolphin());

            foreach (ICanSwim swimmingAnimal in swimmingAnimals)
            {
                DoSwim(swimmingAnimal);
            }

            Cat rndCat = new Cat();
            Cat rndCat2 = new Cat();

            Console.WriteLine("\n***** Momento creativo *****\n");
            Console.Write($"gattino1 - Ciao, sono un gattino appena nato! Ora penso che farò un pisolino...");
            rndCat.Sleep();
            Console.Write($"gattino2 - Ciao, anche io sono appena nato, penso che andrò in cerca di ");
            rndCat2.RequiredFood();

            Console.Write($"gattino1 - Che bella dormita! ");
            rndCat.Verse();
            Console.Write("gattino2 - Mentre tu dormivi ho trovato un sacco di ");
            rndCat2.RequiredFood();

            Console.Write($"gattino1 - A proposito di cibo, ora sono affamato, chissà dove posso trovare un po' di ");
            rndCat.RequiredFood();
            Console.Write("gattino2 - Prendi pure quel che mi è avanzato, nel frattempo dormirò un po'...");
            rndCat2.Sleep();

            Console.Write("gattino1 - Dopo aver mangiato ci vuole un altro po' di sonno...");
            rndCat.Sleep();
            Console.Write($"gattino1 - La giornata è volta al termine, è stata produttiva però: ho totalizzato {rndCat.SleepCyclesCounter} pisolini dalla mia nascita!");
            rndCat.Verse();
            Console.Write($"gattino2 - Ho solo {rndCat2.SleepCyclesCounter} pisolino fatto. Domani recupererò! ");
            rndCat2.Verse();

        }

        public static void DoFly(ICanFly animal)
        {
            animal.Fly();
        }

        public static void DoSwim (ICanSwim animal)
        {
            animal.Swim();
        }
    }
}