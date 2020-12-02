# csharp-assignments-Hungry-Ninja

Hungry Ninja
Taking what we've learned from the Human assignment, let's explore how different classes can interact with one another using private properties, public getters, and class methods.

For the everyday ninja on a lunch break there is Ninja Buffet! It's All-You-Can-Eat, serving bold flavors and delicious calories to the hardworking ninjas of this world. Please note, we will be revisiting your work here in a later assignment.

Tasks
Create a Food class
class Food
{
    public string Name;
    public int Calories;
    // Foods can be Spicy and/or Sweet
    public bool IsSpicy; 
    public bool IsSweet; 
    // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
}

Create a Buffet class, which will contain a Menu of Food objects
add a constructor and set Menu to a hard coded list of 7 or more Food objects you instantiate manually
build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object
class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Example", 1000, false, false)
        };
    }
     
    public Food Serve()
    {
    }
}

Create a Ninja class
add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories
build out the Eat method that: if the Ninja is NOT full
adds calorie value to ninja's total calorieIntake
adds the randomly selected Food object to ninja's FoodHistory list
writes the Food's Name - and if it is spicy/sweet to the console
if the Ninja IS full
issues a warning to the console that the ninja is full and cannot eat anymore
class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
     
    // add a constructor
     
    // add a public "getter" property called "IsFull"
     
    // build out the Eat method
    public void Eat(Food item)
    {
    }
}

 Add a constructor to the Food class
 Add a constructor and Serve method to the Buffet class
 Add a constructor, IsFull property, and an Eat method to the Ninja class
 In your Program's Main method, instantiate a Buffet and Ninja object, and have the Ninja eat until they are full!

