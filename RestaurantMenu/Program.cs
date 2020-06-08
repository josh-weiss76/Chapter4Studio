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

            Console.WriteLine("The current date and time is " + date1);
            Console.WriteLine("The menu was last updated on " + updateDate);
            Console.WriteLine(currentMenuItems.Count);
            PrintMenu();

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
    }
}
