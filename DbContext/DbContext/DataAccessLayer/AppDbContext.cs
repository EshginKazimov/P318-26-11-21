using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContext.Models;
using Microsoft.EntityFrameworkCore;
using Context = Microsoft.EntityFrameworkCore.DbContext;

namespace DbContext.DataAccessLayer
{
    //ORM - Object relational mapping
    public class AppDbContext : Context
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
