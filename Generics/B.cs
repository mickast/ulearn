using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class B<TEngine>
    {
        public B<TEngine,TEntity> For<TEntity>()
        {
            return new B<TEngine, TEntity>();
        }
    }
    class B<TEngine,TEntity>
    {
        public Processor<TEngine, TEntity,TLogger> With<TLogger>()
        {
            return new Processor<TEngine, TEntity, TLogger>();
        }
    }
}
