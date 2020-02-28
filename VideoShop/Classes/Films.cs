using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class Films
    {
        private string filmProducer;
        private string filmLeading;
        private string filmName;
        private int genreId;
        private int filmYear;
        public Films(string prod, string lead, string name, int genre, int year) 
        {
            filmProducer = prod;
            filmLeading = lead;
            filmName = name;
            genreId = genre;
            filmYear = year;
        }
        
        //getters
        public string getProducer()
        {
            return filmProducer;
        }
        public string getLeading()
        {
            return filmLeading;
        }
        public string getName()
        {
            return filmName;
        }
        public int getGenre()
        {
            return genreId;
        }
        public int getYear()
        {
            return filmYear;
        }
    }
}
