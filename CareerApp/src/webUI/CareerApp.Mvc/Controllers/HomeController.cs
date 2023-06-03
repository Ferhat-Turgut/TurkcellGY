using CareerApp.Mvc.Models;
using CareerApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CareerApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IJobPostingService _jobPostingService;

        public HomeController(ILogger<HomeController> logger,IJobPostingService jobPostingService)
        {
            _logger = logger;
            _jobPostingService= jobPostingService;
        }

        public IActionResult Index()
        {
            var jobPosting = _jobPostingService.GetJobPostingDisplayResponses();
            return View(jobPosting);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}