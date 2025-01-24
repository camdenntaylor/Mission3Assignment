using Mission3Assignment;
using System;
using System.Collections.Generic;

//Final version
namespace Mission3Assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //create inventory list of FoodItems outside loop so it doesn't reset
            List<FoodItem> inventory = new List<FoodItem>();

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?" + "\n1. Add food items" + "\n2. Delete food items" +
                    "\n3. Show all current food items" + "\n4. Exit the program");

                string response = Console.ReadLine();


                if (response == "1")
                {
                    //1. add food items
                    //call constructor to get the name, category, quantity, expiration date?

                    Console.WriteLine("What is the name of the food item?");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is the category? (Canned goods, Dairy, Produce)");
                    string category = Console.ReadLine();

                    Console.WriteLine("Enter the quantity: ");

                    int quantity = int.Parse(Console.ReadLine());
                    if (quantity < 0)
                    {
                        Console.WriteLine("Cannot enter a negative quantity. Please try again");
                        continue;
                    }

                    Console.WriteLine("What is the expiration date? (mm/dd/yyyy): ");
                    DateTime expdate;

                    //ensuring the user enters a proper date
                    while (!DateTime.TryParse(Console.ReadLine(), out expdate))
                    {
                        Console.WriteLine("Invalid date. Please enter the expiration date in the format mm/dd/yyyy:");
                        continue;
                    }

                    //create new food item with gathered data and add to inventory list
                    FoodItem newfooditem = new FoodItem(name, category, quantity, expdate);
                    inventory.Add(newfooditem);

          
                    Console.WriteLine("\nitem added successfully\n");
                    continue;

                }

                else if (response == "2")
                {
                    //2. delete food items
                    
                    Console.WriteLine("\nWhich item would you like to delete? (0, 1, 2...)\n ");

                    //go through inventory and prompt them to delete an item based on its index
                    for (int i = 0; i < inventory.Count; i++)
                    {
                        Console.WriteLine($"{i}: {inventory[i].Name}-- Category : {inventory[i].Category}, Quantity: {inventory[i].Quantity}, Expiration Date: {inventory[i].Expdate}");
                    }

                    //delete the item
                    int choice = int.Parse(Console.ReadLine() );
                    inventory.RemoveAt(choice);

                    Console.WriteLine("Item removed successfully");
                    continue;
                }
                else if (response == "3")
                {
                    //3. print current list of food items
                    if (inventory.Count <= 0)
                    {
                        Console.WriteLine("\nThere are no items in inventory");
                    }

                    for (int i = 0; i < inventory.Count; i++)
                    {
                        Console.WriteLine($"{inventory[i].Name}-- Category : {inventory[i].Category}, Quantity: {inventory[i].Quantity}, Expiration Date: {inventory[i].Expdate}");
                    }
                    continue;
                 
                }

                else if (response == "4")
                {
                    //4. exit the program
                    break;

                }

                else
                {
                    Console.WriteLine("Not a valid option. Please try again");
                    continue;
                }
            }
        }

        static void DeleteFoodItem()
        {

        }

        
    }
}