using Microsoft.AspNet.Identity;
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
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModels
            {
                Categories = _dbcontext.Categories.ToList()
            };
            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModels viewModels)
        {
            if (!ModelState.IsValid)
            {
                viewModels.Categories = _dbcontext.Categories.ToList();
                return View("Create", viewModels);
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModels.GetDateTime(),
                CategoryId = viewModels.Category,
                Place = viewModels.Place,
            };
            _dbcontext.Courses.Add(course);
            _dbcontext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}