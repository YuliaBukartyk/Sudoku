using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SudokuClient.ViewModels
{
    public class GamesHistoryViewModel : BaseViewModel
    {
        private List<PreviousGame> _previousGames;
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


        public GamesHistoryViewModel()
        {
            //string levels = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Game/getgameshistorylevel?name=" + "yulia");
            //string durations = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Game/getgameshistoryduration?name=" + "yulia");
            PreviousGames = new List<PreviousGame>();
            string jasonString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Game/getgameinfo?");
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            PreviousGames = (List<PreviousGame>)javaScriptSerializer.Deserialize<List<PreviousGame>>(jasonString);

        }
    }
}

