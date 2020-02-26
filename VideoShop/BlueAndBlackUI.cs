using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(220, 93, 1);
            panel1.BackColor = Color.FromArgb(255, 192, 57);
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
            this.Visible = false;
            MainMenu m = new MainMenu();
            m.Visible = true;
        }
    }
}
