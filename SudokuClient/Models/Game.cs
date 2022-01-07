using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Models
{
    public class Game
    {
        private int _duration;
     

        public int Duraion
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

    }
}
