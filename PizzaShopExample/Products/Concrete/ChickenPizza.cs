using PizzaShopExample.Products.Abstract;
using PizzaShopExample.Utils;
using System;

namespace PizzaShopExample.Products.Concrete
{
    public class ChickenPizza : Pizza
    {
        public ChickenPizza():base(Util.ChickenPizza)
        {            
            pizzaSouce = Util.TomatoSauce;
            doughType = Util.Medium;
            price = 10;
            ingredients = new string[] { Util.Sweetcorn, Util.Jalapeno, Util.RedOnion, Util.Chicken, Util.Mozzarella };

        }

        public override void bake()
        {
            Console.WriteLine("Bake 20 min");
        }
    }
}
