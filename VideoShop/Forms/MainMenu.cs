using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoShop.BufferClasses;
using VideoShop.Classes;
using VideoShop.Forms;

namespace VideoShop
{
    public partial class MainMenu : Form
    {
        private GenresBuffer genres = new GenresBuffer();

        private Point mouseDown = Point.Empty;

        private Dictionary<RadioButton, TabPage> userRadioPanelsPairs = new Dictionary<RadioButton, TabPage>();
        private Dictionary<RadioButton, TabPage> adminRadioPanelsPairs = new Dictionary<RadioButton, TabPage>();
        private Subscriptions userSubsc = new Subscriptions();

        private FilterForm filter = new FilterForm();
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функцията обработва какво се случва при зареждането на главния прозорец
        /// </summary>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(220, 93, 1);
            topPanel.BackColor = Color.FromArgb(134, 36, 0);
            adminTabView.Visible = false;
            userTabView.Visible = false;
            FillRadioButtons();

            navigationControl.ItemSize = new Size(0, 1);
            navigationControl.SizeMode = TabSizeMode.Fixed;



            adminTab.BackColor = Color.FromArgb(255, 192, 57);
            userTab.BackColor = Color.FromArgb(255, 192, 57);

            if (GlobalVariables.Instance.getAdminLogged())
            {
                navigationControl.SelectedTab = adminTab;
                adminTabView.Visible = true;
                adminTabView.ItemSize = new Size(0, 1);
                adminTabView.SizeMode = TabSizeMode.Fixed;


                addOfficeRadio.Checked = true;

                adminLoad();
            }
            else
            {
                navigationControl.SelectedTab = userTab;
                userTabView.Visible = true;
                userTabView.ItemSize = new Size(0, 1);
                userTabView.SizeMode = TabSizeMode.Fixed;



                showBegginingRadio.Checked = true;

                userLoad();
            }

        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        /// <summary>
        /// Тук взимаме всеки един радио бутон слагаме го в списък и променям начина на визуализация на самия радио бутон,
        /// след това взимаме съответните радио бутони и ги слагаме във мап със съотният панел за визуализация
        /// </summary>
        private void FillRadioButtons()
        {
            List<RadioButton> options = new List<RadioButton>();
            List<RadioButton> adminOptions = new List<RadioButton>();

            options.Add(showBegginingRadio);
            options.Add(showCatRadio);
            options.Add(showLibRadio);
            options.Add(showSeriesRadio);
            options.Add(showOptionRadio);
            options.Add(films);
            options.Add(series);

            foreach (RadioButton i in options)
            {
                i.Appearance = Appearance.Button;

            }
            userRadioPanelsPairs.Add(showBegginingRadio, beginingView);
            userRadioPanelsPairs.Add(showCatRadio, categoryView);
            userRadioPanelsPairs.Add(showLibRadio, libraryView);
            userRadioPanelsPairs.Add(showSeriesRadio, userSeriesView);
            userRadioPanelsPairs.Add(showOptionRadio, optionsView);


            adminOptions.Add(addOfficeRadio);
            adminOptions.Add(addFilmRadio);
            adminOptions.Add(addSeriesRadio);
            adminOptions.Add(addGenresRadio);
            adminOptions.Add(usersRadioButton);

            foreach (RadioButton i in adminOptions)
            {
                i.Appearance = Appearance.Button;
            }
            adminRadioPanelsPairs.Add(addOfficeRadio, officesView);
            adminRadioPanelsPairs.Add(addFilmRadio, filmsView);
            adminRadioPanelsPairs.Add(addSeriesRadio, seriesView);
            adminRadioPanelsPairs.Add(addGenresRadio, genresView);
            adminRadioPanelsPairs.Add(usersRadioButton, usersView);

        }

        /// Тук се обработват какво се случва при натискането на съответен радио бутон
        /// Navigation controls
        private void showBegginingRadio_CheckedChanged(object sender, EventArgs e)
        {
           

            getActiveOption();
        }

        private void showLibRadio_CheckedChanged(object sender, EventArgs e)
        {
            filmLibraryView.BackColor = Color.FromArgb(255, 192, 57);
            this.reloadFilmsSeries_Click(sender, e);
            getActiveOption();
        }

