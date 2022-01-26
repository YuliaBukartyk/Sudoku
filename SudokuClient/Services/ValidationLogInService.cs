using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SudokuClient.Services
{
    public class ValidationLogInService : IValidationService //using Facade design pattern 
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
            string success = Utils.Utils.SendHttpGetRequest("http://localhost:5000/User/verifyuser?name=" + user.Name.ToString() + "&" + "password=" + user.Password.ToString());

            if (success.Equals("true"))
            {
                return true;
            }
            else
            {
                MessageBox.Show(Application.Current.MainWindow, "One of the credentials is not correct, please try again", "Login Failure", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel);
                return false;
            }
        }
    }
}
