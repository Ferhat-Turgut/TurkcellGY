using CareerApp.DataTransferObject.Requests;
using CareerApp.Entities;
using CareerApp.Mvc.Views.Company;
using CareerApp.Services;
using Microsoft.AspNetCore.Authorization;
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
        [HttpGet]
        public  IActionResult UpdateCompany(int companyId)
        {
            var company =  companyService.GetCompanyForUpdate(companyId);
           
            return View(company);
        }
        [HttpPost]
        public IActionResult UpdateCompany(UpdateCompanyRequest updateCompanyRequest)
        {
            updateCompanyRequest.RoleId = 1;
            companyService.UpdateCompany(updateCompanyRequest);

            return RedirectToAction("Index");
        }
        public IActionResult ChangeJobPostingStatus(int jobPostingId)
        {
            jobPostingService.ChangeJobPostingStatus(jobPostingId);
            return RedirectToAction("Index");
        }
        public  IActionResult Applicants(int companyId)
        {
            var applicants = recourseServices.GetRecoursesByCompany(companyId);
     
            return View(applicants);
        }
        public IActionResult ApplicantDetails(int jobPostingId,int jobSeekerId)
        {
            var jobPosting=jobPostingService.GetJobPosting(jobPostingId);
            var jobSeeker=jobSeekerService.GetJobSeeker(jobSeekerId);

            ViewBag.JobSeekerCity = cityService.GetCity(jobSeeker.CityId).Name;
            ViewBag.JobSeekerJob = jobService.GetJob(jobSeeker.JobId).Name;
            ApplicantsDetails applicantsDetails = new ApplicantsDetails();
            applicantsDetails.JobPosting = jobPosting;
            applicantsDetails.JobSeeker = jobSeeker;


            return View(applicantsDetails);
        }
        public IActionResult CreateNewJobPosting()
        {
            ViewBag.Cities = cityService.GetAllCities();
            ViewBag.Jobs = jobService.GetAllJobs();
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewJobPosting(CreateNewJobPostingRequest createNewJobPostingRequest)
        {
            var companyName = HttpContext.Session.GetString("CompanyUsername");
            var company = companyService.GetCompanyByUsername(companyName);

            createNewJobPostingRequest.ListingDate = DateTime.Now;
            createNewJobPostingRequest.CompanyId = company.Id;
            if (ModelState.IsValid)
            {
                jobPostingService.CreateJobPosting(createNewJobPostingRequest);
                return RedirectToAction("Index");
            }
            else
            {
                return View(createNewJobPostingRequest);
            }
            
            
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }

    }
}
