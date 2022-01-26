using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Services
{
    public class LoginService : ILoginService //using Facade design pattern
    {
        private readonly IValidationService _validationService;
        public LoginService()
        {
            _validationService = new ValidationLogInService();
        }


        public bool CanLogin(User user)
        {
            if (_validationService.IsNotEmpty(user))
            {
                if (_validationService.IsValidated(user))
                {
                    return true;
                }
                return false;
            }
            return false;

        }
    }
}
