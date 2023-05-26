using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Mvc.Controllers
{
    public class ShoppingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddCourse(int id)
        {
            return Json(new { message = $"{id} id numaralı kurs, sepete eklenme talebiyle sunucuya gönderildi."} );
        }
    }
}
