using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using Tesha_s_Coffee_Shop.DL;

namespace Tesha_s_Coffee_Shop.UI
{
    class coffeeshopUI
    {
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
            Console.Clear();
        }

        public static MenuItemBL addorder()
        {
            Console.WriteLine("Enter the item Name : ");
            string item = Console.ReadLine();
            MenuItemBL check = menuItemDL.checkItem(item);
            if (check != null)
            {
                return check;
            }
            else
            {
                return null;
            }
        }
        public static void fulfill_Order(List<MenuItemBL> order)
        {
            bool full = coffeeShopDL.checkFulfill();
            if (full)
            {
                for (int i = 0; i < order.Count; i++)
                {
                    Console.WriteLine("The " + order[i] + " is ready !!");
                }
            }
            else
            {
                Console.WriteLine("All orders have been fulfilled!");
            }
            clearScreen();
        }
        public static void viewOrdersList(List<MenuItemBL> order)
        {
            if (order.Count > 0)
            {
                Console.WriteLine("Name");
                for (int i = 0; i < order.Count; i++)
                {
                    Console.WriteLine(order[i]);
                }
            }
            else
            {
                Console.WriteLine("All the orders have been Fullfilled..");
            }
            clearScreen();
        }
    }
}
