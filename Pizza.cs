using System.Dynamic;
using System.Collections.Generic;

namespace UML2
{
    public class Pizza
    {
        public int Number { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }
        public List<string> Toppings { get; set; }
    }
}