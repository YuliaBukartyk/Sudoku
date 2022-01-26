using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuClient.Services
{
    public interface ILoginService //using Facade design pattern
    {
        bool CanLogin(User user);
    }
}