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

namespace VideoShop.Forms
{
    public partial class AddDataMenu : Form
    {
        private string menuCaller = "";
        private string data;
        private bool isNew;
        private int genreID;
        private int typeID;
        private int serviceID;

        private Point mouseDown = Point.Empty;

        public AddDataMenu(string menuCaller, string data, bool isNew)
        {
            this.menuCaller = menuCaller;
            this.data = data;
            this.isNew = isNew;
            InitializeComponent();
        }

        /// <summary>
        /// Зареждане на формата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDataMenu_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(161, 123, 89);
            Border.BackColor = Color.Black;
            setLabel();

            if (!isNew)
            {                
                string[] array = data.Split(',');
                getID(array[0]);
                dataBox.Text = array[0];
                if(menuCaller == "Services")
                { 
                    priceBox.Text = array[1];
                }
            }
        }
        /// <summary>
        /// Задава текста на label-a спрямо това кой е създал формата
        /// </summary>
        private void setLabel()
        {
            switch (menuCaller)
            {
                case "Genres":
                    {
                        label1.Text = "Име на жанр : ";
                        break;
                    }
                case "Services":
                    {
                        label1.Text = "Име на услугата : ";
                        priceLabel.Visible = true;
                        priceBox.Visible = true;
                        break;
                    }
                case "Types":
                    {
                        label1.Text = "Име на типът : ";
                        break;
                    }
            }
        }
        /// <summary>
        /// Взима ID-to на елемента, които изпращаме съответно кой е създал формата
        /// </summary>
        /// <param name="name"></param>
        private void getID(string name)
        {
            
            switch (menuCaller)
            {
                case "Genres":
                    {
                        genreID = ViewControl.Instance.getID(name, "Genres");
                        break;
                    }
                case "Services":
                    {
                        serviceID = ViewControl.Instance.getID(name, "Services");
                        break;
                    }
                case "Types":
                    {
                        typeID = ViewControl.Instance.getID(name, "Types");
                        break;
                    }
            }
            
        }

        /// <summary>
        /// Промяна на запис спрямо това кой е извикал формата
        /// </summary>
        private void updateRow()
        {
            
            switch (menuCaller)
            {
                case "Genres":
                    {
                        Genres g = new Genres();
                        g.setGenreID(this.genreID);
                        g.setGenreName(dataBox.Text);
                        ViewControl.Instance.chandeData(g, "Genres");
                    break;
                    }
                case "Services":
                    {
                        ServicesNames s = new ServicesNames();
                        s.setServID(serviceID);
                        s.setServName(dataBox.Text);
                        s.setServPrice(float.Parse(priceBox.Text));
                        ViewControl.Instance.chandeData(s, "Services");
                    break;
                    }
                case "Types":
                    {
                        Types t = new Types();
                        t.setID(typeID);
                        t.setType(dataBox.Text);
                        ViewControl.Instance.chandeData(t, "Types");
                    break;
                    }
            }      
        }

        /// <summary>
        /// Създаване на нов запис спрямо това кой е извикал формата
        /// </summary>
        private void insertRow()
        {
            switch (menuCaller)
            {
                case "Genres":
                    {
                        Genres g = new Genres(dataBox.Text);
                        ViewControl.Instance.setData(g, "Genres");
                        break;
                    }
                case "Services":
                    {
                        ServicesNames s = new ServicesNames(dataBox.Text, float.Parse(String.Format("{0:F2}", priceBox.Text)));         
                       
                        ViewControl.Instance.setData(s, "ServicesNames");
                        break;
                    }
                case "Types":
                    {
                        Types t = new Types(dataBox.Text);                       
                        ViewControl.Instance.setData(t, "Types");
                        break;
                    }
            }
        }

        //-Функциите обработват движението на формата по екрана 
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
        /// Функцията обработва натиснатият бутон Приложи. В зависимост от валидността на полетата и в зависимост дали записът е нов или вече съществува 
        /// се обработва съответната функция
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitChanges_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                MessageBox.Show("Въведете всички полета");
            }
            else
            {
                if (!isNew)
                {
                    updateRow();
                }
                else
                {
                    insertRow();
                }
            }
            
            this.Close();
        }

        /// <summary>
        /// Проверява валидността на полетата
        /// </summary>
        /// <returns>Връща true ако всички полета са наред и false ако някое от полетата не изпълнява условията</returns>
        private bool validate()
        {
            if(dataBox.Text != "")
            {
                if(menuCaller != "Service")
                {
                    return true;
                }
                else
                {
                    if(priceBox.Text != "")
                    {
                        return true;
                    }
                }                              
            }
            return false;
        }

        /// <summary>
        /// Функцията обработва натиснатият бутон Отказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Функцията проверява натиснатият бутон дали е символ, и ако е го изтрива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
