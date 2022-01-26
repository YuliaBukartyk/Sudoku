using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SudokuServer.Services
{
    public interface ILoginService //using Facade design pattern
    {
        bool CanLogin(string userName, string password);
    }
}