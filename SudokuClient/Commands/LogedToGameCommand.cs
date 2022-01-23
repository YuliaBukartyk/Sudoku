using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;

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
            var x = _user.Name;
            var y = _user.Password;
            _navigationService.Navigate();
        }
    }
}
