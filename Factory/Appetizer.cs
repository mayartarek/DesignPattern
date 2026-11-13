using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface IAppetizer: IDish
    {
    }
    public  class CHickenSalad : Dish, IAppetizer
    {
        public CHickenSalad(string name, string description, decimal price)
            : base(name, description, price)
        {
        }   
        public  void ServeDish()
        {
            Console.WriteLine($"Serving {ShowDetaila()}");
        }
    }
    public class ButterCracker : Dish, IAppetizer
    {
        public ButterCracker(string name, string description, decimal price)
            : base(name, description, price)
        {
        }
        public void ServeDish()
        {
            Console.WriteLine($"Serving {ShowDetaila()}");
        }
    }
    public class CheeseTwist : Dish, IAppetizer
    {
        public CheeseTwist(string name, string description, decimal price)
            : base(name, description, price)
        {
        }
        public void ServeDish()
        {
            Console.WriteLine($"Serving {ShowDetaila()}");
        }
    }
}
