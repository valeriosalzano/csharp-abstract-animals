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