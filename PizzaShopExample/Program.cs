using PizzaShopExample.Creators.Abstract;
using PizzaShopExample.Creators.Concrete;
using PizzaShopExample.Utils;
using System;
using System.Collections.Generic;

namespace PizzaShopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string pizzaName = "";
            var pizzaNames = new List<string>() { Util.MargharitaPizza, Util.ChickenPizza };
            bool val = false;

            // Test commit.

            while(!val)
            {
                Console.WriteLine("Welcome to PizzaShop. Please select your pizza. Here options : Margharita , Chicken");
                pizzaName = Console.ReadLine();

                val = Validation(pizzaName, pizzaNames);
            }
            
            IPizzaShop pizzaShop = new PizzaShop();
            pizzaShop.OrderPizza(pizzaName);
            Console.WriteLine("Your " + pizzaName + " pizza is ready. Bon appetit!");
        }

        public static bool Validation(string pizzaName, List<string> pizzaNames)
        {
            if (!pizzaNames.Contains(pizzaName))
            {
                Console.WriteLine("Please make sure you type it correctly");
                return false;
            }
            else
                return true;
        }
    }
}
