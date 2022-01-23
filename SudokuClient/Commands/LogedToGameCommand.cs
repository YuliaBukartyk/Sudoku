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
            //var x = _user.Name;
            //var y = _user.Password;
            //bool success = false;
            string success = "false";

            success = Utils.Utils.SendHttpGetRequest("http://localhost:5000/User/verifyuser?name=" + _user.Name.ToString() + "&" + "password=" + _user.Password.ToString());

            if (success.Equals("true"))
            {
                // success! there is user and password is correct
                int i = 0;
            }
            else
            {
                // false, no such user or password is incorrect
                int i = 1;
            }


            _navigationService.Navigate();
        }
    }
}
