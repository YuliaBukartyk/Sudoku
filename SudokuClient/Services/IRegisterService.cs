using SudokuClient.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Services
{
    public interface IRegisterService
    {
        bool CanRegister(User user);

    }
}
