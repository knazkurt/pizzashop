using System;

namespace PizzaShopExample.Products.Abstract
{
    public abstract class Pizza
    {

        public string pizzaName;
        public string pizzaSouce;
        public string doughType;
        public double price;
        public string[] ingredients;


        public abstract void prepare();

        public void bake()
        {
            Console.WriteLine("Bake");
        }
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
