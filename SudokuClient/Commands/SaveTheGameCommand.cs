using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;




namespace SudokuClient.Commands
{
    public class SaveTheGameCommand : CommandBase
    {
        private  Game _game;

        public SaveTheGameCommand(Game newGame)
        {
            _game = newGame;
        }

        public override void Execute(object parameter)
        {
           _game.EndGame = true;

           string jasonString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Game/addgameinfo?duration=" + _game.Duration + "&" + "level=" + _game.Level + "&" + "name=" + _game.User.Name);
        }

    }
}