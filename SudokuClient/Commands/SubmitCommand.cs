using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SudokuClient.Utils;


namespace SudokuClient.Commands
{
    public class SubmitCommand : CommandBase
    {
        private readonly User _user;
        public SubmitCommand(User newUser)
        {
            _user = newUser;
        }

        public override void Execute(object parameter)
        {
            
            Utils.Utils.SendHttpGetRequest("http://localhost:5000/User/adduser?name=" + _user.Name.ToString());

            
        }
    }
}
