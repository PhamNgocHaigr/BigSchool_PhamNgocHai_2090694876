using PhamNgocHai_2090694876.Models;
using PhamNgocHai_2090694876.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhamNgocHai_2090694876.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CoursesViewModel
            {
                Categories = _dbContext.Categories.Tolist()
            };
            return View(viewModel);
        }
    }
}