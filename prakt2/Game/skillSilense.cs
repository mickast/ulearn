using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    class skillSilense
    {
        Unit targetcgange;
        public bool cd;
        public int manacost;
        public double reloading;
        public double timed;
        public skillSilense(int manacost, double reloading, double timed)
        {
            this.manacost = manacost;
            this.reloading = reloading;
            this.timed = timed;
        }
        public void def(object stat) // Возвращение стандартных характеристик
        {
            foreach (skill sk in targetcgange.Skills)
            {
                sk.cd = false;
            }
        }

        public void action(Unit target)
        {
            TimerCallback timeCB = new TimerCallback(def);
            Timer time = new Timer(timeCB, null, 0, (int)timed * 100);
            targetcgange = target;
            foreach (skill sk in target.Skills)
            {
                sk.cd = true;
            }
        }
    }
}
