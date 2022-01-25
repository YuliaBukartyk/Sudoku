using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Input;
using SudokuClient.Services;
using SudokuClient.Commands;

namespace SudokuClient.ViewModels
{
    public class GamesHistoryViewModel : BaseViewModel
    {
        private List<PreviousGame> _previousGames;
        public ICommand BackToMenuCommand { get; }
        public List<PreviousGame> PreviousGames
        {
            get
            {
                return _previousGames;
            }
            set
            {
                this._previousGames = value;
            }

        }

        public class PreviousGame
        {
            public string Duration { get; set; }
            public string Level { get; set; }

        }


        public GamesHistoryViewModel(NavigationService MenuGameViewNavigationService, User user)
        {
            BackToMenuCommand = new NavigateCommand(MenuGameViewNavigationService);
            PreviousGames = new List<PreviousGame>();
            string jasonString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Game/getgameinfo?name=" + user.Name);
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            PreviousGames = (List<PreviousGame>)javaScriptSerializer.Deserialize<List<PreviousGame>>(jasonString);

        }
    }
}

