using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface IDish
    {
       void ServeDish();
    }
    public abstract class Dish : IDish
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public Dish(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        protected string ShowDetaila()
        {
           return $"Name: {Name}\nDescription: {Description}\nPrice: {Price:C}\nIngredients: {string.Join(", ", Ingredients)}";
        }

        public void ServeDish()
        {
        }
    }
}
