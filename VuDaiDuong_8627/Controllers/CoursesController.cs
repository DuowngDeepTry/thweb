using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VuDaiDuong_8627.Models;
using VuDaiDuong_8627.ViewModels;

namespace VuDaiDuong_8627.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;
        // GET: Courses
        public CoursesController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new CourseViewModels
            {
                Categories = _dbcontext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}