using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Commands
{
    public class SaveTheGameCommand : CommandBase
    {
        private readonly Game _game;
        public SaveTheGameCommand(Game newGame)
        {
            _game = newGame;
        }

        public override void Execute(object parameter)
        {
           _game.EndGame = true;
           var x = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Game/addgameinfo?duration=" + _game.Duraion + "&" + "level=" + _game.Level + "&" + "name=" + _game.User.Name.ToString());

        }
    }
}
  