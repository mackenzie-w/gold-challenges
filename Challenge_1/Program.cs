using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu meal1 = new Menu(1, "Pancakes", "Golden flapjacks served with side options of fruit, sausages, eggs, and coffee. Complimentary orange juice.", "Ingredients: flour, baking powder, milk, eggs, sugar, salt, unsalted butter, vegetable oil, assorted toppings: butter, maple syrup, confectioner's sugar, honey, jams, preserves, whipped cream.", 4.99m);
            Menu meal2 = new Menu(2, "Waffles", "Crispy, fluffy waffles fresh from the waffle iron served with side options of fruit, sausages, eggs, and coffee. Complimentary orange juice.", "Ingredients: eggs, flour, milk, vegetable oil, sugar, baking powder, salt, vanilla extract, assorted toppings: butter, maple syrup, confectioner's sugar, honey, jams, preserves, whipped cream.", 4.99m);
            Menu meal3 = new Menu(3, "Crepes", "Thin French pastries served sweet or savory with side options of fruit, sausages, eggs, and coffee. Complimentary orange juice.", "Ingredients: flour, salt, eggs, sugar, whole milk, unsalted butter. Sweet: add vanilla extract, fill with jam, honey, sugar, chocolate hazelnut spread, peanut butter, bananas, etc. Savory: no vanilla extract, fill with shrimp or chicken or bacon with assorted vegetables and herbs.", 6.99m);
            Menu meal4 = new Menu(4, "French Toast", "Bread slices soaked in eggs and milk, and then fried. Served with side options of fruit, sausages, eggs, and coffee. Complimentary orange juice.", "Ingredients: eggs, vanilla extract, nutmeg, bread, vegetable oil, milk, cinnamon, salt, unsalted butter, assorted toppings: butter, maple syrup, confectioner's sugar, honey, jams, preserves, whipped cream.", 5.99m);
            Menu meal5 = new Menu(5, "Oatmeal", "Whole oat grains mixed with your choice of fruit, served with side options of fruit, sausages, eggs, and coffee. Complimentary orange juice.", "Ingredients: whole grain oats, milk, salt, water, honey.", 3.99m);

            MenuRepository menuRepo = new MenuRepository();

            menuRepo.AddItemToList(meal1);
            menuRepo.AddItemToList(meal2);
            menuRepo.AddItemToList(meal3);
            menuRepo.AddItemToList(meal4);
            menuRepo.AddItemToList(meal5);

            List<Menu> meals = menuRepo.GetList();
            while(true)
            {
                Console.WriteLine("Enter the NUMBER you would like to select:\n" +
               "1. List all menu items.\n" +
               "2. Add a menu item. \n" +
               "3. Remove a menu item. \n" +
               "4. Exit Console. \n");

                string optionAsString = Console.ReadLine();
                int option = int.Parse(optionAsString);

                if (option == 1)
                {
                    foreach (Menu meal in meals)
                    {
                        Console.WriteLine($"Meal Name: {meal.MealName}\n" +
                            $"Menu Number: {meal.MealNumber}\n" +
                            $"Meal Description: {meal.MealDescription}\n" +
                            $"Meal Ingredients: {meal.MealListOfIngredients}\n" +
                            $"Meal Price: {meal.MealPrice} \n");
                    }
                }

                if (option == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter a meal number: ");
                        int mealnumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter a meal name: ");
                        string mealname = Console.ReadLine();
                        Console.WriteLine("Enter a meal description: ");
                        string mealdescription = Console.ReadLine();
                        Console.WriteLine("Enter the meal ingredients: ");
                        string mealingredients = Console.ReadLine();
                        Console.WriteLine("Enter a meal price: ");
                        decimal mealprice = decimal.Parse(Console.ReadLine());

                        Menu userMeal = new Menu(mealnumber, mealname, mealdescription, mealingredients, mealprice);
                        menuRepo.AddItemToList(userMeal);

                        Console.WriteLine("\n Would you like to add another meal item? y/n");
                        string response = Console.ReadLine();
                        response = response.ToLower();
                        if (response == "y") { }
                        else if (response == "n")
                        {
                            break;
                        }
                    }
                }

                if (option == 3)
                {
                    while (true)
                    {
                        Console.WriteLine("What meal would you like to remove? Enter a NUMBER:");
                        int number = int.Parse(Console.ReadLine());
                        menuRepo.RemoveItemFromList(number);


                        Console.WriteLine("Do you want to delete another item? y/n");
                        string response = Console.ReadLine();
                        response = response.ToLower();
                        if (response == "y") { }
                        else if (response == "n")
                        {
                            break;
                        }
                    }
                }

                if (option == 4)
                {
                    break;

                }
            }
        }        
    }
}
