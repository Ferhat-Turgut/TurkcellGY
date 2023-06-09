using CareerApp.DataTransferObject.Requests;
using CareerApp.Mvc.Models;
using CareerApp.Mvc.Views.Home;
using CareerApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

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
        public async Task<IActionResult> CompanyLoginOrRegister()
        {
            JobAndCityList jobAndCityList = new JobAndCityList();
            jobAndCityList.Jobs =await jobService.GetAllJobsAsync();
            jobAndCityList.Cities =await cityService.GetAllCitiesAsync();
            return View(jobAndCityList);
        }
        [HttpPost]
        public async Task< IActionResult> CompanyLogin(string username, string password)
        {
            var IsExist =await companyService.IsCompanyExistAsync(username, password);
            if (!IsExist)
            {
                return RedirectToAction("CompanyLoginOrRegister");
            }
            else
            {
                HttpContext.Session.SetString("CompanyUsername", username);
                return RedirectToAction("Index", "Company");
            }

        }
        [HttpPost]
        public async Task<IActionResult> CreateNewJobSeekerAsync(CreateNewJobSeekerRequest createNewJobSeekerRequest)
        {
            var username=await jobSeekerService.GetJobSeekerByUsernameAsync(createNewJobSeekerRequest.Username);

            if (username==null)
            {
                createNewJobSeekerRequest.RoleId = 2;
                await jobSeekerService.CreateJobSeekerAsync(createNewJobSeekerRequest);
                TempData["SuccessMessage"] = "Kayıt başarıyla tamamlandı.Lütfen giriş yapın.";
                return RedirectToAction("JobSeekerLoginOrRegister");
            }
            else
            {
                TempData["ErrorMessage"] = "Kullanıcı adı başka bir kullanıcı tarafından kullanılıyor.Lütfen değiştirin!";
                return RedirectToAction("JobSeekerLoginOrRegister");
            }
            
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