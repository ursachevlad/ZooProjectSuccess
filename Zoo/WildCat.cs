using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Sounds
{
    public class WildCat : Animal
    {
        private const string SOUND = "WAWMEOW";

        public WildCat(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}
