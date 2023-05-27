using CourseApp.DataTransferObjects.Responses;
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
            var serializedString = HttpContext.Session.GetString("basket");
            if (serializedString==null)
            {
                return new CourseCollection();
            }
            var collection = JsonSerializer.Deserialize<CourseCollection>(serializedString);
            return collection;
        }
        private void saveToSession(CourseCollection courseCollection)
        {
            var serialized = JsonSerializer.Serialize<CourseCollection>(courseCollection);
            if (!string.IsNullOrWhiteSpace(serialized))
            {
                HttpContext.Session.SetString("basket", serialized);
            }
        }
    }
}
