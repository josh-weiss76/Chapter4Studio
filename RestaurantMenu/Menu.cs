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
            var addItem = true;

            while (addItem)
            {
                MenuItem newMenuItem = new MenuItem();

                Console.WriteLine("Item name: ");
                newMenuItem.Name = Console.ReadLine();

                Console.WriteLine("Price: ");
                newMenuItem.Price = double.Parse(Console.ReadLine());

                Console.WriteLine("Description: ");
                newMenuItem.Description = Console.ReadLine();

                Console.WriteLine("Category (appetizer, entree, dessert): ");
                newMenuItem.Category = Console.ReadLine();

                Console.WriteLine("Is this a new menu item (less than 1 month old)? y/n: ");
                if (Console.ReadLine() != "y")
                {
                    newMenuItem.IsNew = false;
                }

                fullMenu.Add(newMenuItem);
                Console.WriteLine("Add another item? y/n: ");
                if (Console.ReadLine() != "y")
                {
                    addItem = false;
                }
            }

            return fullMenu;
        }
        public static string LastUpdate()
        {
            Console.WriteLine("Please enter date of menu update (MM/DD/YYYY): ");
            string dateOfUpdate = Console.ReadLine();
            return dateOfUpdate;
        }
    }
}
