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
        private Cell[] _sudokuCells;

        public SaveTheGameCommand(Game newGame, Cell[] Cells, NavigationService MenuViewNavigationService)
        {
            _game = newGame;
            _navigationService = MenuViewNavigationService;
            _sudokuCells = Cells;
        }

        public override void Execute(object parameter)
        {
           _game.EndGame = true;
           CheckIfSuccess();
           Utils.Utils.SendHttpGetRequest("http://localhost:5000/Game/addgameinfo?duration=" + _game.Duration + "&" + "level=" + _game.Level + "&" + "name=" + _game.User.Name + "&" + "result=" + (_game.IsSuccess ? "Success" : "Failure")); 
           MessageBox.Show(Application.Current.MainWindow, "Thanks for Playing, Your result is: " + (_game.IsSuccess ? "Success" : "Failure"), "Game Finished", MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK);
           Thread.Sleep(2000);
           _navigationService.Navigate();
        }

        private void CheckIfSuccess()
        {
            bool IsSuccess = true;

            for (int i = 0; i < _sudokuCells.Length; i++)
            {
                if (_sudokuCells[i].IsValid == false)
                {
                    IsSuccess = false;
                }
            }
            _game.IsSuccess = IsSuccess;
        }

    }
}