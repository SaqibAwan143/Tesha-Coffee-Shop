using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.DL;

namespace Tesha_s_Coffee_Shop.BL
{
    class CoffeeShopBL
    {
        private string CoffeeName;
        public string coffeeName
        {
            get { return CoffeeName; }
            set { CoffeeName = value; }
        }
        public CoffeeShopBL() { }
        public CoffeeShopBL(string name)
        {
            this.coffeeName = name;
        }
    }
}
