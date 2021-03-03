using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Creator
{
    internal class Builder
    {
        public static TypeBuilder Create(string name, int hash)
        {
            if (buid == null || hash != _hash) buid = new Builder(name).CreateClass();
            _hash = hash;
            return buid;
        }
        static int _hash;
        static TypeBuilder buid;
        public TypeBuilder CreateClass()
        {
            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(this.asemblyName, AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("MainModule");
            TypeBuilder typeBuilder = moduleBuilder.DefineType(this.asemblyName.FullName
                                , TypeAttributes.Public |
                                TypeAttributes.Class |
                                TypeAttributes.AutoClass |
                                TypeAttributes.AnsiClass |
                                TypeAttributes.BeforeFieldInit |
                                TypeAttributes.AutoLayout
                                , null);
            return typeBuilder;
        }
        AssemblyName asemblyName;
        private Builder(string nameCreateClass)
        {
            this.asemblyName = new AssemblyName(nameCreateClass);
        }
        private Builder() { }
    }
}
