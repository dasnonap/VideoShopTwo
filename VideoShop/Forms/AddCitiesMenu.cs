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
    public partial class AddCitiesMenu : Form
    {
        private bool isNew;
        private string row;
        private int cityID = 0;
        private Point mouseDown = Point.Empty;
        public AddCitiesMenu(bool isNew, string row)
        {
            this.isNew = isNew;
            this.row = row;
            InitializeComponent();
        }

        /// <summary>
        /// Функцията обрабботва какво да се зарежда при отваряне на формата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCitiesMenu_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(161, 123, 89);
            Border.BackColor = Color.Black;
            if (!isNew)
            {
                string[] array = row.Split(',');
                cityNameBox.Text = array[0];
                cityID = ViewControl.Instance.getID(array[0], "Cities");
            }
        }

        //-Тези функции обработват движението на формата по екрана
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
        /// Обработва при натискане на submit бутона и ако всички данни са валидни то се проверява дали продуктът е нов или вече съществува 
        /// и спрямо тази проверка се извършва дадената процедура
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitChanges_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                MessageBox.Show("Моля попълнете всички полета!");
            }
            else
            {
                Cities c = new Cities();
                c.setCity(cityNameBox.Text);
                if (!isNew)
                {
                    c.setID(cityID);
                    ViewControl.Instance.chandeData(c, "Cities");
                }
                else
                {
                    ViewControl.Instance.setData(c, "Cities");
                }
                Close();
            }
        }

        /// <summary>
        /// Функцията обработва при натискане на бутона Отказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Функцията проверява валидността на полетата
        /// </summary>
        /// <returns>Връща true ако всичко е наред</returns>
        private bool validate()
        {
            if (cityNameBox.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
