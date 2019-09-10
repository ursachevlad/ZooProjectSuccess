using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Zoo
{
    public class ConcreteAnimalsZoo : AnimalsZoo
    {
        public override IZoo GetAnimals(string Animals)
        {
            switch (Animals)
            {
                case "Lion":
                    return new Lion();
                case "Cheater":
                    return new Cheater();
                default:
                    throw new ApplicationException(string.Format("Animals '{0}' cannot be created", Animals));
            }
        }
    }
}
