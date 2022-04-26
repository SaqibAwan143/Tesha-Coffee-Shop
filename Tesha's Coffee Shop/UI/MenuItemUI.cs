using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using Tesha_s_Coffee_Shop.DL;

namespace Tesha_s_Coffee_Shop.UI
{
    class MenuItemUI
    {
        public static MenuItemBL AddMenuItem()
        {
            MenuItemBL menu = new MenuItemBL(); 
            Console.WriteLine("Enter the Name : ");
            menu.Name = Console.ReadLine();
            Console.WriteLine("Enter the Type : ");
            menu.Type = Console.ReadLine();
            Console.WriteLine("Enter the price : ");
            menu.Price = int.Parse(Console.ReadLine());
            clearScreen();
            return menu;
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
            Console.Clear();
        }
        public static void viewCheapestItem()
        {
            MenuItemBL item = menuItemDL.checkCheapest();
            Console.WriteLine("Name\tPrice");
            Console.WriteLine(item.Name+"\t"+item.Price);
            clearScreen();
        }
        public static void drinkMenu(List<MenuItemBL> items)
        {
            Console.WriteLine("Name\tPrice");
            for (int i = 0; i < items.Count; i++)
            {
                if(items[i].Type == "drink" || items[i].Type == "Drink")
                {
                    Console.WriteLine(items[i].Name+"\t"+items[i].Price);
                }
            }
            clearScreen();
        }
        public static void FoodMenu(List<MenuItemBL> items)
        {
            Console.WriteLine("Name\tPrice");
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Type == "food" || items[i].Type == "Food")
                {
                    Console.WriteLine(items[i].Name + "\t" + items[i].Price);
                }
            }
            clearScreen();
        }
        
        public static void total_pay_amount()
        {
            int price = coffeeShopDL.payable_amount();
            if(price > 0)
            {
                Console.WriteLine("Total payable amount is "+price+" Rupees..");
            }
            else
            {
                Console.WriteLine("There are no orders yet..");
            }
            clearScreen();
        }
        
    }
}
