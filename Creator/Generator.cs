using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator
{
  public static class Generator
    {
        public static Type CreateType(string name,Dictionary<string,Type> dict)
        {
           return new Creator(dict.GetHashCode(), name).Start(dict);
        }
        public static object CreateTypeInstanse(string name,Dictionary<string,Type> dict)
        {
            Type type = CreateType(name,dict);
            return Activator.CreateInstance(type);
        }

    }
}
