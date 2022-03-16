using PizzaShopExample.Products.Abstract;

namespace PizzaShopExample.Creators.Abstract
{
    public interface IPizzaShop
    {
        public Pizza OrderPizza(string pizzaName);
        public Pizza ChoosePizza(string pizzaName) ;
    }
}
