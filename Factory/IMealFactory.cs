using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface IMealFactory
    {
        IAppetizer PrpoareAppetizer();
        IDesert PrepareDesert();
       

    }

    public  class ComboMealFactory : IMealFactory
    {
        public  IAppetizer PrpoareAppetizer()
        {
            return new CHickenSalad("Chicken Salad", "A healthy chicken salad with fresh vegetables.", 9.99m);
        }
        public  IDesert PrepareDesert()
        {
           return new IceCream("Vanilla Ice Cream", "A classic vanilla ice cream.", 3.99m);
        }
    }
}
