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