        private void showCatRadio_CheckedChanged(object sender, EventArgs e)
        {
            getActiveOption();
        }
        private void showSeriesRadio_CheckedChanged(object sender, EventArgs e)
        {
            seriesLibraryView.BackColor = Color.FromArgb(255, 192, 57);
            this.reloadFilmsSeries_Click(sender, e);
            getActiveOption();
        }
        private void showOptionRadio_CheckedChanged(object sender, EventArgs e)
        {
            startDateLabel.Text = userSubsc.getStartDate().ToString();
            endDateLabel.Text = userSubsc.getEndDate().ToString();
            foreach(ServicesNames s in ViewControl.Instance.getServicesArray())
            {
                if(s.getServID() == userSubsc.getServID())
                {
                    subTypeLabel.Text = s.getServName();
                    subPriceLabel.Text = s.getServPrice().ToString();
                }
            }
            getActiveOption();
        }

        private void addOfficeRadio_CheckedChanged(object sender, EventArgs e)
        {

            allOfficesView.BackColor = Color.FromArgb(255, 192, 57);
            allOfficesView.Items.Clear();
            ViewControl.Instance.fillViewControl(allOfficesView, "cities");
            getActiveOption();
        }

        private void addFilmRadio_CheckedChanged(object sender, EventArgs e)
        {
            allFilmsView.BackColor = Color.FromArgb(255, 192, 57);

            foreach (Genres s in genres.returnRecords())
            {
                genresCombo.Items.Add(s.getGenreName());
            }
            getActiveOption();
        }

        private void addSeriesRadio_CheckedChanged(object sender, EventArgs e)
        {
            allSeriesView.BackColor = Color.FromArgb(255, 192, 57);

            foreach (Genres s in genres.returnRecords())
            {
                seriesGenres.Items.Add(s.getGenreName());
            }
            getActiveOption();
        }

        private void addGenresRadio_CheckedChanged(object sender, EventArgs e)
        {
            allGenreView.BackColor = Color.FromArgb(255, 192, 57);
            allServicesView.BackColor = Color.FromArgb(255, 192, 57);
            allTypesView.BackColor = Color.FromArgb(255, 192, 57);
            getActiveOption();
        }
        private void usersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            allEmployeesView.BackColor = Color.FromArgb(255, 192, 57);
            allPositionsView.BackColor = Color.FromArgb(255, 192, 57); 
            getActiveOption();
        }
        //Navigation Control</end>

        /// <summary>
        /// Спрямо това кой радио бутон е активен от навигацията, го намираме в мапа и активираме съотният 
        /// TapPage за визуализация на данните
        /// </summary>
        private void getActiveOption()
        {
            if (!GlobalVariables.Instance.getAdminLogged())
            {
                foreach (var pair in userRadioPanelsPairs)
                {
                    if (pair.Key.Checked)
                    {
                        userTabView.SelectedTab = pair.Value;
                        pair.Value.BackColor = Color.FromArgb(220, 93, 1);
                    }
                }
            }
            else
            {
                foreach (var pair in adminRadioPanelsPairs)
                {
                    if (pair.Key.Checked)
                    {
                        adminTabView.SelectedTab = pair.Value;
                        pair.Value.BackColor = Color.FromArgb(220, 93, 1);
                    }
                }
            }
        }

        private void changeRecord_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Зареждане на главния прозорец в Мениджърски режим
        /// </summary>
        private void adminLoad()
        {
            genres.initializeGenresArray();

            ViewControl.Instance.fillViewControl(allFilmsView, "films");
            ViewControl.Instance.fillViewControl(allOfficesView, "cities");
            ViewControl.Instance.fillViewControl(allSeriesView, "series");
            ViewControl.Instance.fillViewControl(allGenreView, "genres");
            ViewControl.Instance.fillViewControl(allServicesView, "services");
            ViewControl.Instance.fillViewControl(allTypesView, "types");
            ViewControl.Instance.fillViewControl(allEmployeesView, "employees");
            ViewControl.Instance.fillViewControl(allPositionsView, "positions");
        }

        /// <summary>
        /// Зареждане на главния прозорец в Потребителски режим
        /// </summary>
        private void userLoad()
        {
            userNameLabel.Text = ViewControl.Instance.getLoggedEmail();
            welcomeLabel.Text = "Добре дошли отново " + userNameLabel.Text;

            ViewControl.Instance.fillViewControl(filmLibraryView, "FilmsLibrary");
            ViewControl.Instance.fillViewControl(seriesLibraryView, "SeriesLibrary");
            userSubsc = ViewControl.Instance.getSubForUser() as Subscriptions;
            checkSubscription();

            films.BackColor = Color.FromArgb(255, 192, 57);
            series.BackColor = Color.FromArgb(255, 192, 57);
            searchView.BackColor = Color.FromArgb(255, 192, 57);

            
        }

