using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class Cities
    {
        private String cityName = "";
        public Cities()
        {

        }
        public Cities(string city)
        {
            this.cityName = city;
        }
        //setting data 
        public void setCity(string city)
        {
            this.cityName = city;
        }

        //getting data 
        public string getCity()
        {
            return cityName;
        }
    }
}
