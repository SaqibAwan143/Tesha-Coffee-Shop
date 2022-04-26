using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using System.IO;

namespace Tesha_s_Coffee_Shop.DL
{
    class coffeeShopDL
    {
        public static List<MenuItemBL> ordersList = new List<MenuItemBL>();
        public static void addOrderIntoArray(MenuItemBL n)
        {
            ordersList.Add(n);
        }
        public static bool checkFulfill()
        {
            if (ordersList.Count > 0)
            {
                ordersList.Clear();
                return true;
            }
           return false;
        }
        public static int payable_amount()
        {
            int total = 0;
            if (ordersList.Count > 0)
            {
                for (int i = 0; i < ordersList.Count; i++)
                {
                    total = total + menuItemDL.MenuList[i].Price;
                }
                return total;
            }
            else
            {
                return 0;
            }
        }
        public static void storeintoFile(string path, List<MenuItemBL> s)
        {
            StreamWriter f = new StreamWriter(path, true);
            for (int i = 0; i < s.Count; i++)
            {
                f.WriteLine(s[i].Name+","+s[i].Price);
            }
            f.Flush();
            f.Close();
        }
        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    int price = int.Parse(splittedRecord[1]);
                    MenuItemBL menu = new MenuItemBL(name, price);
                    //string type = splittedRecord[1];
                    //int price = int.Parse(splittedRecord[2]);
                    addOrderIntoArray(menu);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
