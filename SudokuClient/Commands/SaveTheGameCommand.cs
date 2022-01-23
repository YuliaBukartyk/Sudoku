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
           Utils.Utils.SendHttpGetRequest("http://localhost:5000/Game/addgameinfo?name=" + _game.Duraion.ToString() + "&" + "level=" + _game.Level);

        }
    }
}
