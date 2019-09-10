using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Sounds
{
    public abstract class Animal : IMakeSound
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract string MakeSound();
    }
}
