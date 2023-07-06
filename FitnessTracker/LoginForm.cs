using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessTracker.Context;

namespace FitnessTracker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs estop)
        {
            // check the username and password validation
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string userName = usernameTxt.Text.Trim();
                string password = passwordTxt.Text.Trim();
                if (userDetails.Login(userName, password)) 
                {
                    Hide();
                    home Home = new home();
                    Home.Activate();
                    Home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("password or username you entered is incorrect", "Sorry");
                }
            }
        }

        // validate the username text field 
        private void usernameTxt_validate(object sender, CancelEventArgs estop) 
        {
            if (string.IsNullOrWhiteSpace(usernameTxt.Text))
            {
                estop.Cancel = true;
                usernameTxt.Focus();
                loginErrorMessage.SetError(usernameTxt, "username can not be empty");
            }
            else 
            {
                estop.Cancel = false;
                loginErrorMessage.SetError(usernameTxt, string.Empty);
            }
        }

        private void password_validate(object seder, CancelEventArgs estop)
        {
            if (string.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                estop.Cancel = true;
                passwordTxt.Focus();
                loginErrorMessage.SetError(passwordTxt, "password can not be emplty");
            }
            else 
            {
                estop.Cancel = false;
                loginErrorMessage.SetError(passwordTxt, string.Empty);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            Hide();
            register.Activate();
            register.ShowDialog();
        }
    }
}
