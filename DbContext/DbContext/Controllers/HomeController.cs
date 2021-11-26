using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContext.Models;
using DbContext.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace DbContext.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            //var group1 = new Group
            //{
            //    Id = 1,
            //    Name = "P318"
            //};

            //var group2 = new Group
            //{
            //    Id = 2,
            //    Name = "P418"
            //};

            //var students = new List<Student>
            //{
            //    new Student {Id = 1, Fullname = "Rail Jannatov", Age = 24, Group = group1},
            //    new Student {Id = 2, Fullname = "Fagan Eyvazov", Age = 24, Group = group2},
            //};

            var students = _dbContext.Students.Include(x => x.Group).ToList();

            return View(students);
        }
    }
}
