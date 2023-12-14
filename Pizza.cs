using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractice
{
    internal class Pizza
    {
        // 1)Property syntax
        //public string Name { get; set; }

        // 2)Setting property value to default

        //public string Name { get; set; } = "Itallian";

        // 3)Define the storage yourself
        string name;
        public string Name { get => name; set { name = value.ToUpper(); }}

    }
}
