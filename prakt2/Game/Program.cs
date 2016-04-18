using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {

        public static void Main()
        {


            skill IceArrow = new skill(30, 0, 0, 60, 4.00, 2.00, false);
            skill heal = new skill(20, 0, 20, 40, 4.00, 2.00, true);
            skill debuff = new skill(40, 0, 30, 50, 4.00, 2.00, false);
            skillsummon sum = new skillsummon(40, 10);
            skillSilense silence = new skillSilense(30, 15.00, 3.00);

            Unit Ivan = new Unit(100, 100.00, 100, 4, 100, silence, sum, IceArrow, heal, debuff); 
            Unit Anton = new Unit(100, 100.00, 100, 4, 100, null, null, IceArrow, heal, debuff);
            Console.WriteLine(Ivan.Hp);

            //Eric.action(silence, Bob);
            Anton.action(Anton.Skills[0], Ivan);
            Console.WriteLine(Ivan.Hp);
            // Eric.action(Eric.Skillssum);
            Console.ReadLine();
        }
    }

}
