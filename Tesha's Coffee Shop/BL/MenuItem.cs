using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.DL;

namespace Tesha_s_Coffee_Shop.BL
{
    class MenuItemBL
    {
        private string name;
        private string type;
        private int price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public MenuItemBL() { }
        public MenuItemBL(string name,string type,int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
        public MenuItemBL(string name,int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
