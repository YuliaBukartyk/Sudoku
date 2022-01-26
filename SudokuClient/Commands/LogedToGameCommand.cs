using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SudokuClient.Commands
{
    public class LogedToGameCommand : CommandBase //using Command design pattern
    {

        private User _user;
        private NavigationService _navigationService;
        private readonly LoginService _login;

        public LogedToGameCommand(User user, NavigationService MenuGameViewNavigationService)
        {
            _user = user;
            _navigationService = MenuGameViewNavigationService;
            _login = new LoginService();
        }

        public override void Execute(object parameter)
        {
            if (_login.CanLogin(_user))
            {
                _navigationService.Navigate();
            }
        }
    }
}
