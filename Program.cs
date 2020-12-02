using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{

    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            this.Name = name;
            this.Calories = calories;
            this.IsSpicy = isSpicy;
            this.IsSweet = isSweet;
        }
    }

    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Rice", 1800, false, false),
                new Food("Tea", 10, false, false),
                new Food("Blueberry", 30, false, true),
                new Food("Eggs fried", 400, false, false),
                new Food("Soup", 1500, true, false),
                new Food("Sushi", 1200, true, false),
                new Food("Bread", 600, false, false),
                new Food("Jam", 10, false, true)
            };
        }

        public Food Serve()
        {
            Random RandomFood = new Random();
            int randomInt = RandomFood.Next(Menu.Count);
            return Menu[randomInt];
        }
    }

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public string Name;
        public int CalorieProp
        {
            get
            {
                return calorieIntake;
            }
        }

        // add a constructor
        public Ninja(string name)
        {
            this.Name = name; //'Ninja' does not contain a definition for 'Name' and
                              // no accessible extension method 'Name' accepting a first argument of type 'Ninja' could be found.
                              // ** add a public string Name **
            this.calorieIntake = 0;
            this.FoodHistory = new List<Food>();
        }


        // add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get
            {
                if (this.calorieIntake > 1200)
                {
                    Console.WriteLine("Is FULL");
                    return true;
                }
                else
                {
                    Console.WriteLine("Is Hugry");
                    return false;
                }

            }
        }

        // build out the Eat method
        public void Eat(Food item)
        {
            if (IsFull != true)
            {
                this.calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"Food name: {item.Name}, Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}");
            }
            else
            {
                Console.WriteLine($"{this.Name} is full and can not eat anymore ");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var NewFood1 = new Food("Chocolate", 300, false, true);
            var NewFood2 = new Food("La Tiao", 100, true, false);
            Console.WriteLine($"Food Name: {NewFood1.Name} has {NewFood1.Calories} calories, and it is spicy ({NewFood1.IsSpicy}) instead of sweet ({NewFood1.IsSweet})");

            Buffet NewMenu = new Buffet();
            NewMenu.Serve();
            Console.WriteLine($"Random food is '{NewMenu.Serve().Name}'");

            var NewNinja = new Ninja("Ling");
            Console.WriteLine($"{NewNinja.Name} is {NewNinja.IsFull}");
            Console.WriteLine($"This {NewNinja.Name} Welcome!");
            NewNinja.Eat(NewMenu.Serve());
            Console.WriteLine($"{NewNinja.CalorieProp}");

            while (NewNinja.IsFull == false)
            {
                NewNinja.Eat(NewMenu.Serve());
            }
            Console.WriteLine($"Warning: calorie intake is {NewNinja.CalorieProp}. The ninja is full and cannot eat anymore!");
        }
    }
}
