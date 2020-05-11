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
    public partial class AddEmployeeMenu : Form
    {
        private bool isNew;
        private string data;
        private int empID;
        private List<Object> positions;
        private List<Object> cities;
        private Point mouseDown = Point.Empty;

        public AddEmployeeMenu(string data, bool isNew, List<Object> pos, List<Object> cities)
        {
            this.data = data;
            this.isNew = isNew;
            this.positions = pos;
            this.cities = cities;
            InitializeComponent();
        }
        /// <summary>
        /// Зареждане на формата при първоначалното зареждане на формата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmployeeMenu_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(161, 123, 89);
            Border.BackColor = Color.Black;
            loadPositions();
            loadCities();

            if (!isNew)
            {
                string[] array = data.Split(',');
                firstNameBox.Text = array[0];
                lastNameBox.Text = array[1];
                salaryBox.Text = array[2];
                phoneBox.Text = array[3];
                positionBox.SelectedItem = array[4];
                citiesBox.SelectedItem = array[5];
                empID = ViewControl.Instance.getID(array[3], "Employees");
            }
        }

        /// <summary>
        /// Зареждане на комбо бокса с позиции
        /// </summary>
        private void loadPositions()
        {
            foreach(Positions p in positions)
            {
                positionBox.Items.Add(p.getPosName());
            }
        }
        /// <summary>
        /// Зареждане на комбо бокса с градовете
        /// </summary>
        private void loadCities()
        {
            foreach(Cities c in cities)
            {
                citiesBox.Items.Add(c.getCity());
            }
        }

        private void submitChanges_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            if(validate() == true)
            {
                emp.setFirstName(firstNameBox.Text);
                emp.setLastName(lastNameBox.Text);
                emp.setSalary(Int32.Parse(salaryBox.Text));
                emp.setPhone(phoneBox.Text);
                emp.setStringPos(positionBox.SelectedItem.ToString());
                emp.setStringCity(citiesBox.SelectedItem.ToString());
                if (!isNew)
                {
                    emp.setID(empID);
                    ViewControl.Instance.chandeData(emp, "Employees");
                }
                else
                {
                    ViewControl.Instance.setData(emp, "Employees");
                }
                Close();
            }
            else
            {
                MessageBox.Show("Уверете се че всички полета са попълнени");
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
        /// Обработва натискането на бутона Отказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработва за натискане при въвеждане на символи в полето
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        /// <summary>
        /// Премахва символите, които са въведени символи в полето
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Проверява валидацията на полетата
        /// </summary>
        /// <returns>Връща true ако всички полета са валидни и false ако са невалидни</returns>
        private bool validate()
        {
            if(firstNameBox.Text == "" || lastNameBox.Text == "" || salaryBox.Text == "" || phoneBox.Text == "" || phoneBox.Text.Length < 10 || positionBox.SelectedItem == null || citiesBox.SelectedItem == null )
            {
                return false;
            }
            return true;
        }
    }
}
