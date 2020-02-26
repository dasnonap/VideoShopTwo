using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class Genres
    {
        private string genreName;

        //Constructor
        public Genres(string genre)
        {
            genreName = genre;
        }
        public Genres() { }

        public void setGenreName(String name)
        {
            genreName = name;
        }
        public string getGenreName()
        {
            return genreName;
        }
        
    }
}
