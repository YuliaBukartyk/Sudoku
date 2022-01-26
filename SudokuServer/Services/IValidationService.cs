using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SudokuServer.Services
{
    public interface IValidationService //using Facade design pattern
    {
        bool IsValidated(string userName, string password);
    }
}