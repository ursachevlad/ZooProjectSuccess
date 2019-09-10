using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Zoo;

namespace ZooProject
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                AnimalsZoo zoo = new ConcreteAnimalsZoo();

                IZoo lion = zoo.GetAnimals("Lion");
                lion.Drive(10);

                IZoo cheater = zoo.GetAnimals("Cheater");
                cheater.Drive(20);

                Console.ReadKey();


                var ourClass = BestAnimal.Instance;
                ourClass.Name = "Black";

                var ba = BestAnimal.Instance;
                ba.Name = "Beauty";

                Console.ReadKey();
            }

        }
    }
}

