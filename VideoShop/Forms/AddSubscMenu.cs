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
    public partial class AddSubscMenu : Form
    {
        private int userID;
        private List<Object> services;
        private bool isNew;
        private string data;
        private Point mouseDown = Point.Empty;
        public AddSubscMenu(int userID, List<Object> services, bool isNew, string data)
        {
            this.userID = userID;
            this.services = services;
            this.isNew = isNew;
            this.data = data;
            InitializeComponent();
        }
        /// <summary>
        /// Обработва зареждането на формата 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSubscMenu_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(161, 123, 89);
            Border.BackColor = Color.Black;
            loadServices();
            if (!isNew)
            {
                string[] array = data.Split(',');
                serviceBox.SelectedItem = array[0];

            }
        }

        //-Обработва движението на прозореца на екрана
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
        /// Зарежда услугите в комбо бокса
        /// </summary>
        private void loadServices()
        {
            foreach(ServicesNames s in services)
            {
                serviceBox.Items.Add(s.getServName());
            }
        }

        /// <summary>
        /// При промяна на стойността в комбо бокса се изписва цената в label-a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceBox_TextChanged(object sender, EventArgs e)
        {
            foreach(ServicesNames s in services)
            {
                if(s.getServName() == serviceBox.SelectedItem.ToString())
                {
                    priceLabel.Text = s.getServPrice().ToString();
                }
            }
        }

        /// <summary>
        /// Обработва натискането на бутона Отказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработва натискането на бутона Приложи
        /// ако полетата са валидни се извършват функциите в зависимост това дали 
        /// елемента е стар или нов
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
                if (!isNew)
                {

                }
                else
                {
                    Subscriptions s = new Subscriptions();
                    s.setStartDate(startTimeBox.Value);
                    s.setServID(getID());
                    s.setUserID(userID);
                    s.setEndDate(startTimeBox.Value.AddMonths(1));
                    ViewControl.Instance.setData(s, "Subscriptions");
                }
            }
            
        }

        /// <summary>
        /// Взима id-to на дадената услуга
        /// </summary>
        /// <returns>Връща id-to на услугата</returns>
        private int getID()
        {
            foreach (ServicesNames s in services)
            {
                if (s.getServName() == serviceBox.SelectedItem.ToString())
                {
                    return s.getServID();
                }
            }
            return 0;
        }

        /// <summary>
        /// Валидира полето за избор на услуга
        /// </summary>
        /// <returns>Връща true ако валидацията е успешна</returns>
        private bool validate()
        {
            if(serviceBox.SelectedItem == null)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Валидира полето за дата и не позволява началната дата да е преди днешната дата        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startTimeBox_ValueChanged(object sender, EventArgs e)
        {
            if(DateTime.Compare(DateTime.Now, startTimeBox.Value) > 0)
            {
                MessageBox.Show("Началната дата не може да е преди днешната дата");
            }
        }
    }
}
