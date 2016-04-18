using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    class summon : person
    {
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
        public summon(int hp, double speed, int damage)
        {
            this.hp = hp;
            this.speed = speed;
            this.damage = damage;
        }
    }
}  
