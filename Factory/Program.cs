using Factory;
using System.Diagnostics;

internal class Program
{ 
    public static void Main(string[] args)
    {// OLD
        (IAppetizer appetizer, IDesert desert) meal = new();
        Console.WriteLine("Hello, Factor!");
        int choice;
        Console.WriteLine("1-ChickenSalad");
        Console.WriteLine("2-CheeseTwist");
        Console.WriteLine("3-ButterCrackerButterCracker");
        Console.WriteLine("4-ice cream");


        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        //switch (choice)
        //{
        //    case 1:
        //        meal.appetizer = new CHickenSalad("Chicken Salad", "A healthy chicken salad with fresh vegetables.", 9.99m);
        //        break;
        //    case 2:
        //        meal.appetizer = new CheeseTwist("Cheese Twist", "A delicious cheese twist pastry.", 4.99m);
        //        break;
        //    case 3:
        //        meal.appetizer = new ButterCracker("Butter Cracker", "A crispy butter cracker.", 2.99m);
        //        break;
        //    case 4:
        //        meal.desert = new IceCream("Vanilla Ice Cream", "A classic vanilla ice cream.", 3.99m);
        //        break;
        //    default:
        //        Console.WriteLine("Invalid choice.");
        //        break;
        //}

        switch(choice)
        {
            case 1:
                meal.appetizer = new ChickenDishFactory().CreateDish();
                break;
            case 2:
                meal.appetizer = new CheeseTwistDishFactory().CreateDish();
                break;
            case 3:
                meal.appetizer = new ButterCrackerDishFactory().CreateDish();
                break;
            case 4:
                meal.desert = new IceCreamDishFactory().CreateDish();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        switch(choice)
        {
            case 11:
                meal.appetizer = new ComboMealFactory().PrpoareAppetizer();
                break;
            case 12:
                meal.appetizer = new ComboMealFactory().PrpoareAppetizer();
                break;
            case 13:
                meal.appetizer = new ComboMealFactory().PrpoareAppetizer();
                break;
            case 14:
                meal.desert = new ComboMealFactory().PrepareDesert();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        meal.appetizer?.ServeDish();
        meal.desert?.ServeDish();

    }


}

