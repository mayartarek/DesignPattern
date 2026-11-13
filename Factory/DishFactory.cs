using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public  abstract class  DishFactory
    {
        public abstract IDish CreateDish();
  
    }

    public class ChickenDishFactory : DishFactory
    {
        public override IAppetizer CreateDish()
        {
            return new CHickenSalad("Chicken Salad", "A healthy chicken salad with fresh vegetables.", 9.99m);
        }
    }

    public class CheeseTwistDishFactory : DishFactory
    {
        public override IAppetizer CreateDish()
        {
            return new CheeseTwist("Cheese Twist", "A delicious cheese twist pastry.", 4.99m);
        }
    }   
    public class ButterCrackerDishFactory : DishFactory
    {
        public override IAppetizer CreateDish()
        {
            return new ButterCracker("Butter Cracker", "A crispy butter cracker.", 2.99m);
        }
    }
    public class IceCreamDishFactory : DishFactory
    {
        public override IDesert CreateDish()
        {
            return new IceCream("Vanilla Ice Cream", "A classic vanilla ice cream.", 3.99m);
        }
    }
}
