﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class Series
    {
        private int seriesID;
        private string seriesProd;
        private string seriesLeading;
        private string seriesName;
        private int seriesSeason;
        private int seriesGenre;
        private int seriesYear;

        //Constructors
        public Series(string prod, string lead, string name, int season, int genre, int year)
        {
            seriesProd = prod;
            seriesLeading = lead;
            seriesName = name;
            seriesSeason = season;
            seriesGenre = genre;
            seriesYear = year;
        }
        public Series(int id,string prod, string lead, string name, int season, int genre, int year)
        {
            seriesID = id;
            seriesProd = prod;
            seriesLeading = lead;
            seriesName = name;
            seriesSeason = season;
            seriesGenre = genre;
            seriesYear = year;
        }

        //setters
        public void setSeriesID(int id)
        {
            seriesID = id;
        }
        public void setProd(string prod)
        {
            seriesProd = prod;
        }
        public void setLead(string lead)
        {
            seriesLeading = lead;
        }
        public void setName(string name)
        {
            seriesName = name;
        }
        public void setSeason(int season)
        {
            seriesSeason = season;
        }
        public void setGenre(int genre)
        {
            seriesGenre = genre;
        }
        public void setYear(int year)
        {
            seriesYear = year;
        }

        //getters
        public int getSeriesID()
        {
            return seriesID;
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
        public int getGenre()
        {
            return seriesGenre;
        }
        public int getYear()
        {
            return seriesYear;
        }
    }
}
