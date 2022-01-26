using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SudokuServer.Services
{
    public class RegisterService : IRegisterService //using Facade design pattern
    {
        private readonly IValidationService _validationService;
        public RegisterService()
        {
            _validationService = new ValidationRegisterService();
        }

        public bool CanRegister(string userName, string password)
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