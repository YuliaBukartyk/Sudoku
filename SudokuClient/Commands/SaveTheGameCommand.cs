using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;

namespace SudokuClient.Commands //using Command design pattern
{
    public class SaveTheGameCommand : CommandBase
    {
        private  Game _game;
        private NavigationService _navigationService;

        public SaveTheGameCommand(Game newGame, NavigationService MenuViewNavigationService)
        {
            _game = newGame;
            _navigationService = MenuViewNavigationService;
        }

        public override void Execute(object parameter)
        {
           _game.EndGame = true;
           Utils.Utils.SendHttpGetRequest("http://localhost:5000/Game/addgameinfo?duration=" + _game.Duration + "&" + "level=" + _game.Level + "&" + "name=" + _game.User.Name + "&" + "result=" + (_game.IsSuccess ? "Success" : "Failure")); 
           MessageBox.Show(Application.Current.MainWindow, "Thanks for Playing, Your result is: " + (_game.IsSuccess ? "Success" : "Failure"), "Game Finished", MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK);
            Thread.Sleep(2000);
           _navigationService.Navigate();
        }

    }
}