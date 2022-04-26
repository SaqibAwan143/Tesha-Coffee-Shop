using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using System.IO;

namespace Tesha_s_Coffee_Shop.DL
{
    class menuItemDL
    {
        public static List<MenuItemBL> MenuList = new List<MenuItemBL>();
        public static void addIntoList(MenuItemBL menu)
        {
            MenuList.Add(menu);
        }
        
        public static MenuItemBL checkItem(string item)
        {
            for (int i = 0; i < MenuList.Count; i++)
            {
                if(item == MenuList[i].Name)
                {
                    return MenuList[i];
                }
            }
            return null;
        }
        
        public static MenuItemBL checkCheapest()
        {
            List<MenuItemBL> sorted = MenuList.OrderBy(o => o.Price).ToList();
            MenuItemBL item = new MenuItemBL();
            item = sorted[0];
            return item;
        }
        public static void storeintoFile(string path, MenuItemBL s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.Name + "," + s.Type + "," + s.Price);
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
                    string type = splittedRecord[1];
                    int price = int.Parse(splittedRecord[2]);
                    MenuItemBL s = new MenuItemBL(name, type, price);
                    addIntoList(s);
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
