using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SudokuClient.Commands
{
    public class LogedToGameCommand : CommandBase
    {

        private User _user;
        private NavigationService _navigationService;
        public LogedToGameCommand(User user, NavigationService MenuGameViewNavigationService)
        {
            _user = user;
            _navigationService = MenuGameViewNavigationService;
        }

        public override void Execute(object parameter)
        {

            if (_user.Password == null || _user.Name == null)
            {
                MessageBox.Show(Application.Current.MainWindow, "One of the credentials is empty, please try again", "Login Failure", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel);
            }
            else
            {
                string success = Utils.Utils.SendHttpGetRequest("http://localhost:5000/User/verifyuser?name=" + _user.Name.ToString() + "&" + "password=" + _user.Password.ToString());

                if (success.Equals("true"))
                {
                    _navigationService.Navigate();
                }
                else
                {
                    MessageBox.Show(Application.Current.MainWindow, "One of the credentials is not correct, please try again", "Login Failure", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel);
                }
            }
        }
    }
}
