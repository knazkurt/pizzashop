using PizzaShopExample.Products.Abstract;
using PizzaShopExample.Utils;
using System;

namespace PizzaShopExample.Products.Concrete
{
    public class MargharitaPizza : Pizza
    {
        public MargharitaPizza()
        {
            pizzaName = Util.MargharitaPizza;
            pizzaSouce = Util.TomatoSauce;
            doughType = Util.Thin;
            price = 10;
            ingredients = new string[] { Util.Tomato, Util.Basil, Util.Mozzarella };

        }

        public override void bake()
        {
            Console.WriteLine("Bake 30 min");
        }
    }
}
