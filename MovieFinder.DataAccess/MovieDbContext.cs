using Microsoft.EntityFrameworkCore;
using MovieFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder.DataAccess
{
    public class MovieDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-AFUMI0D\\MSSQLCNBRK; Database=MovieDb; uid=sa;pwd=123;");
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
