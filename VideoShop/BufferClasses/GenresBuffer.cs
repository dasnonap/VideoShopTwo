using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.TableClasses;
using VideoShop.Classes;
using System.Windows.Forms;

namespace VideoShop.BufferClasses
{
    class GenresBuffer
    {
        private TableTemplate<Genres> genresTable = new TableTemplate<Genres>();
        private List<Object> genresArray = new List<Object>();

        public bool initializeGenresArray()
        {
            if( !genresTable.Select("GENRES", genresArray))
            {
                MessageBox.Show("Неуспешно зареждане на данните");
                return false;
            }
            return true;
        }
        public List<Object> returnRecords()
        {
            return genresArray;
        }
        public int returnID(string genre)
        {
            foreach(Genres g in genresArray)
            {
                if(g.getGenreName() == genre)
                {
                    return g.getGenreID();
                }
            }
            return 0;
        }
        public string returnGenre(int a)
        {
            foreach(Genres g in genresArray)
            {
                if(g.getGenreID() == a)
                {
                    return g.getGenreName();
                }
            }
            return null;
        }
    }
}
