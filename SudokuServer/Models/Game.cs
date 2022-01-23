using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace SudokuServer.Models
{
    public class Game 
    {
            [Key]
            public int Id { get; set; }
            public string duration { get; set; }
            public string level { get; set; }
            public User user { get; set; }


    }    
}