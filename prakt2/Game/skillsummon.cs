using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class skillsummon
    {
        public bool cd;
        public int manacost;
        public double reloading;
        public skillsummon(int manacost, double reloading)
        {
            this.manacost = manacost;
            this.reloading = reloading;
        }
        public void action()
        {
            summon programmist = new summon(100, 10, 500);
            Console.WriteLine("hp: " + programmist.Hp);

            Console.WriteLine("speed: " + programmist.speed);
        }
    }
}
