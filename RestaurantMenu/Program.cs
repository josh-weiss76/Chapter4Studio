using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace RestaurantMenu
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            List<MenuItem> currentMenuItems = Menu.CompleteMenu();
            string updateDate = Menu.LastUpdate();

            Console.WriteLine("The menu was last updated on " + updateDate);
            Console.WriteLine("The current date and time is " + date1);
            Console.WriteLine(currentMenuItems.Count);
            PrintMenu();
            PrintItem();
            PrintUpdatedMenu();

        }
        private static void PrintMenu()
        {
            List<MenuItem> currentMenuItems = Menu.CompleteMenu();
            for (int i = 0; i < currentMenuItems.Count; i++)
            {
                Console.WriteLine("Item " + (i + 1));
                Console.WriteLine(currentMenuItems[i].Name);
                Console.WriteLine("Description: " + currentMenuItems[i].Description);
                Console.WriteLine("Price: " + currentMenuItems[i].Price);
            }
        }

        private static void PrintItem()
        {
            List<MenuItem> currentMenuItems = Menu.CompleteMenu();
            Console.WriteLine("Please select a number from 1 to " + currentMenuItems.Count + ": ");
            int itemSelected = int.Parse(Console.ReadLine());
            Console.WriteLine("The item you selected is below: ");
            Console.WriteLine("Item " + (itemSelected));
            Console.WriteLine(currentMenuItems[itemSelected-1].Name);
            Console.WriteLine("Description: " + currentMenuItems[itemSelected-1].Description);
            Console.WriteLine("Price: " + currentMenuItems[itemSelected-1].Price);

        }

        private static void PrintUpdatedMenu()
        {
            List<MenuItem> currentMenuItems = Menu.UpdatedMenu();
            for (int i = 0; i < currentMenuItems.Count; i++)
            {
                Console.WriteLine("Item " + (i + 1));
                Console.WriteLine(currentMenuItems[i].Name);
                Console.WriteLine("Description: " + currentMenuItems[i].Description);
                Console.WriteLine("Price: " + currentMenuItems[i].Price);
            }

        }
    }
}
