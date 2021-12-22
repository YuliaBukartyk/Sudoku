﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;



namespace SudokuServer.Models
{
    public class User 
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public string password { get; set; }
    }
}