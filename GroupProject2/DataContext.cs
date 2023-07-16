using GroupProject2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject2
{
    public class DataContext : DbContext
    {

        private readonly string path = @"C:\Engneering\Programming_Save_Files\C#\.NET_WPF_Application\Project\Group_Project\GroupProject2\GroupProject2\Database\database.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={path}");

        public DbSet<User> UsersDb { get; set; }
        public DbSet<Student> StudentDb { get; set; }
    }
}
