using Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Type>()
            {
                {"Id",typeof(int) },
                {"FirstName",typeof(string) },
                {"LastName",typeof(string) }
            };
            var result = Generator.CreateType("newType", dict);
            var obj = Activator.CreateInstance(result);
            obj.GetType()
                .GetRuntimeProperties()
                .ToList()
                .ForEach(q =>
                {
                    Console.WriteLine("Name="+q.Name+" Type="+q.PropertyType.ToString());
                });
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
