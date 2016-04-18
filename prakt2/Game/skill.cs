using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    class skill
    {
        Unit targetcgange; //Цель
        public bool cd; // Время перезарядки скила cooldown
        public bool buffskill; //+ или - персонажу
        public int mpchange; // На сколько изменяются хар-ки персонажа
        public double speed; 
        public int damage;
        public int manacost; //Стоимость маны
        public double reloading; // Время перезарядки скила
        public double timed; // Время действия скила

        public skill(int damage, int mpchange, double speed, int manacost, double reloading, double timed, bool buffskill)
        {
            this.damage = damage;
            this.mpchange = mpchange;
            this.speed = speed;
            this.manacost = manacost;
            this.reloading = reloading;
            this.timed = timed;
            this.buffskill = buffskill;
            cd = false;
        }
        public void def(object stat) // Возвращение стандартных характеристик
        {
            targetcgange.Hp = targetcgange.defhp;
            targetcgange.mp = targetcgange.defmp;
            targetcgange.speed = targetcgange.defspeed;
        }

        public void action(Unit target)
        {
            TimerCallback timeCB = new TimerCallback(def);
            Timer time = new Timer(timeCB, null, 0, (int)timed * 100);
            targetcgange = target;
            if (buffskill == true)
            {
                target.Hp += damage;
                target.speed += speed;
                target.mp += mpchange;
            }
            else
            {
                target.Hp -= damage;
                target.speed -= speed;
                target.mp -= mpchange;
            }

        }

    }
}
}
