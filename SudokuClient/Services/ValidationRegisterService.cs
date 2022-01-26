using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SudokuClient.Services
{
    public class ValidationRegisterService : IValidationService
    {
        public bool IsNotEmpty(User user)
        {
            if (user.Name == null || user.Name == "" || user.Password == null || user.Password == "")
            {
                MessageBox.Show(Application.Current.MainWindow, "One of the credentials is empty, please try again", "Login Failure", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel);
                return false;
            }
            return true;
        }

        public bool IsValidated(User user)
        {
            if (VerifyName(user))
            {
                if (VerifyPasswords(user))
                {
                    Utils.Utils.SendHttpGetRequest("http://localhost:5000/User/adduser?name=" + user.Name.ToString() + "&" + "password=" + user.Password.ToString());
                    MessageBox.Show(Application.Current.MainWindow, "Thanks for Register", "Register Succeed", MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show(Application.Current.MainWindow, "The passwords are not matching or empty, please try again", "Register Failure", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(Application.Current.MainWindow, "The name is already exist or is empty, please try again", "Register Failure", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel);
                return false;
            }
        }
        private bool VerifyPasswords(User user)
        {
            return user.Password.Equals(user.VerificationPassword);
        }


        private bool VerifyName(User user)
        {
            string nameCheck = Utils.Utils.SendHttpGetRequest("http://localhost:5000/User/verifyuniqueusername?name=" + user.Name.ToString() + "&" + "password=" + user.Password.ToString());
            if (nameCheck.Equals("true"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
