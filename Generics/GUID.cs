using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GUID
    {
        Dictionary<Guid, Object> d;
        public GUID()
        {
            d = new Dictionary<Guid, Object>();
        }
        public T1 Method1<T1>()
            where T1 : new()
        {
            var val = new T1();
            d.Add(Guid.NewGuid(), val);
            return val;
        }
        public List<KeyValuePair<Guid, Object>> Method2<T2>()
        {
            var list = new List<KeyValuePair<Guid, object>>();
            foreach (KeyValuePair<Guid, Object> keyValue in d)
            {

                var val = keyValue.Value.GetType();
                if (val == typeof(T2))
                {
                    list.Add(keyValue);
                }
            }
            return list;
        }
        public T3 Method3<T3>(Guid key)
        {

            foreach (KeyValuePair<Guid, Object> keyValue in d)
            {

                var val = keyValue.Value;
                var gu = keyValue.Key;
                if (val.GetType() == typeof(T3) && gu == key)
                {
                    return (T3)val;
                }
            }
            return default(T3);
        }
    }
}
