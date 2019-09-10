using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Zoo
{
    public class Cheater : IZoo
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Cheater : " + miles.ToString() + "km");
        }
    }
}
