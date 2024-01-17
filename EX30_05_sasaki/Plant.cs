using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30_05_sasaki
{
    internal class Plant : Life
    {
        readonly　private int cotyledonsNumber;//子葉の数
        public Plant(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float lifespan = 0, int cotyledonsNumber = 0) : base(bd, n, w, h, d, lifespan)
        {
            this.cotyledonsNumber = cotyledonsNumber;
        }
    }
}
