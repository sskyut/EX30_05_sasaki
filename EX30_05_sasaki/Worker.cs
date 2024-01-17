using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30_05_sasaki
{
    internal class Worker : Person
    {
        private int income;
        public Worker(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float lifespan = 0, string ActivityPeriod = null, string gender = null, int income = 0) : base(bd, n, w, h, d, lifespan, ActivityPeriod, gender)
        {
            this.income = income;
        }
    }
}
