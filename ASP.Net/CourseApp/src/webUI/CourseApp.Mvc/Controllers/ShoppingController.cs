﻿using CourseApp.DataTransferObjects.Responses;
using CourseApp.Mvc.Extensions;
using CourseApp.Mvc.Models;
using CourseApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CourseApp.Mvc.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly ICourseService courseService;

        public ShoppingController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            var courseCollection = getCourseCollectionFromSession();
            return View(courseCollection);
        }
        public IActionResult AddCourse(int id)
        {
            CourseDisplayResponse selectedCourse = courseService.GetCourse(id);
            var courseItem = new CourseItem { Course = selectedCourse, Quantity = 1 };
            

            
            CourseCollection courseCollection = getCourseCollectionFromSession();
            courseCollection.AddNewCourse(courseItem);
            saveToSession(courseCollection);

            return Json(new { message = $"{selectedCourse.Name}  sepete eklendi." });
        }

        private CourseCollection getCourseCollectionFromSession()
        {
            return HttpContext.Session.GetJson<CourseCollection>("basket") ?? new CourseCollection();
        }
        private void saveToSession(CourseCollection courseCollection)
        {
            HttpContext.Session.SetJson<CourseCollection>("basket",courseCollection);
        }
    }
}
