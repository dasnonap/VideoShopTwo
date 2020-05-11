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
       private MainMenu m = new MainMenu();

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

        /// <summary>
        /// Обработва натискането на бутона логин и проверява данните и автентикацията на 
        /// потребителя, който се опитва да влезе в системата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            Users loggin = new Users();
            if (!validateLogin())
            {
                MessageBox.Show("Попълнете всички полета!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loggin.setUserName(Pepper.Instance.PepperOnTheDish(userNameBox.Text));
                loggin.setPassword(Pepper.Instance.PepperOnTheDish(passwordBox.Text));

                if (Pepper.Instance.CheckForAdmin(loggin.getUserName(), passwordBox.Text))
                {
                    GlobalVariables.Instance.setAdminLogged(true);
                    this.Visible = false;

                    m.Visible = true;
                }
                else if (ViewControl.Instance.checkUserCredentials(loggin))
                {
                    this.Visible = false;

                    m.Visible = true;
                }
                else
                {
                    MessageBox.Show("Грешна парола или потребителско име.");
                }
            }
            
            
        }

        /// <summary>
        /// Обработва натискането на бутона регистрация, след това се вкарва в базата данни
        /// ако не съществува човек с това име
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendRegButton_Click(object sender, EventArgs e)
        {
            Users newUser = new Users();
            if (!validateReg())
            {
                MessageBox.Show("Попълнете всички полета!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (passwordRegOne.Text == passwordRegTwo.Text)
                {
                    newUser.setUserName(Pepper.Instance.PepperOnTheDish(usernameRegBox.Text));
                    newUser.setPassword(Pepper.Instance.PepperOnTheDish(passwordRegOne.Text));
                    newUser.setEmail(emailBox.Text);
                    newUser.setCountry(1);

                    ViewControl.Instance.setData(newUser, "Users");
                    this.Visible = false;

                    m.Visible = true;
                }
                else
                {
                    MessageBox.Show("Има разминавания в паролите");
                }
            }
                     
        }

        /// <summary>
        /// Валидира логин кутиите
        /// </summary>
        /// <returns>Ако всички полета са попълнени се проверява автентикация на 
        /// потребителя</returns>
        private bool validateLogin()
        {
            if(userNameBox.Text == "" || passwordBox.Text == "")
            {
                return false;
            }
            return true;
        }
        /// <summary>
        ///  Валидира регистрационните кутии
        /// </summary>
        /// <returns>Ако всички полета са попълнени се проверява автентикация на 
        /// потребителя</returns>
        private bool validateReg()
        {
            if(usernameRegBox.Text == "" || passwordRegOne.Text == "" ||  passwordRegTwo.Text == "" || emailBox.Text == "" )
            {
                return false;
            }
            return true;
        }
    }
}
