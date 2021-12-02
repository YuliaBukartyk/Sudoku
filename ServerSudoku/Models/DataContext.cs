using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SudokuServer.Models
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-NE5SC99\SQLEXPRESS01;Initial Catalog=SudokuDB;Integrated Security=True");
        }
    }
}