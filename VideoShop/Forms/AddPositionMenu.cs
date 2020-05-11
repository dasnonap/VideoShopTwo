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
    public partial class AddPositionMenu : Form
    {
        private string data = "";
        private bool isNew;
        private int posID;

        private Point mouseDown = Point.Empty;
        public AddPositionMenu(string data, bool isNew)
        {
            this.data = data;
            this.isNew = isNew;
            InitializeComponent();
        }

        /// <summary>
        /// Зареждане на началната форма при отваряне на формата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPositionMenu_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(161, 123, 89);
            Border.BackColor = Color.Black;
            if (!isNew)
            {
                string[] array = data.Split(',');
                dataBox.Text = array[0];
                posID = ViewControl.Instance.getID(array[0], "Positions");
            }

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
        /// Обработва функцията при натискане на бутона ако всичко е валидно спрямо това дали 
        /// е нов или стар запис
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitChanges_Click(object sender, EventArgs e)
        {
            if(dataBox.Text != "")
            {
                if (!isNew)
                {
                    Positions s = new Positions(posID, dataBox.Text);
                    ViewControl.Instance.chandeData(s, "Positions");
                }
                else
                {
                    Positions s = new Positions(dataBox.Text);
                    ViewControl.Instance.setData(s, "Positions");
                }
                Close();
            }
            else if(dataBox.Text == "")
            {
                MessageBox.Show("Въведете длъжност");
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
    }
}
