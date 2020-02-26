using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class Countries
    {
        private string countryName;
        private Countries() { }
        private Countries(string name)
        {
            countryName = name;
        }
        private void setCountry(string name)
        {
            countryName = name;
        }
        private string getCountry()
        {
            return countryName;
        }
    }
}
