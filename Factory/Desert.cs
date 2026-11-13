using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface IDesert:IDish
    {
    }
    public class IceCream : Dish, IDesert
    {
        public IceCream(string name, string description, decimal price) : base(name, description, price)
        {
        }
        public void ServeDish()
        {
            Console.WriteLine($"Serving {ShowDetaila()}");
        }
    }
}
