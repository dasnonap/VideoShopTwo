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
    public partial class FilterForm : Form
    {
        private Point mouseDown = Point.Empty;

        public FilterForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Обработването на зареждането на формата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(161, 123, 89); 
            Border.BackColor = Color.Black;

            foreach (Genres g in ViewControl.Instance.getGenresArray())
            {
                genreBox.Items.Add(g.getGenreName());
            }
        }

        //-Контроли които обработват движението на формата по екрана
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
        /// Обработва натискането на бутона Приложи, тук няма разграничения за попълнените 
        /// полета, защото ще върнат отговор по даден филтър
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendButton_Click(object sender, EventArgs e)
        {
            Films f = new Films();
            f.setName(nameBox.Text);
            f.setLead(leadName.Text);
            
            f.setStringGenre(genreBox.Text);

            if(yearBox.Text != "")
            {
                f.setYear(Int32.Parse(yearBox.Text));
            }
            ViewControl.Instance.setFilterItem(f);

            Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Тук ако въведеният символ е различно от число то този симвил не се записва
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
