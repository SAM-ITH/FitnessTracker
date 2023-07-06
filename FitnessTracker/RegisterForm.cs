using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessTracker.Services;
using FitnessTracker.Models;

namespace FitnessTracker
{
    public partial class RegisterForm : Form
    {
        private UserService _userService;

        public RegisterForm()
        {
            InitializeComponent();
            _userService = new UserService();
            InitializePasswordChars();
        }

        private void InitializePasswordChars()
        {
            passwordTxt.PasswordChar = (char)0x2022;
            confirmPasswordTxt.PasswordChar = (char)0x2022;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && AdditionalValidations())
            {
                // user
                User newUser = new User
                {
                    FirstName = fnameTxt.Text,
                    LastName = lnameTxt.Text,
                    Age = int.Parse(ageTxt.Text),
                    Height = int.Parse(heightTxt.Text),
                    Weight = (float)double.Parse(weightTxt.Text)
                };

                UserProfile newUserProfile = new UserProfile
                {
                    User = newUser,
                    UserName = userNameTxt.Text,
                    Password = passwordTxt.Text
                };

                _userService.CreateUser(newUserProfile);
                var dialogResult = MessageBox.Show("User created successfully.", "Success!");
                if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
                {
                    var Home = new home();
                    Hide();
                    Home.Activate();
                    Home.ShowDialog();
                }
            }
        }

        #region Field Validations

        private bool AdditionalValidations()
        {
            if (IsUsernameValid())
            {
                return ValidatePasswords();
            }
            var message = $"The username {userNameTxt.Text} already exists.";
            MessageBox.Show(message, "Error");
            return false;
        }

        private bool ValidatePasswords()
        {
            var password = passwordTxt.Text.Trim();
            var confirmPassword = passwordTxt.Text.Trim();

            if (password.Length < ApplicationConstants.PasswordCharMinLength ||
                confirmPassword.Length < ApplicationConstants.PasswordCharMinLength)
            {
                var length = ApplicationConstants.PasswordCharMinLength;
                registerErrorMessage.SetError(passwordTxt, $"Password must contain atleast {length} characters.");
                return false;
            }

            if (password != confirmPassword)
            {
                registerErrorMessage.SetError(passwordTxt, "Passwords do not match.");
                return false;
            }

            return true;
        }

        private bool IsUsernameValid()
        {
            string username = userNameTxt.Text.Trim();
            return !(_userService.IsUsernameExist(username));
        }

        private void txtField_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                e.Cancel = true;
                txtBox.Focus();
                registerErrorMessage.SetError(txtBox, "Value must not be empty.");
            }
            else
            {
                e.Cancel = false;
                registerErrorMessage.SetError(txtBox, string.Empty);
            }
        }

        private void txtNumber_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                e.Cancel = true;
                txtBox.Focus();
                registerErrorMessage.SetError(txtBox, "Value must not be empty.");
            }
            else if (!int.TryParse(txtBox.Text, out var value))
            {
                e.Cancel = true;
                txtBox.Focus();
                registerErrorMessage.SetError(txtBox, "Value must be a number.");
            }
            else if (value < 0)
            {
                e.Cancel = true;
                txtBox.Focus();
                registerErrorMessage.SetError(txtBox, "Value must be a positive number.");
            }
            else
            {
                e.Cancel = false;
                registerErrorMessage.SetError(txtBox, string.Empty);
            }
        }

        private void txtDouble_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                e.Cancel = true;
                txtBox.Focus();
                registerErrorMessage.SetError(txtBox, "Value must not be empty.");
            }
            else if (!double.TryParse(txtBox.Text, out var value))
            {
                e.Cancel = true;
                txtBox.Focus();
                registerErrorMessage.SetError(txtBox, "Value must be a number.");
            }
            else if (value < 0)
            {
                e.Cancel = true;
                txtBox.Focus();
                registerErrorMessage.SetError(txtBox, "Value must be a positive number.");
            }
            else
            {
                e.Cancel = false;
                registerErrorMessage.SetError(txtBox, string.Empty);
            }
        }
        #endregion
    }
}
