using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.TableClasses;
using VideoShop.BufferClasses;
using System.Windows.Forms;

namespace VideoShop.Classes
{
    class ViewControl
    {
        private static ViewControl _instance = null;
        private static readonly object _syncObject = new object();

        private FilmsBuffer films = new FilmsBuffer();
        private GenresBuffer genres = new GenresBuffer();
        private CitiesBuffer cities = new CitiesBuffer();
        public static ViewControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new ViewControl();
                        }
                    }
                }
                return _instance;
            }
        }
        public ViewControl()
        {
            films.initializeFilmsArray();

            genres.initializeGenresArray();

            cities.initializeCitiesArray();
        }

        public void fillViewControl(ListView view, string sectionName)
        {
            switch (sectionName)
            {
                case "films":
                    {
                        foreach(Films f in films.returnRecords())
                        {
                            f.setStringGenre(genres.returnGenre(f.getGenre()));
                            view.Items.Add(new ListViewItem(f.getStringArray()));
                        }
                        break;
                    }
                case "cities":
                    {
                        foreach(Cities c in cities.returnRecords())
                        {
                            view.Items.Add(new ListViewItem(c.getCitiesArray()));
                        }
                        break;
                    }
            }
        }
        public void searchResult(ListView view, string sectionName, string searchQuery)
        {
            view.Items.Clear();
            switch (sectionName)
            {
                case "films":
                    {
                        foreach(Films f in films.returnRecords())
                        {
                            if(f.getStringGenre() == searchQuery)
                            {
                                view.Items.Add(new ListViewItem(f.getStringArray()));
                            }
                        }
                        break;
                    }
            }
        }

       public void setData(string data, string tableName)
        {
            string[] array = data.Split(',');
            switch (tableName)
            {
                case "Films":
                    {
                        films.insertRow( new Films( array[0], array[1], array[2], genres.returnID(array[3]), Int32.Parse(array[4]) ) );

                        break;
                    }
            }
        }

       public void chandeData(Object data, string tableName)
        {
            switch (tableName)
            {
                case "Films":
                    {
                        Films f = data as Films;
                        f.setGenre(genres.returnID(f.getStringGenre()));
                        films.changeRow(f);
                        break;
                    }
            }
        }

        public void deleteData(Object data, string tableName)
        {
            switch (tableName)
            {
                case "Films":
                    {
                        films.deleteRow(data as Films);
                        break;
                    }
            }
        }

        public int getID(string name, string className)
        {
            switch (className)
            {
                case "Films":
                    {
                        return films.getID(name);
                        
                    }

            }
            return 0;
        }
         
    }
}
