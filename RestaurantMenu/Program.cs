using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            List<MenuItem> currentMenuItems = Menu.CompleteMenu();
            string updateDate = Menu.LastUpdate();

            Console.WriteLine("The current date and time is " + date1);
            Console.WriteLine("The menu was last updated on " + updateDate);
            Console.WriteLine(currentMenuItems);

        }
    }
}
