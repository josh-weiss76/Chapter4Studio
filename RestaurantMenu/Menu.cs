using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public static List<MenuItem> CompleteMenu()
        {
            var fullMenu = new List<MenuItem>();
            MenuItem item1 = new MenuItem("Burrito", 7.99, "Beef, bean, and cheese", "entree", false);
            MenuItem item2 = new MenuItem("Taco", 3.99, "Beef, cheese, lettuce, and tomato in a crispy taco shell", "entree", false);
            MenuItem item3 = new MenuItem("Quesadilla", 6.99, "Beef and cheese", "entree", true);
            //var addItem = true;

            //while (addItem)
            //{
            //    MenuItem newMenuItem = new MenuItem();

            //    Console.WriteLine("Item name: ");
            //    newMenuItem.Name = Console.ReadLine();

            //    Console.WriteLine("Price: ");
            //    newMenuItem.Price = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Description: ");
            //    newMenuItem.Description = Console.ReadLine();

            //    Console.WriteLine("Category (appetizer, entree, dessert): ");
            //    newMenuItem.Category = Console.ReadLine();

            //    Console.WriteLine("Is this a new menu item (less than 1 month old)? y/n: ");
            //    if (Console.ReadLine() != "y")
            //    {
            //        newMenuItem.IsNew = false;
            //    }

            fullMenu.Add(item1);
            fullMenu.Add(item2);
            fullMenu.Add(item3);
                //Console.WriteLine("Add another item? y/n: ");
                //if (Console.ReadLine() != "y")
                //{
                //    addItem = false;
                //}
            //}

            return fullMenu;
        }
        public static string LastUpdate()
        {
            Console.WriteLine("Please enter date of menu update (MM/DD/YYYY): ");
            string dateOfUpdate = Console.ReadLine();
            return dateOfUpdate;
        }

        public static List<MenuItem> UpdatedMenu()
        {
            var UpToDateMenu = CompleteMenu();
            Console.WriteLine("Which item would you like to remove? (Enter 1 to " + UpToDateMenu.Count);
            int itemNumber = int.Parse(Console.ReadLine()) -1;
            UpToDateMenu.RemoveAt(itemNumber);
            return UpToDateMenu;
        }
    }
}
