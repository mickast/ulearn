using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    class Unit : person //описание персонажа
    {
        public int defhp;
        public int defmp;
        public double defspeed;

        public int Hp

        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }

        private int hpregen;
        public int mp;
        public int exp;
        private int lvl;
        public skillsummon Skillssum; 
        public skill[] Skills = new skill[3];
        public skillSilense silence;
        private int rename;

        public Unit(int hp, double speed, int damage, int hpregen, int mp, skillSilense silence, skillsummon Skillssum, params skill[] Skills)
        {
            this.hp = hp;
            this.speed = speed;
            this.silence = silence;
            this.damage = damage;
            this.hpregen = hpregen;
            this.mp = mp;
            exp = 0;
            lvl = 0;
            this.Skills = Skills;
            defhp = hp;
            defmp = mp;
            defspeed = speed;
            this.Skillssum = Skillssum;
        }


        public void lvlup()
        {
            if (exp == 100)
            {
                lvl++;
                exp = 0;
            }
        }

        public void refresh(object state) // проверка на перезарядку скила
        {
            Skills[rename].cd = false; 
        }
        public void action(skill skill1, Unit target)
        {
            if (skill1.cd == false)
            {

                TimerCallback timeCB = new TimerCallback(refresh);
                Timer time = new Timer(timeCB, null, 0, (int)skill1.reloading * 100);

                if (mp >= skill1.manacost)
                {
                    mp -= skill1.manacost; //Уменьшение маны
                    skill1.action(target);// На кого используем
                    rename = Array.IndexOf(Skills, skill1);
                    Console.WriteLine(rename);
                }
                else
                {
                    Console.WriteLine("Не хватает маны");
                }
            }
            else
            {
                Console.WriteLine("Перезарядка!");
            }
        }
        public void refreshsum(object state) // перезарядка сумона
        {
            Skillssum.cd = false;
        }
        public void action(skillsummon Skillssum)
        {
            if (Skillssum.cd == false)
            {

                TimerCallback timeCB = new TimerCallback(refreshsum);
                Timer time = new Timer(timeCB, null, 0, (int)Skillssum.reloading * 100);

                if (mp >= Skillssum.manacost)
                {
                    mp -= Skillssum.manacost;
                    Skillssum.action();
                }
                else
                {
                    Console.WriteLine("Не хватает маны");
                }
            }
            else
            {
                Console.WriteLine("Перезарядка!");
            }
        }
        public void refreshsil(object state) // перезарядка silence
        {
            silence.cd = false;
        }
        public void action(skillSilense silence, Unit target)
        {
            if (silence.cd == false)
            {

                TimerCallback timeCB = new TimerCallback(refreshsil);
                Timer time = new Timer(timeCB, null, 0, (int)silence.reloading * 100);

                if (mp >= silence.manacost)
                {
                    mp -= silence.manacost;
                    silence.action(target);
                }
                else
                {
                    Console.WriteLine("Не хватает маны");
                }
            }
            else
            {
                Console.WriteLine("Перезарядка!");
            }
        }
    }
}

