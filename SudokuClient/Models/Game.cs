using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Models
{
    public class Game
    {
        private string _duration;
        private string _level;


        public string Duraion
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }

        public string Level
        {
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
            }
        }
    }
}
