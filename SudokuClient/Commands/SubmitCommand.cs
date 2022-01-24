using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SudokuClient.Utils;
using System.Windows;
using SudokuClient.Services;

namespace SudokuClient.Commands
{
    public class SubmitCommand : CommandBase
    {
        private readonly User _user;
        private NavigationService _navigationService;
        public SubmitCommand(User newUser, NavigationService LogInViewNavigationService)
        {
            _user = newUser;
            _navigationService = LogInViewNavigationService;
        }

        public override void Execute(object parameter)
        {

            if (VerifyPassword())
            {
                if (VerifyName())
                {
                    Utils.Utils.SendHttpGetRequest("http://localhost:5000/User/adduser?name=" + _user.Name.ToString() + "&" + "password=" + _user.Password.ToString());
                    MessageBox.Show(Application.Current.MainWindow, "Thanks for Register", "Register Succeed", MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK);
                    _navigationService.Navigate();
                }
                else
                {
                    MessageBox.Show(Application.Current.MainWindow, "The name is already exist or is empty, please try again", "Register Failure", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel);
                }
            }
            else
            {
                MessageBox.Show(Application.Current.MainWindow, "The passwords are not matching or empty, please try again", "Register Failure", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel);
            }

        }


        private bool VerifyPassword()
        {
            if (_user.Password == null)
            {
                return false;
            }
            else if (_user.Password.Equals(_user.VerificationPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        private bool VerifyName()
        {
            if (_user.Name == null)
            {
                return false;
            }
            else 
            {
                string nameCheck = Utils.Utils.SendHttpGetRequest("http://localhost:5000/User/verifyuniqueusername?name=" + _user.Name.ToString());
                if (nameCheck.Equals("UserName not available"))
                {
                    return false;
                }
                else
                {
                    return true;
                }            
            }
        }

    }
}
