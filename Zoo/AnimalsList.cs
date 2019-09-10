using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Sounds;

namespace ZooProject.Zoo
{
    public class AnimalsList
    {
        private List<Animal> animals;

        private AnimalsList()
        {
            animals = new List<Animal>();

            InitAnimals();
        }

        private void InitAnimals()
        {
            WildDuck ducky = new WildDuck("Ducky");
            WildCat brizy = new WildCat("Brizy");
            WildDog rony = new WildDog("Rony");
            WildHorse blackbeauty = new WildHorse("BlackBeauty");
            Zebra sam = new Zebra("Sam");
            Monkey cip = new Monkey("Cip");
            Elephant dumbo = new Elephant("Dumbo");
            Leopard jack = new Leopard("Jack");

            animals.Add(ducky);
            animals.Add(brizy);
            animals.Add(rony);
            animals.Add(blackbeauty);
            animals.Add(sam);
            animals.Add(cip);
            animals.Add(dumbo);
            animals.Add(jack);
        }

        public void ShowAnimals()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} {animal.Name} makes {animal.MakeSound()}!");
            }
        }
    }
}
