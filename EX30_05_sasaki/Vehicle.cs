using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30_05_sasaki
{
    internal class Vehicle : Thing
    {
        private float maximumSpeed;
        public Vehicle(string n = null, float w = 0, float h = 0, float d = 0, float maximumSpeed = 0) : base(n, w, h, d)
        {
            this.maximumSpeed = maximumSpeed;
        }
    }
}
