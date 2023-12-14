using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractice
{
    internal class Pizza
    {
        // 1)Property syntax
        public string Name { get; set; }

        // 2)Setting property value to default

        /*public string Name { get; set; } = "Itallian";*/

        // 3)Define the storage yourself
        /*string name;
        public string Name { get => name; set { name = value.ToUpper(); }}*/


        // 4) restrict user access to change properties by making them private
        /* by this the property can get from everywhere but can set only from it's own class*/
        public bool OnSale {  get; private set; }

        public Pizza() 
        { 
            OnSale = true;
        }

       
    }
}
