using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SudokuClient.Utils;
using System.Windows;
using SudokuClient.Services;

namespace SudokuClient.Commands
{
    public class SubmitCommand : CommandBase //using Command design pattern
    {
        private readonly User _user;
        private NavigationService _navigationService;
        private readonly RegisterService _register;
        public SubmitCommand(User newUser, NavigationService LogInViewNavigationService)
        {
            _user = newUser;
            _navigationService = LogInViewNavigationService;
            _register = new RegisterService();
        }

        public override void Execute(object parameter)
        {
            if (_register.CanRegister(_user))
            {
                _navigationService.Navigate();
            }
        }
    }
}
