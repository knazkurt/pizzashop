using System;

namespace PizzaShopExample.Products.Abstract
{
    public abstract class Pizza
    {

        private string pizzaName { get; set; }
        public string pizzaSouce;
        public string doughType;
        public double price;
        public string[] ingredients;


        public Pizza(string _pizzaName)
        {
            pizzaName = _pizzaName;
        }
        public void prepare()
        {
            Console.WriteLine("Prepare");
        }
        public abstract void bake();

        public void cut()
        {
            Console.WriteLine("Cut");
        }
        public void box()
        {
            Console.WriteLine("Box");
        }

    }
}
