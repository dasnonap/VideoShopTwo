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
using VideoShop.Classes;

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

            
            Connection cn = new Connection();
            if (cn.InitializeConnections())
            {
                Cities city = new Cities();
             
                city.setCity(userNameBox.Text.ToString());

                if( cn.InsertIntoTables( city ) )
                {
                    this.Visible = false;
                    MainMenu m = new MainMenu();
                    m.Visible = true;

                }       

                
            }
            else
            {
                loginPanel.Visible = false;
            }
            cn.CloseConnection();
            
        }

        private void sendRegButton_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            if (!cn.InitializeConnections())
            {
                loginPanel.Visible = true;
            }
            //input = raw data
            //yes = hashed data z
            string input = usernameRegBox.Text;
            string yes;
            using (SHA256 hash = SHA256.Create())
            {
                byte[] usernameByteSource = Encoding.UTF8.GetBytes(input);
                byte[] hashUsername = hash.ComputeHash(usernameByteSource);
                yes = BitConverter.ToString(hashUsername).Replace("-", String.Empty);
            }
            emailBox.Text = yes;

            
        }
    }
}
