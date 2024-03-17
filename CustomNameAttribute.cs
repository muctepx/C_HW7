using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem7
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CustomNameAttribute : Attribute
    {
        public string Name;
        public CustomNameAttribute(string name) => Name = name;

    }
}