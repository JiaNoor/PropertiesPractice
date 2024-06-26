﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractice
{
    public class Pizza : INotifyPropertyChanged
    {
    // 1)Property syntax
       /* public string Name { get; set; }*/

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





        // 5) Properties Validation
        /* string name;
         public string Name { get => name; set { name = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("Name must not be blank"); } }*/

        // 6) Read Only
        /*public string Name { get; }*/

        // 7) Init Only
        /*public required string Name { get; init; }*/

        // 8) Computed Properties
        /*  public string Place { get; set; }
            public string Flavor { get; set; }
            public string Name { get { return $"{Place} {Flavor}"; } }*/

        // 9) Cached evaluated properties:  computed property with storage and create a cached evaluated property
        /*      public string Place { get; set; }
              public string Flavor { get; set; }
              private string? name;
              public string Name
              {
                  get
                  {
                      if (name is null)
                          name = $"{Place} {Flavor}";
                      return name;
                  }
              }*/

        // 10) Auto-Implemented  Properties:  same as normal property sytax, declaring the entire property in one line
        [field: NonSerialized]
        public int PizzaId { get; set; }


        // 11) Implementing INotifyPropertyChanged
        string name;
        public string Name { get => name; set
            {
                name = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(Name)));
            } }

        public event PropertyChangedEventHandler? PropertyChanged;

    }
}
