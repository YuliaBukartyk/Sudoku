using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SudokuClient.Utils;
using System.Windows;


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

            if (VerifyPassword())
            {
                Utils.Utils.SendHttpGetRequest("http://localhost:5000/User/adduser?name=" + _user.Name.ToString());
            }
            else
            {
               // MessageBox.Show("Password error");
                MessageBox.Show(Application.Current.MainWindow, "Password error", "Login Failure", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel);
            }
                

        }


        private bool VerifyPassword()
        {
            if (_user.Password.Equals(_user.VerificationPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
