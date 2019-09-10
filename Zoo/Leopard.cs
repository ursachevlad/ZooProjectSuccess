using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Sounds
{
    public class Leopard : Animal
    {
        private const string SOUND = "MRRRWrrrr";

        public Leopard(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}
