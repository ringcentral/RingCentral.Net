using System.Collections.Generic;
using System.Linq;

namespace RingCentral
{
    public static class Utils
    {
        public static IEnumerable<(string name, object value)> GetPairs(object obj)
        {
            return obj.GetType().GetFields().Select(f => (name: f.Name, value: f.GetValue(obj)))
                .Concat(obj.GetType().GetProperties().Select(p => (name: p.Name, value: p.GetValue(obj))))
                .Where(t => t.value != null);
        }
    }
}