using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30_05_sasaki
{
    internal class Dog : Animal
    {
        readonly private string dogBreed;
        public Dog(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float lifespan = 0, string ActivityPeriod = null,string dogBreed=null) : base(bd, n, w, h, d, lifespan,ActivityPeriod)
        {
            this.dogBreed=dogBreed;
        }
    }
}
