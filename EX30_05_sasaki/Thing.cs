using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30_05_sasaki
{
    internal class Thing
    {
        readonly public string name;
        public float width;
        public float height;
        public float depth;
        public Thing(string n = null, float w = 0, float h = 0, float d = 0)
        {
            name = n;
            width = w;
            height = h;
            depth = d;
        }
        public virtual void SelfIntroduction()
        {
            SelfIntroduction(this);
        }
        //自己紹介
        static public void SelfIntroduction(Thing t)
        {
            Console.WriteLine($"名前:{t.name}.\n" +
                              $"高さ:{t.height}");
        }
    }
}
