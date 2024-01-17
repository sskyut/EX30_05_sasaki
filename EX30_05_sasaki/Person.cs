using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30_05_sasaki
{
    internal class Person : Animal
    {
        readonly private string gender;
        public Person(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float lifespan = 0, string ActivityPeriod = null, string gender = null) : base(bd, n, w, h, d, lifespan, ActivityPeriod)
        {
            this.gender = gender;
        }
        public override void SelfIntroduction()
        {
            base.SelfIntroduction();
            Console.WriteLine($"性別:{gender}");
        }
    }
}
