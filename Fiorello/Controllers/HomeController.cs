using Fiorello.DAL;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class HomeConAtroller : Controller
    {
        private AppDbContext _db { get; }
        public HomeConAtroller(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM home = new HomeVM {
                Slides = _db.Slides.ToList()
            };
            return View();
        }

       
    }
}
