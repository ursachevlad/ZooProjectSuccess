using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Zoo
{
    public class Lion : IZoo
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Lion : " + miles.ToString() + "km");
        }
    }
}
