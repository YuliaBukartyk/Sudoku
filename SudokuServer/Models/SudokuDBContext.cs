﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SudokuServer.Models;

namespace sudokuLogic.Models
{
    public class SudokuDBContext : DbContext
    {
        public DbSet<Board> Boards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-N53TO97U;Initial Catalog=Sudoku;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-N53TO97U;Initial Catalog=Sudoku;Integrated Security=True");

        }
    }
}