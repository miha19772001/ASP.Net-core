using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        public DbSet<User> Users { get; set; }
    }
}
