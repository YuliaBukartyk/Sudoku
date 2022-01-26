using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SudokuServer.Services
{
    public class LoginService : ILoginService //using Facade design pattern
    {
        private readonly IValidationService _validationService;
        public LoginService()
        {
            _validationService = new ValidationService();
        }

        public bool CanLogin(string userName, string password)
        {
            if (_validationService.IsValidated(userName, password))
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