using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Services
{
    public interface IValidationService
    {
        bool IsNotEmpty(User user);
        bool IsValidated(User user);

    }
}
