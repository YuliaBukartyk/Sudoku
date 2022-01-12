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
            var x = 1;
           Utils.Utils.SendHttpGetRequest("http://localhost:5000/User/adduser?name=" + _game.Duraion);


        }
    }
}
