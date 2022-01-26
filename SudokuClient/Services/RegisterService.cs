using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly IValidationService _validationService;

        public RegisterService()
        {
            _validationService = new ValidationRegisterService();
        }

        public bool CanRegister(User user)
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
