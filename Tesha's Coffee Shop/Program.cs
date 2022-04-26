using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using Tesha_s_Coffee_Shop.DL;
using Tesha_s_Coffee_Shop.UI;

namespace Tesha_s_Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string itemsPath = "MenuItems.txt";
            string orderPath = "OrderedItems.txt";
            if(menuItemDL.readFromFile(itemsPath))
            {
                Console.WriteLine("Menu Items loaded successfully ..");
            }
            if(coffeeShopDL.readFromFile(orderPath))
            {
                Console.WriteLine("Ordered Items loaded successfully ..");
            }
            while(true)
            {
                char op = MenuUi.MainMenu();
                if(op == '1')
                {
                    MenuItemBL item = MenuItemUI.AddMenuItem();
                    menuItemDL.addIntoList(item);
                    menuItemDL.storeintoFile(itemsPath, item);      
                }
                else if(op=='2')
                {
                    MenuItemUI.viewCheapestItem();
                }
                else if (op == '3')
                {
                    MenuItemUI.drinkMenu(menuItemDL.MenuList);
                }
                else if (op == '4')
                {
                    MenuItemUI.FoodMenu(menuItemDL.MenuList);
                }
                else if (op == '5')
                {
                   MenuItemBL order =  coffeeshopUI.addorder();
                    if(order != null)
                    {
                        coffeeShopDL.addOrderIntoArray(order);
                    }
                    else
                    {
                        Console.WriteLine("This Item is currently unavailable..");
                    }
                    coffeeshopUI.clearScreen();
                }
                else if (op == '6')
                {
                    coffeeshopUI.fulfill_Order(coffeeShopDL.ordersList);
                }
                else if (op == '7')
                {
                    coffeeshopUI.viewOrdersList(coffeeShopDL.ordersList);

                }
                else if (op == '8')
                {
                    MenuItemUI.total_pay_amount();
                }
                else if (op == '9')
                {
                    coffeeShopDL.storeintoFile(orderPath,coffeeShopDL.ordersList);
                    break;
                }
            }
        }
    }
}
