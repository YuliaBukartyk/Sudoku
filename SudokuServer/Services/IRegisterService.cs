using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SudokuServer.Services
{
    public interface IRegisterService //using Facade design pattern
    {
        bool CanRegister(string userName, string password);
    }
}