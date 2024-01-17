using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30_05_sasaki
{
    internal class Car : Vehicle
    {
        readonly private string maker;
        public Car(string n = null, float w = 0, float h = 0, float d = 0, float maximumSpeed = 0, string maker = null) : base(n, w, h, d, maximumSpeed)
        {
            this.maker = maker;
        }
    }
}
