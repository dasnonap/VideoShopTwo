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
        private Films filterItem = new Films();

        private FilmsBuffer films = new FilmsBuffer();
        private SeriesBuffer series = new SeriesBuffer();
        private GenresBuffer genres = new GenresBuffer();
        private CitiesBuffer cities = new CitiesBuffer();
        private TypesBuffer types = new TypesBuffer();
        private EmployeesBuffer employees = new EmployeesBuffer();
        private ServicesNamesBuffer services = new ServicesNamesBuffer();
        private PositionsBuffer positions = new PositionsBuffer();
        private FilmsLibraryBuffer filmsLibrary = new FilmsLibraryBuffer();
        private SeriesLibraryBuffer seriesLibrary = new SeriesLibraryBuffer();
        private SubscriptionsBuffer subs = new SubscriptionsBuffer();
        private UsersBuffer users = new UsersBuffer();

        /// <summary>
        /// Инстанцията на този клас 
        /// </summary>
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

            services.initializeServicesArray();

            types.initializeTypesArray();

            employees.initializeServicesArray();

            positions.initializePositionsArray();

        }

        /// <summary>
        /// Функцията връща масива от жанрове
        /// </summary>
        /// <returns>Масива от жанрове</returns>
        public List<Object> getGenresArray()
        {
            return genres.returnRecords();
        }

        /// <summary>
        /// Връща масив от позиции
        /// </summary>
        /// <returns>Връща зареденият масив от позиции</returns>
        public List<Object> getPositionsArray()
        {
            return this.positions.returnRecords();
        }

        /// <summary>
        /// Връща масив от градове
        /// </summary>
        /// <returns>Връща зареденият масив от градове</returns>
        public List<Object> getCitiesArray()
        {
            return cities.returnRecords();
        }

        /// <summary>
        /// Връща масив от Услуги
        /// </summary>
        /// <returns>Връща зареденият масив от услуги</returns>
        public List<Object> getServicesArray()
        {
            return services.returnRecords();
        }

        /// <summary>
        /// Връща масив от служители
        /// </summary>
        /// <returns>Връща масив от служители</returns>
        public List<Object> getEmployeesArray()
        {
            return employees.returnRecords();
        }

        /// <summary>
        /// Проверява информацията на потребителя, който се опитва да се логне
        /// </summary>
        /// <param name="user">Детайлите на потребителя, който е написал</param>
        /// <returns>Връща true ако съществува потребител със същата информация</returns>
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

        /// <summary>
        /// Взима email-a на вече логнатият потребител
        /// </summary>
        /// <returns>Връща email-a</returns>
        public string getLoggedEmail()
        {
            subs.initializeSubForUser(loggedUser);
            return loggedUser.getEmail();
        }
        public int getLoggedUserID()
        {
            return loggedUser.getUserID();
        }

        /// <summary>
        /// Връща абонамента на потребителя
        /// </summary>
        /// <returns>Връща абонамента на потребителя</returns>
        public Object getSubForUser()
        {          
            foreach(Subscriptions s in subs.returnRecords())
            {
                return s;
            }
            return null;
        }

        /// <summary>
        /// Запълва с данни посоченият ViewControl от масивите. Спрямо подадената опция
        /// </summary>
        /// <param name="view">ViewControl-ът, който ще запълваме с данни</param>
        /// <param name="sectionName">Използва се за да разграничим, с какви данни ще пълним ViewControl-a</param>
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
                case "series":
                    {
                        foreach (Series s in series.returnRecords())
                        {
                            s.setStringGenre(genres.returnGenre(s.getGenre()));
                            view.Items.Add(new ListViewItem(s.getStringArray()));
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
                case "genres":
                    {
                        foreach(Genres g in genres.returnRecords())
                        {
                            view.Items.Add(new ListViewItem(g.getGenreName()));
                        }
                        break;
                    }
                case "services":
                    {
                        foreach(ServicesNames s in services.returnRecords())
                        {
                            view.Items.Add(new ListViewItem(s.returnStringArray()));
                        }
                        break;
                    }
                case "types":
                    {
                        foreach (Types t in types.returnRecords())
                        {
                            view.Items.Add(new ListViewItem(t.getType()));
                        }
                        break;
                    }
                case "employees":
                    {
                        foreach(Employees e in employees.returnRecords())
                        {
                            e.setStringCity(cities.getCity(e.getCity()));
                            e.setStringPos(positions.getPosition(e.getPos()));
                            view.Items.Add(new ListViewItem(e.getStringEmployee()));
                        }
                        break;
                    }
                case "positions":
                    {
                        foreach(Positions p in positions.returnRecords())
                        {
                            view.Items.Add(new ListViewItem(p.getPosName()));
                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Запълва с данни посоченият ViewControl по подаден критерии
        /// </summary>
        /// <param name="view">ViewControl-a, който ще запълваме с данни</param>
        /// <param name="sectionName">Използва се за да разграничим, с какви данни ще пълним ViewControl-a</param>
        /// <param name="searchQuery">Критерият, по който ще търсим в масивите</param>
        public void searchResult(ListView view, string sectionName, string searchQuery)
        {
            view.Items.Clear();
            switch (sectionName)
            {
                case "films":
                    {
                        Genres g = new Genres(0, searchQuery);
                        foreach(Films f in films.adminSearch(g))
                        {
                            view.Items.Add(new ListViewItem(f.getStringArray()));
                        }
                        break;
                    }
                case "series":
                    {
                        Genres g = new Genres(0, searchQuery);
                        foreach(Series s in series.adminSearch(g))
                        {  
                            view.Items.Add(new ListViewItem(s.getStringArray()));
                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Задаване на данни, в определената таблица
        /// </summary>
        /// <param name="data">Данните, които ще вкарваме в масива и в базата данни</param>
        /// <param name="tableName">Името на таблицата, в която ще вкарваме данните</param>
       public void setData(Object data, string tableName)
        {
            switch (tableName)
            {
                case "Cities":
                    {
                        cities.insertRow(data as Cities);
                        break;
                    }
                case "Films":
                    {
                        Films f = data as Films;
                        f.setGenre(genres.returnID(f.getStringGenre()));
                        films.insertRow(f);
                        break;
                    }
                case "Series":
                    {
                        Series s = data as Series;
                        s.setGenre(genres.returnID(s.getStringGenre()));
                        series.insertRow(s);
                        break;
                    }
                case "Genres":
                    {
                        genres.insertRow(data as Genres);
                        break;
                    }
                case "ServicesNames":
                    {
                        services.insertRow(data as ServicesNames);
                        break;
                    }
                case "Types":
                    {
                        types.insertRow(data as Types);
                        break;
                    }
                case "Positions":
                    {
                        positions.insertRow(data as Positions);
                        break;
                    }
                case "Employees":
                    {
                        Employees e = data as Employees;
                        e.setPos(positions.getID(e.getStringPos()));
                        e.setCity(cities.getID(e.getStringCity()));
                        employees.insertRow(e);
                        break;
                    }
                case "Users":
                    {
                        users.insertRow(data as Users);
                        loggedUser = data as Users;

                        filmsLibrary.initializeFilmsForUser(loggedUser);
                        break;
                    }
                case "Subscriptions":
                    {
                        Subscriptions s = data as Subscriptions;
                        subs.insertRow(s);
                        break;
                    }
                case "FilmsLibrary":
                    {
                        filmsLibrary.insertRow(data as FilmsLibrary);
                        break;
                    }
                case "SeriesLibrary":
                    {
                        seriesLibrary.insertRow(data as SeriesLibrary);
                        break;
                    }

            }
        }

        /// <summary>
        /// Промяна на данни в определената таблица
        /// </summary>
        /// <param name="data">Данните, който ще променяме</param>
        /// <param name="tableName">Името на таблицата, чиито данни ще променяме</param>
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
                case "Series":
                    {
                        Series s = data as Series;
                        s.setGenre(genres.returnID(s.getStringGenre()));
                        series.changeRow(s);
                        break;
                    }
                case "Genres":
                    {
                        genres.changeRow(data as Genres);
                        break;
                    }
                case "Services":
                    {
                        services.changeRow(data as ServicesNames);
                        break;
                    }
                case "Types":
                    {
                        types.changeRow(data as Types);
                        break;
                    }
                case "Employees":
                    {
                        Employees e = data as Employees;
                        e.setPos(positions.getID(e.getStringPos()));
                        e.setCity(cities.getID(e.getStringCity()));
                        employees.changeRow(e);
                        break;
                    }
                case "Positions":
                    {
                        positions.changeRow(data as Positions);
                        break;
                    }
                case "Cities":
                    {
                        cities.changeRow(data as Cities);
                        break;
                    }
            }
        }

        /// <summary>
        /// Изтриване на данни от определена таблица
        /// </summary>
        /// <param name="data">Данните, който ще изтриваме</param>
        /// <param name="tableName">Името на таблицата, чиито данни ще изтриваме</param>
        public void deleteData(Object data, string tableName)
        {
            switch (tableName)
            {
                case "Films":
                    {
                        films.deleteRow(data as Films);
                        break;
                    }
                case "FilmsLibrary":
                    {
                        filmsLibrary.removeRecord(data as FilmsLibrary);
                        break;
                    }
                case "SeriesLibrary":
                    {
                        seriesLibrary.removeRecord(data as SeriesLibrary);
                        break;
                    }

                  
            }
        }

        /// <summary>
        /// Взимане на id от определената таблица
        /// </summary>
        /// <param name="name">Променливата, чиито id ще извличаме</param>
        /// <param name="className">Името на таблицата, от където ще взимаме id-то </param>
        /// <returns></returns>
        public int getID(string name, string className)
        {
            switch (className)
            {
                case "Films":
                    {
                        return films.getID(name);
                    }
                case "Series":
                    {
                        return series.getID(name);
                    }
                case "Genres":
                    {
                        return genres.getID(name);
                    }
                case "Services":
                    {
                        return services.getID(name);
                    }
                case "Types":
                    {
                        return types.getID(name);
                    }
                case "Employees":
                    {
                        return employees.getID(name);
                    }
                case "Positions":
                    {
                        return positions.getID(name);
                    }
                case "Cities":
                    {
                        return cities.getID(name);
                    }

            }
            return 0;
        }

        /// <summary>
        /// Запазване на данните за филтриране
        /// </summary>
        /// <param name="f">Данните за филтриране</param>
        public void setFilterItem(Films f)
        {
            filterItem = f;
        }

        /// <summary>
        /// Запълва с данни ViewControl-a след търсенето на данните
        /// </summary>
        /// <param name="view">ViewControl-a, който ще запълваме с данни </param>
        /// <param name="sectionName">Използва се за да разграничим, с какви данни ще пълним ViewControl-a</param>
        public void filterResult(ListView view, string sectionName)
        {
            filterItem.setGenre(genres.returnID(filterItem.getStringGenre()));
            switch (sectionName) 
            {
                case "Films":
                    {
                        foreach(Films f in films.searchByFilter(filterItem))
                        {
                            f.setStringGenre(genres.returnGenre(f.getGenre()));
                            view.Items.Add( new ListViewItem(f.getStringArray() ) );
                        }
                        break;
                    }
                case "Series":
                    {
                        Series filter = new Series();
                        filter.setDetails(filterItem);
                        filter.setStringGenre(genres.returnGenre(filter.getGenre()));
                        foreach(Series s in series.searchByFilter(filter))
                        {
                            s.setStringGenre( genres.returnGenre(s.getGenre()) );
                            view.Items.Add( new ListViewItem(s.getStringArray()) );
                        }
                        break;
                    }
            }

        }

    }
}
