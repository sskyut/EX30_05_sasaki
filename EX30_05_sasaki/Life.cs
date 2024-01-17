using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30_05_sasaki
{
    internal class Life : Thing
    {
        readonly private string _name;
        readonly private DateTime _birthDay = new DateTime();
        readonly private float lifespan;
        public DateTime birthday
        {
            get { return _birthDay; }
        }
        new public string name
        {
            get { return _name; }
        }
        public Life(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float lifespan = 0) : base(n, w, h, d)
        {
            this._birthDay = bd;
            this.lifespan = lifespan;
        }
        public int age()    
        {
            int age =DateTime.Now.Year-_birthDay.Year;
            if (_birthDay.Month == DateTime.Now.Month)
            {
                if ((_birthDay.Day > DateTime.Now.Day))
                {
                    age -= 1;
                }
            }
            else
            {
                age -= 1;
            }
            return age;
        }
        public bool BirthDayCheck()
        {
            if (_birthDay.Month == DateTime.Today.Month && _birthDay.Day == DateTime.Today.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void SelfIntroduction()
        {
            base.SelfIntroduction();
           Console.WriteLine($"誕生日:{_birthDay.ToString("yyyy/yy/yy")}\n年齢:{age()}\n今日が誕生日か:{BirthDayCheck()}");
        }
    }
}