        //Subcription
        /// <summary>
        /// Проверява абонамента на потребителя
        /// </summary>
        private void checkSubscription()
        {
            if(userSubsc == null || DateTime.Compare(DateTime.Now, userSubsc.getEndDate()) > 0)
            {
                subLabel.Text = "Вашият абонамент изтича подновете го сега!";
                actSubs.Visible = true;
                showLibRadio.Enabled = false;
                showCatRadio.Enabled = false;
                showSeriesRadio.Enabled = false;
                showOptionRadio.Enabled = false;
            }
            else
            {
                subLabel.Text = "Вашият абонамент изтича на " + userSubsc.getEndDate();
            }
        }
        /// <summary>
        /// Създава форма, която да създаде форма за услугите
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actSubs_Click(object sender, EventArgs e)
        {
            AddSubscMenu addsubs = new AddSubscMenu(ViewControl.Instance.getLoggedUserID(), ViewControl.Instance.getServicesArray(), true, "");
            addsubs.Show();
        }


        //Films and Series controls
        /// <summary>
        /// В зависимост от активният tab control се зареждат данните 
        /// в активното ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            switch (adminTabView.SelectedTab.Name)
            {
                case "filmsView":
                    {
                        string selCombo = genresCombo.SelectedItem.ToString();
                        ViewControl.Instance.searchResult(allFilmsView, "films", selCombo);
                        break;
                    }
                case "seriesView":
                    {
                        string selCombo = seriesGenres.SelectedItem.ToString();
                        ViewControl.Instance.searchResult(allSeriesView, "series", selCombo);
                        break;
                    }
            }           
            
        }
        public static string row = null;
        /// <summary>
        /// Създава контекстното меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Point startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
                addFilmSeriesStrip.Show(startPoint);
                ListViewItem itemRow = searchView.SelectedItems[0];
                for (int i = 0; i < itemRow.SubItems.Count; i++)
                {
                    row += itemRow.SubItems[i].Text + ",";
                }
            }
            searchView.SelectedItems.Clear();
        }

        /// <summary>
        /// Обработва добавянето на филми или сериали в любими 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToFav_Click(object sender, EventArgs e)
        {
            if (films.Checked)
            {
                string[] array = row.Split(',');

                int filmID = ViewControl.Instance.getID(array[2], "Films");
                FilmsLibrary film = new FilmsLibrary();
                film.setFilmID(filmID);
                film.setUserID(ViewControl.Instance.getLoggedUserID());
                ViewControl.Instance.setData(film, "FilmsLibrary");
            }

            if (series.Checked)
            {
                string[] array = row.Split(',');

                int seriesID = ViewControl.Instance.getID(array[2], "Series");
                SeriesLibrary series = new SeriesLibrary();
                series.setSeries(seriesID);
                series.setUser(ViewControl.Instance.getLoggedUserID());
                ViewControl.Instance.setData(series, "SeriesLibrary");
            }
            row = "";
        }

        /// <summary>
        /// Презареждането на ListView контрола спрямо кой tab control е активен
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reloadFilmsSeries_Click(object sender, EventArgs e)
        {
            if(userTabView.SelectedTab.Name == "libraryView")
            {
                filmLibraryView.Items.Clear();
                ViewControl.Instance.fillViewControl(filmLibraryView, "FilmsLibrary");
            }

            if(userTabView.SelectedTab.Name == "userSeriesView")
            {
                seriesLibraryView.Items.Clear();
                ViewControl.Instance.fillViewControl(seriesLibraryView, "SeriesLibrary");
            }
        }

        /// <summary>
        /// Създава контекстното меню за премахване на филм от любими
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filmLibraryView_MouseClick(object sender, MouseEventArgs e)
        {
            Point startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
            ListViewItem itemRow = null;
            deleteFilmSeriesLibrary.Show(startPoint);
            if (userTabView.SelectedTab.Name == "libraryView")
            {
               itemRow = filmLibraryView.SelectedItems[0];
            }
            if (userTabView.SelectedTab.Name == "userSeriesView")
            {
                itemRow = seriesLibraryView.SelectedItems[0];
            }
            for (int i = 0; i < itemRow.SubItems.Count; i++)
            {
                row += itemRow.SubItems[i].Text + ",";
            }
            filmLibraryView.SelectedItems.Clear();
            seriesLibraryView.SelectedItems.Clear();
        }
        /// <summary>
        /// Създава контекстното меню за премахване на сериали от любими
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delLibraryBut_Click(object sender, EventArgs e)
        {
            string[] array = row.Split(',');
            if (userTabView.SelectedTab.Name == "libraryView")
            {
                int filmID = ViewControl.Instance.getID(array[2], "Films");
                FilmsLibrary film = new FilmsLibrary();
                film.setFilmID(filmID);
                film.setUserID(ViewControl.Instance.getLoggedUserID());
                ViewControl.Instance.deleteData(film, "FilmsLibrary");
            }
            if (userTabView.SelectedTab.Name == "userSeriesView")
            {
                int seriesID = ViewControl.Instance.getID(array[2], "Series");
                SeriesLibrary series = new SeriesLibrary();
                series.setSeries(seriesID);
                series.setUser(ViewControl.Instance.getLoggedUserID());
                ViewControl.Instance.deleteData(series, "SeriesLibrary");
            }
            this.reloadFilmsSeries_Click(sender, e);

            row = "";
        }

        /// <summary>
        /// Взима информацията от избрания ред за даден запис
        /// </summary>
        private void allFilmsView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                
                Point startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);

                rightClickStrip.Show(startPoint);

                if (adminTabView.SelectedTab.Name != "filmsView")
                {
                    ListViewItem itemRow = allSeriesView.SelectedItems[0];

                    for (int i = 0; i < itemRow.SubItems.Count; i++)
                    {
                        row += itemRow.SubItems[i].Text + ",";
                    }
                    
                }
                else
                {
                    ListViewItem itemRow = allFilmsView.SelectedItems[0];

                    for (int i = 0; i < itemRow.SubItems.Count; i++)
                    {
                        row += itemRow.SubItems[i].Text + ",";
                    }
                    
                }
                            
            }
            allSeriesView.SelectedItems.Clear();
            allFilmsView.SelectedItems.Clear();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        /// <summary>
        /// Обработва опцията от каскадното меню Промени за даден запис. Мениджърски режим
        /// </summary>
        private void Add_Click(object sender, EventArgs e)
        {
            bool isFilm = true;
            if (adminTabView.SelectedTab.Name == "seriesView")
            {
                isFilm = false;
            }
            OptionsMenuFilms options = new OptionsMenuFilms(row, false, genres.returnRecords(), isFilm);
            row = null;
            options.Show();
        }

        /// <summary>
        /// Отваря прозореца за въвеждане на нов филм в базата данни. Мениджърски режим
        /// </summary>
        private void add_Click_1(object sender, EventArgs e)
        {
            bool isFilm = true;
            if (adminTabView.SelectedTab.Name == "seriesView")
            {
                isFilm = false;
            }
            OptionsMenuFilms options = new OptionsMenuFilms(row, true, genres.returnRecords(), isFilm);
            options.Show();
        }

        /// <summary>
        /// Презареждане на филмите. Използва се в мениджърски режим
        /// </summary>
        private void Reload_Click(object sender, EventArgs e)
        { 
            switch (adminTabView.SelectedTab.Name)
            {
                case "filmsView":
                    {
                        allFilmsView.Items.Clear();
                        ViewControl.Instance.fillViewControl(allFilmsView, "films");
                        break;
                    }
                case "seriesView":
                    {
                        allSeriesView.Items.Clear();
                        ViewControl.Instance.fillViewControl(allSeriesView, "series");
                        break;
                    }
            }
        }

        /// <summary>
        /// Обработва опцията от каскадното меню при натискане на Изтриване при логване в мениджърски режим
        /// </summary>
        private void Delete_Click(object sender, EventArgs e)
        {
            Films f = new Films();
            string[] arr = row.Split(',');
            f.setName(arr[2]);
            ViewControl.Instance.deleteData(f, "Films");
            
        }

        /// <summary>
        /// Отваря прозореца за създаване на филтъра на търсене на филм / сериал
        /// </summary>
        private void filters_Click(object sender, EventArgs e)
        {
            FilterForm filter = new FilterForm();
            filter.Show();
        }

        /// <summary>
        /// Извежда всички филми или сериали по запаметеният филтър
        /// </summary>
        private void search_Click(object sender, EventArgs e)
        {
            searchView.Items.Clear();
            if (films.Checked)
            {
                ViewControl.Instance.filterResult(searchView, "Films");
            }
            
            if(series.Checked)
            {
                ViewControl.Instance.filterResult(searchView, "Series");
            }
            
        }

        /// <summary>
        /// Извежда всички филми или сериали
        /// </summary>
        private void all_Click(object sender, EventArgs e)
        {
            searchView.Items.Clear();
            if (films.Checked)
            {
                ViewControl.Instance.fillViewControl(searchView, "films");
            }

            if (series.Checked)
            {
                ViewControl.Instance.fillViewControl(searchView, "series");
            }
        }




        //Genres, Services, Types Controls
        /// <summary>
        /// Създава формата за добавяне на жанрове, услуги и типове
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addData(object sender, EventArgs e)
        {
            Button b = sender as Button;
            switch (b.Name)
            {
                case "genreButton":
                    {
                        AddDataMenu menu = new AddDataMenu("Genres", row, true);
                        menu.Show();
                        break;
                    }
                case "serviceButton":
                    {
                        AddDataMenu menu = new AddDataMenu("Services", row, true);
                        menu.Show();
                        break;
                    }
                case "typeButton":
                    {
                        AddDataMenu menu = new AddDataMenu("Types", row, true);
                        menu.Show();
                        break;
                    }
            }
        }

        /// <summary>
        /// Създава формата за промяна на жанрове, услуги и типове
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeData(object sender, EventArgs e)
        {
            if(allGenreView.SelectedItems.Count != 0)
            {
                AddDataMenu menu = new AddDataMenu("Genres", genreRow, false);
                genreRow = "";
                menu.Show();
                allGenreView.SelectedItems.Clear();
            }
            else if(allServicesView.SelectedItems.Count != 0)
            {
                AddDataMenu menu = new AddDataMenu("Services", servicesRow, false);
                servicesRow = "";
                menu.Show();
                allServicesView.SelectedItems.Clear();
            }
            else if (allTypesView.SelectedItems.Count != 0)
            {
                AddDataMenu menu = new AddDataMenu("Types", typesRow, false);
                typesRow = "";
                menu.Show();
                allTypesView.SelectedItems.Clear();

            }
        }
        private string genreRow = "";
        private string servicesRow = "";
        private string typesRow = "";

        /// <summary>
        /// Създава контекстното меню за промяна на жанр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genreView(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
                UpdateOptions.Show(startPoint);
                if (allGenreView.SelectedItems[0] != null)
                {
                    ListViewItem itemRow = allGenreView.SelectedItems[0];
                    for (int i = 0; i < itemRow.SubItems.Count; i++)
                    {
                        genreRow += itemRow.SubItems[i].Text + ",";
                        
                    }
                    
                }
            }
            allGenreView.SelectedItems.Clear();

        }

        /// <summary>
        /// Създава контекстното меню за промяна на услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genreServices(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
                UpdateOptions.Show(startPoint);
                if (allServicesView.SelectedItems[0] != null)
                {
                    ListViewItem itemRow = allServicesView.SelectedItems[0];
                    for (int i = 0; i < itemRow.SubItems.Count; i++)
                    {
                        servicesRow += itemRow.SubItems[i].Text + ",";
                    }
                    
                }
            }
            allServicesView.SelectedItems.Clear();

        }

        /// <summary>
        /// Създава контекстното меню за промяна на типове
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genreTypes(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
                UpdateOptions.Show(startPoint);
                if (allTypesView.SelectedItems[0] != null)
                {
                    ListViewItem itemRow = allTypesView.SelectedItems[0];
                    for (int i = 0; i < itemRow.SubItems.Count; i++)
                    {
                        typesRow += itemRow.SubItems[i].Text + ",";
                    }
                    
                }
            }
            allTypesView.SelectedItems.Clear();
        }

        /// <summary>
        /// Презарежда ListView контролите за жанрове, услуги и типове
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            allGenreView.Items.Clear();
            allServicesView.Items.Clear();
            allTypesView.Items.Clear();

            ViewControl.Instance.fillViewControl(allGenreView, "genres");
            ViewControl.Instance.fillViewControl(allServicesView, "services");
            ViewControl.Instance.fillViewControl(allTypesView, "types");
        }


        //Функции, с който се реализират движението на главния прозорец при натискане на бутона на мишката 
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = new Point(e.X, e.Y);
            }
        }
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown.IsEmpty)
                return;
            this.Location = new Point(this.Location.X + (e.X - mouseDown.X), this.Location.Y + (e.Y - mouseDown.Y));
        }
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = Point.Empty;
        }

        
        //Employees And Positions Controls 
        private string empData = "";

        /// <summary>
        /// Създава формата за добавяне на служител
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeMenu emp = new AddEmployeeMenu(empData, true, ViewControl.Instance.getPositionsArray(), ViewControl.Instance.getCitiesArray());
            emp.Show();

        }
        private string posData = "";

        /// <summary>
        /// Създава формата за добавяне на позиция
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPosButton_Click(object sender, EventArgs e)
        {
            AddPositionMenu pos = new AddPositionMenu(posData, true);
            pos.Show();
        }

        /// <summary>
        /// Презарежда на ListView контрола за служители
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reloadEmpBut_Click(object sender, EventArgs e)
        {
            allEmployeesView.Items.Clear();
            allPositionsView.Items.Clear();

            ViewControl.Instance.fillViewControl(allEmployeesView, "employees");
            ViewControl.Instance.fillViewControl(allPositionsView, "positions");
        }

        /// <summary>
        /// Създава контекстното мену за промяна на служител
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void empClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
                employeesStrip.Show(startPoint);
                if (allEmployeesView.SelectedItems[0] != null)
                {
                    ListViewItem itemRow = allEmployeesView.SelectedItems[0];
                    for (int i = 0; i < itemRow.SubItems.Count; i++)
                    {
                        empData += itemRow.SubItems[i].Text + ",";

                    }
                    
                }
            }
            allEmployeesView.SelectedItems.Clear();
        }

        /// <summary>
        /// Създава контекстното меню за промяна на длъжност
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void posClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
                employeesStrip.Show(startPoint);
                if (allPositionsView.SelectedItems[0] != null)
                {
                    ListViewItem itemRow = allPositionsView.SelectedItems[0];
                    for (int i = 0; i < itemRow.SubItems.Count; i++)
                    {
                        posData += itemRow.SubItems[i].Text + ",";

                    }
                   
                }
            }
            allPositionsView.SelectedItems.Clear();
        }

        /// <summary>
        /// Създава формата за промяна на служител или позиция и зареждаме съответната форма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeEmpPosClick(object sender, EventArgs e)
        {
            if(allEmployeesView.SelectedItems.Count != 0)
            {
                AddEmployeeMenu emp = new AddEmployeeMenu(empData, false, ViewControl.Instance.getPositionsArray(), ViewControl.Instance.getCitiesArray());
                emp.Show();
                empData = "";
                allEmployeesView.SelectedItems.Clear();
            }
            else if(allPositionsView.SelectedItems.Count != 0)
            {
                AddPositionMenu pos = new AddPositionMenu(posData, false);
                pos.Show();
                posData = "";
                allPositionsView.SelectedItems.Clear();
            }
        }

        //Cities Controls
        private string city = "";

        /// <summary>
        /// Създава формата за добавяне на град
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCityBut_Click(object sender, EventArgs e)
        {
            AddCitiesMenu menu = new AddCitiesMenu(true, city);
            menu.Show();
            city = "";
            allOfficesView.Items.Clear();
            ViewControl.Instance.fillViewControl(allOfficesView, "cities");
        }

        /// <summary>
        /// Отваряме контекстното меню за промяна на град
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void allOfficesView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Point startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
                insertCitiesStrip.Show(startPoint);
                if (allOfficesView.SelectedItems[0] != null)
                {
                    ListViewItem itemRow = allOfficesView.SelectedItems[0];
                    for (int i = 0; i < itemRow.SubItems.Count; i++)
                    {
                        city += itemRow.SubItems[i].Text + ",";

                    }
                    
                }
            }
            allOfficesView.SelectedItems.Clear();
        }

        /// <summary>
        /// Създава формата за промяна на град
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeCity_Click(object sender, EventArgs e)
        {
            AddCitiesMenu menu = new AddCitiesMenu(false, city);
            menu.Show();
            city = "";
            allOfficesView.Items.Clear();
            ViewControl.Instance.fillViewControl(allOfficesView, "cities");
        }
    }
}
