using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SudokuServer.Models;

namespace SudokuServer.Models
{
    public class SudokuDBContext : DbContext
    {
        public DbSet<Board> Boards { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=YROTBER-MOBL;Initial Catalog=SudokuDB;Integrated Security=True");     
        }
    }
}
