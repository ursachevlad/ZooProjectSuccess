using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Sounds
{
    public class WildHorse : Animal
    {
        private const string SOUND = "MHAAAMMMM";

        public WildHorse(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}
