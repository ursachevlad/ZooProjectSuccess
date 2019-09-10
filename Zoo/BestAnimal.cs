using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Zoo
{
    public class BestAnimal
    {
        private static BestAnimal _instance;
        private static readonly object _padlock = new object();

        private BestAnimal()
        {

        }

        public static BestAnimal Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new BestAnimal();
                            _instance.Name = "BlackBeauty";
                        }
                    }
                }
                return _instance;
            }
        }

        public string Name { get; internal set; }
    }
}
