using CareerApp.DataTransferObject.Requests;
using CareerApp.Entities;
using CareerApp.Mvc.Views.Company;
using CareerApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareerApp.Mvc.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;
        private readonly IJobSeekerService jobSeekerService;
        private readonly IJobService jobService;
        private readonly ICityService cityService;
        private readonly IJobPostingService jobPostingService;
        private readonly IRecourseServices recourseServices;

        public CompanyController(ICompanyService companyService, IJobSeekerService jobSeekerService, IJobService jobService, ICityService cityService, IJobPostingService jobPostingService, IRecourseServices recourseServices)
        {
            this.companyService = companyService;
            this.jobSeekerService = jobSeekerService;
            this.jobService = jobService;
            this.cityService = cityService;
            this.jobPostingService = jobPostingService;
            this.recourseServices = recourseServices;
        }
        public async Task< IActionResult> Index()
        {
            var companyUsername = HttpContext.Session.GetString("CompanyUsername");
            var company = await companyService.GetCompanyByUsernameAsync(companyUsername);
            var jobPostings = await jobPostingService.GetJobPostingsByCompanyAsync(company.Id);

        
            UserDetailsAndJobPostings userDetailsAndJobPostings = new UserDetailsAndJobPostings();
            userDetailsAndJobPostings.Company= company;
            userDetailsAndJobPostings.jobPostingDisplayResponses = jobPostings;

            return View(userDetailsAndJobPostings);
        }
        //[HttpGet]
       //public  ActionResult UpdateCompanyAsync( )
       // {
            
       //     return View();
       // }
       public async Task<IActionResult> ApplicantsAsync(int companyId)
        {
            var applicants =await recourseServices.GetRecoursesByCompanyAsync(companyId);
            return View(applicants);
        }
    }
}
