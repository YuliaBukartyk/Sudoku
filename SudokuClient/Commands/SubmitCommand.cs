using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SudokuClient.Utils;


namespace SudokuClient.Commands
{
    public class SubmitCommand : CommandBase
    {
        public User user;
        public SubmitCommand(User newUser)
        {
            user = new User();
            user = newUser;
        }

        public override void Execute(object parameter)
        {
            
            string s = Utils.Utils.SendHttpGetRequest("http://localhost:5000/User/adduser?name=" + user.Name.ToString());

            
        }
    }
}
