using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace UML2
{
    public class MenuCatalog
    {
        public List<Pizza> Read()
        { 
            return pizzas;
        }
        List<Pizza> pizzas;
        public MenuCatalog()
        {
            pizzas = new List<Pizza>();
        }

        public void Create(Pizza pizza)
        {
            pizzas.Add(pizza);
        }
        public void RemovePizza(Pizza pizza)
        {
            pizzas.Remove(pizza);
        }
        public void UpdatePizza(Pizza oldPizza, Pizza newPizza)
        {
            int index = pizzas.IndexOf(oldPizza);
            pizzas[index] = newPizza;
        }
        public void PrintMenu()
        {
            Console.WriteLine("Menu");
            foreach (Pizza pizza in pizzas)
            {
                Console.WriteLine(pizza.Number + " - " + pizza.Name + " - " + pizza.Price);
            }
        }
        public Pizza SearchPizza(string criteria)
        {
            return null;
            foreach (Pizza pizza in pizzas)
            {
                if (pizza.Name.Contains(criteria))
                {
                    return pizza;
                }
            }
        }
                
    }
}