using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using Tesha_s_Coffee_Shop.DL;

namespace Tesha_s_Coffee_Shop.UI
{
    class MenuUi
    {
        public static char MainMenu()
        {
            Console.WriteLine("1. Add a Menu item");
            Console.WriteLine("2. View the Cheapest Item in the menu");
            Console.WriteLine("3. View the Drink’s Menu");
            Console.WriteLine("4. View the Food’s Menu");
            Console.WriteLine("5. Add Order");
            Console.WriteLine("6. Fulfill the Order");
            Console.WriteLine("7. View the Orders’s List");
            Console.WriteLine("8. Total Payable Amount");
            Console.WriteLine("9. Exit");
            Console.WriteLine("Your Option ...");
            char option = char.Parse(Console.ReadLine());
            MenuItemUI.clearScreen();
            return option;
        }
        
    }
}
