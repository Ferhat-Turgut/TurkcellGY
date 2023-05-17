using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Ferhat";
            ViewBag.Day = DateTime.Now.Day;
            ViewBag.Month = DateTime.Now.Month;
            ViewBag.Year = DateTime.Now.Year;
            ViewBag.MonthList = new List<string> {"Ocak","Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık" };
            return View();
        }
    }
}
