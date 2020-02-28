using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class Series
    {
        private string seriesProd;
        private string seriesLeading;
        private string seriesName;
        private int seriesSeason;
        private int seriesYear;

        public Series(string prod, string lead, string name, int season, int year)
        {
            seriesProd = prod;
            seriesLeading = lead;
            seriesName = name;
            seriesSeason = season;
            seriesYear = year;
        }
        public string getProd()
        {
            return seriesProd;
        }       
        public string getLead()
        {
            return seriesLeading;
        }
        public string getName()
        {
            return seriesName;
        }
        public int getSeason()
        {
            return seriesSeason;
        }
        public int getYear()
        {
            return seriesYear;
        }
    }
}
