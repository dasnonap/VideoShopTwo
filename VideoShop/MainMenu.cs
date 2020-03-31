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

namespace VideoShop
{
    public partial class MainMenu : Form
    {
        private GenresBuffer genres = new GenresBuffer();


        private Dictionary<RadioButton, TabPage> userRadioPanelsPairs = new Dictionary<RadioButton, TabPage>();
        private Dictionary<RadioButton, TabPage> adminRadioPanelsPairs = new Dictionary<RadioButton, TabPage>();
        public MainMenu()
        {
            InitializeComponent();
        }

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

        private void showBegginingRadio_CheckedChanged(object sender, EventArgs e)
        {
            getActiveOption();
        }

        private void showLibRadio_CheckedChanged(object sender, EventArgs e)
        {
            filmLibraryView.BackColor = Color.FromArgb(255, 192, 57);
            getActiveOption();
        }

        private void showCatRadio_CheckedChanged(object sender, EventArgs e)
        {
            getActiveOption();
        }
        private void showSeriesRadio_CheckedChanged(object sender, EventArgs e)
        {
            seriesLibraryView.BackColor = Color.FromArgb(255, 192, 57);
            getActiveOption();
        }
        private void showOptionRadio_CheckedChanged(object sender, EventArgs e)
        {
            getActiveOption();
        }

        private void addOfficeRadio_CheckedChanged(object sender, EventArgs e)
        {

            allOfficesView.BackColor = Color.FromArgb(255, 192, 57);

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
            getActiveOption();
        }

        private void addGenresRadio_CheckedChanged(object sender, EventArgs e)
        {
            getActiveOption();
        }
        private void usersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            getActiveOption();
        }


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

            /*foreach (Cities c in buffer.returnRecords())
            {
                if(c.getCity() == citiesRecords.Text.ToString())
                {
                    buffer.changeRow( new Cities( c.getId(), changeName.Text.ToString() ) );
                }
            }
            TO DO
            citiesRecords.Items.Clear();
            changeName.Clear();
            citiesRecords.Text = "";

            foreach (Cities c in buffer.returnRecords())
            {
                citiesRecords.Items.Add(c.getCity());
            }*/
        }
        private void adminLoad()
        {
            genres.initializeGenresArray();

            ViewControl.Instance.fillViewControl(allFilmsView, "films");
            ViewControl.Instance.fillViewControl(allOfficesView, "cities");
        }

        private void userLoad()
        {
            userNameLabel.Text = ViewControl.Instance.getLoggedEmail();
            welcomeLabel.Text = "Добре дошли отново " + userNameLabel.Text;

            ViewControl.Instance.fillViewControl(filmLibraryView, "FilmsLibrary");
            ViewControl.Instance.fillViewControl(seriesLibraryView, "SeriesLibrary");

            films.BackColor = Color.FromArgb(255, 192, 57);
            series.BackColor = Color.FromArgb(255, 192, 57);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string selCombo = genresCombo.SelectedItem.ToString();
            if (String.IsNullOrWhiteSpace(selCombo))
            {
                MessageBox.Show("Изберете опция ");
            }
            ViewControl.Instance.searchResult(allFilmsView, "films", selCombo);
            
        }
        public static string row = null;
        private void allFilmsView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                
                Point startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);

                rightClickStrip.Show(startPoint);

                
                ListViewItem itemRow = allFilmsView.SelectedItems[0];

                for( int i = 0; i < itemRow.SubItems.Count; i++)
                {
                    row +=  itemRow.SubItems[i].Text + "," ;
                }                
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            OptionsMenuFilms options = new OptionsMenuFilms(row, false, genres.returnRecords());
            row = null;
            options.Show();
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            OptionsMenuFilms options = new OptionsMenuFilms(row, true, genres.returnRecords());
            options.Show();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            allFilmsView.Items.Clear();
            ViewControl.Instance.fillViewControl(allFilmsView, "films");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Films f = new Films();
            string[] arr = row.Split(',');
            f.setName(arr[2]);
            ViewControl.Instance.deleteData(f, "Films");
            
        }
    }
}
