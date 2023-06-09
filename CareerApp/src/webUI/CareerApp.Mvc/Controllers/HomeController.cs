using CareerApp.Mvc.Models;
using CareerApp.Mvc.Views.Home;
using CareerApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CareerApp.Mvc.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ICompanyService companyService;
        private readonly IJobSeekerService jobSeekerService;
        private readonly IJobService jobService;
        private readonly ICityService cityService;

        public HomeController(ICompanyService companyService, IJobSeekerService jobSeekerService,IJobService jobService, ICityService cityService)
        {
            this.companyService = companyService;
            this.jobSeekerService = jobSeekerService;
            this.jobService = jobService;
            this.cityService = cityService;
        }

        public IActionResult Index()
        {
           

            return View();
        }
        public IActionResult JobSeekerLoginOrRegister() 
        {
            JobAndCityList jobAndCityList = new JobAndCityList();
            jobAndCityList.Jobs = jobService.GetAllJobs();
            jobAndCityList.Cities = cityService.GetAllCities();
            return View(jobAndCityList);
        }
        [HttpPost]
        public IActionResult JobSeekerLogin(string username,string password)
        {
            var IsExist= jobSeekerService.IsJobSeekerExist(username, password);
            if (!IsExist)
            {
                return RedirectToAction("JobSeekerLoginOrRegister");
            }
            else
            {
                HttpContext.Session.SetString("Username", username);
                return RedirectToAction("Index", "JobSeeker");
            }
            
        }
        public IActionResult CompanyLoginOrRegister()
        {
            JobAndCityList jobAndCityList = new JobAndCityList();
            jobAndCityList.Jobs = jobService.GetAllJobs();
            jobAndCityList.Cities = cityService.GetAllCities();
            return View(jobAndCityList);
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