using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Processor<TEngine,TEntity,TLogger>
    {
     
    }
    class Processor
    {
        public static B<TEngine> CreateEngine<TEngine>()
            {
                return new B<TEngine>();
            }
    }
}
