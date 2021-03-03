using Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Test
{
    class f { }
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Type>()
            {
                {"Id",typeof(f) },
              
            };
            var resultK = Generator.CreateType("new66Type", dict); 
            var jytjyj = new Dictionary<string, Type>()
            {
                {"Id",typeof(int) },
                {"FirstName", resultK},
                {"LastName",typeof(string) }
            };
            Type result = Generator.CreateType("newType", jytjyj);
            var obj = Activator.CreateInstance(result);
            obj.GetType()
                .GetRuntimeProperties()
                .ToList()
                .ForEach(q =>
                {
                    Console.WriteLine("Name=" + q.Name + " Type=" + q.PropertyType.ToString());
                });
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
    class I { }
    class J
    {
        public I i { get; }
    }
}
