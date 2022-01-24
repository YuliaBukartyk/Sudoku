﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Models
{
    public class Game
    {
        private string _duration;
        private string _level;
        private bool _endGame = false;
        private User _user;

        public string Duration
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

        public bool EndGame
        {
            get
            {
                return this._endGame;
            }
            set
            {
                this._endGame = value;
            }
        }

        public User User
        {
            get
            {
                return this._user;
            }
            set
            {
                this._user = value;
            }
        }


    }
}
