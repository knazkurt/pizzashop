using PizzaShopExample.Creators.Abstract;
using PizzaShopExample.Products.Abstract;
using PizzaShopExample.Products.Concrete;
using PizzaShopExample.Utils;

namespace PizzaShopExample.Creators.Concrete
{
    public class PizzaShop : IPizzaShop
    {
        public Pizza ChoosePizza(string pizzaName)
        {

            if (pizzaName == Util.MargharitaPizza)
            {
                return new MargharitaPizza();
            }
            else
            {
                return new ChickenPizza();
            }

        }
        public Pizza OrderPizza(string pizzaName)
        {
            Pizza pizza = ChoosePizza(pizzaName);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
