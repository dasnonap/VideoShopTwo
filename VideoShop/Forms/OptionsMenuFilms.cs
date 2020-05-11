using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoShop.Classes;

using VideoShop.BufferClasses;

namespace VideoShop
{
    public partial class OptionsMenuFilms : Form
    {
        private string filmData;
        private bool IsNew;
        private int chosenFilmID;
        private int chosenSeriesID;
        private bool isFilm;

        private List<Object> genres = new List<Object>();
        private Point mouseDown = Point.Empty;
        public OptionsMenuFilms(string filmData, bool IsNew, List<Object> genres, bool isFilm)
        {
            this.filmData = filmData;
            this.IsNew = IsNew;
            this.genres = genres;
            this.isFilm = isFilm;

            InitializeComponent();
        }

        /// <summary>
        /// Обработва началното зареждане на формата в зависимост от това дали записът е нов или 
        /// вече съществувва
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionsMenuFilms_Load(object sender, EventArgs e)
        {

            BackColor = Color.FromArgb(161, 123, 89);
            Border.BackColor = Color.Black;

            foreach (Genres i in genres)
            {
                genreBox.Items.Add(i.getGenreName());
            }

            if (!IsNew)
            {
                string[] array = filmData.Split(',');
                producerBox.Text = array[0];
                leadBox.Text = array[1];
                nameBox.Text = array[2];
                genreBox.Text = array[3];
                yearBox.Text = array[4];

                if (isFilm == true)
                {
                    chosenFilmID = ViewControl.Instance.getID(array[2], "Films");

                }
                else
                {
                    seasonBox.Text = array[5];
                    chosenSeriesID = ViewControl.Instance.getID(array[2], "Series");

                    seasonLabel.Visible = true;
                    seasonBox.Visible = true;
                }
            }
            else
            {
                if (isFilm != true)
                {
                    seasonLabel.Visible = true;
                    seasonBox.Visible = true;
                }
            }


        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-Обработват движението на формата по екрана
        private void Border_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = new Point(e.X, e.Y);
            }
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown.IsEmpty)
                return;
            this.Location = new Point(this.Location.X + (e.X - mouseDown.X), this.Location.Y + (e.Y - mouseDown.Y));
        }

        private void Border_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = Point.Empty;
        }
        //-

        /// <summary>
        /// Обработва натискането на бутона Приложи ако всичко е валидно
        /// в зависимост от това дали записът е стар или нов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitChanges_Click(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                if (isFilm == true)
                {
                    Films f = new Films();
                    if (!validate())
                    {
                        MessageBox.Show("Уверете се че всички полета са попълнени");
                    }
                    else
                    {
                        f.setID(chosenFilmID);
                        f.setProd(producerBox.Text);
                        f.setLead(leadBox.Text);
                        f.setName(nameBox.Text);
                        f.setStringGenre(genreBox.SelectedItem.ToString());
                        f.setYear(Int32.Parse(yearBox.Text));
                        ViewControl.Instance.chandeData(f as Object, "Films");
                    }
                }
                else
                {
                    Series s = new Series();
                    if (!validate())
                    {
                        MessageBox.Show("Уверете се че всички полета са попълнени");
                    }
                    else
                    {
                        s.setSeriesID(chosenSeriesID);
                        s.setProd(producerBox.Text);
                        s.setLead(leadBox.Text);
                        s.setName(nameBox.Text);
                        s.setStringGenre(genreBox.SelectedItem.ToString());
                        s.setYear(Int32.Parse(yearBox.Text));
                        s.setSeason(Int32.Parse(seasonBox.Text));
                        ViewControl.Instance.chandeData(s as Object, "Series");
                    }
                    
                }

            }
            else
            {
                if (!validate())
                {
                    MessageBox.Show("Уверете се че всички полета са попълнени");

                }
                else
                {
                    if (isFilm == true)
                    {
                        ViewControl.Instance.setData(getInfo(), "Films");
                    }
                    else
                    {
                        ViewControl.Instance.setData(getInfo(), "Series");
                    }
                    this.Close();
                }                  
            }
        }

        /// <summary>
        /// Създава сериал или филм
        /// </summary>
        /// <returns>Създаденият обект от попълнените полета</returns>
        private Object getInfo()
        {
           
                if (isFilm != true)
                {
                    Series s = new Series(
                        producerBox.Text.ToString(),
                        leadBox.Text.ToString(),
                        nameBox.Text.ToString(),
                        Int32.Parse(seasonBox.Text),
                        0,
                        Int32.Parse(yearBox.Text));
                    s.setStringGenre(genreBox.SelectedItem.ToString());
                    return s;
               }

            Films f = new Films(
                    producerBox.Text.ToString(),
                    leadBox.Text.ToString(),
                    nameBox.Text.ToString(),
                    0,
                    Int32.Parse(yearBox.Text)
                    );
            f.setStringGenre(genreBox.SelectedItem.ToString());
            return f;
           

        }

        /// <summary>
        /// Не позволява в полето за годините да се въвежда символ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Не позволява в полето за сезонът на сериала да се въвежда символ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seasonBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Валидирането на всички полета
        /// </summary>
        /// <returns>Връща true ако всички полета са валидни и false ако поне едно не изпълнява изискванията</returns>
        private bool validate()
        {
            if(producerBox.Text == "" || nameBox.Text == "" || leadBox.Text == "" || genreBox.SelectedItem == null || yearBox.Text == "" || yearBox.Text == "0" )
            {
                return false;
               
            }
            if (!isFilm )
            {
                if (seasonBox.Text == "" || seasonBox.Text == "0")
                {
                    return false;
                }
            }
            return true;
        }
    }

}
