using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoShop.BufferClasses;
using VideoShop.Classes;
using VideoShop.TableClasses;

namespace VideoShop
{
    public partial class Login : Form
    {
        private Pepper p = new Pepper();
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(220, 93, 1);
            panel1.BackColor = Color.FromArgb(255, 192, 57);

            
            /*TypesTable table = new TypesTable();
            List<Types> list = new List<Types>();
            table.Select(list);*/

            panel2.BackColor = Color.FromArgb(255, 192, 57);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            regPanel.Visible = true;             
        }

        private void returnToLogin_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            regPanel.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            //to do tva se pravi v buferniq class s updeitvaneto na dannite
            string inputName = userNameBox.Text;
            string inputPass = passwordBox.Text;

            if (p.CheckForAdmin(inputPass))
            {
                GlobalVariables.Instance.setAdminLogged(true);
            }
            this.Visible = false;
            MainMenu m = new MainMenu();
            m.Visible = true;
        }

        private void sendRegButton_Click(object sender, EventArgs e)
        {
            //to do
            string input = usernameRegBox.Text;
            string yes;
            Cities c = new Cities();
            emailBox.Text = c.GetType().Name;


            //citiesTemplate.Insert("Cities", new Cities(emailBox.Text));
            
            
        }
    }
}
