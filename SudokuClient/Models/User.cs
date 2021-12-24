using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Models
{
    public class User
    {
        private string _name;
        private string _password;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }


        

        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }
    }
}
