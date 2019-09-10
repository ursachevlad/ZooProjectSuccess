using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Sounds
{
    public class WildDog : Animal
    {
        private const string SOUND = "WOWWOOW";

        public WildDog(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}
