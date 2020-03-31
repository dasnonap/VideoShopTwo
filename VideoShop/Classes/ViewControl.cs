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

        private Users loggedUser = new Users();
        private FilmsBuffer films = new FilmsBuffer();
        private SeriesBuffer series = new SeriesBuffer();
        private GenresBuffer genres = new GenresBuffer();
        private CitiesBuffer cities = new CitiesBuffer();
        private FilmsLibraryBuffer filmsLibrary = new FilmsLibraryBuffer();
        private SeriesLibraryBuffer seriesLibrary = new SeriesLibraryBuffer();
        private UsersBuffer users = new UsersBuffer();

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

            series.initializeSeriesArray();

            genres.initializeGenresArray();

            cities.initializeCitiesArray();

            users.initializeSubscriptions();

        }

        public bool checkUserCredentials(Users user)
        {
            if (!users.checkCredentials(user))
            {
                return false;
            }

            loggedUser = user;
            filmsLibrary.initializeFilmsForUser(loggedUser);
            seriesLibrary.initializeSeriesForUser(loggedUser);
            return true;
        }
        public string getLoggedEmail()
        {
            return loggedUser.getEmail();
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
                case "FilmsLibrary":
                    {
                        foreach(FilmsLibrary f in filmsLibrary.returnRecords())
                        {
                            Films film = films.returnFilmByID(f.getFilmID());
                            film.setStringGenre(genres.returnGenre(film.getGenre()));

                            view.Items.Add(new ListViewItem( film.getStringArray() ) );
                        }

                        break;
                    }
                case "SeriesLibrary":
                    {
                        foreach(SeriesLibrary s in seriesLibrary.returnRecords())
                        {
                            Series serial = series.returnSeriesByID(s.getSeries());
                            serial.setStringGenre(genres.returnGenre(serial.getGenre()));

                            view.Items.Add( new ListViewItem( serial.getStringArray() ) );
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

       public void setData(Object data, string tableName)
        {
            switch (tableName)
            {
                case "Films":
                    {
                        films.insertRow( data as Films );
                        break;
                    }
                case "Users":
                    {
                        users.insertRow(data as Users);
                        loggedUser = data as Users;

                        filmsLibrary.initializeFilmsForUser(loggedUser);
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
