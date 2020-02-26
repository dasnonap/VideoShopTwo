using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class ServicesNames
    {
        private string servName;
        private float servPrice = 0;
        public ServicesNames(string name, float price) {
            servName = name;
            servPrice = price;
        }
        public string getServName()
        {
            return servName;
        }
        public float getServPrice()
        {
            return servPrice;
        }
    }
}
