using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30_05_sasaki
{
    internal class Fish : Animal
    {
        public Fish(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float lifespan = 0, string ActivityPeriod = null) : base(bd, n, w, h, d, lifespan,ActivityPeriod)
        {
            //何も思いつかなかった
        }
    }
}
