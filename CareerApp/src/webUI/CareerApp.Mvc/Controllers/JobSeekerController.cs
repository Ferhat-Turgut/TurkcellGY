using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;
using CareerApp.Entities;
using CareerApp.Mvc.Views.JobSeeker;
using CareerApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CareerApp.Mvc.Controllers
{
    
    public class JobSeekerController : Controller
    {
        private readonly ICompanyService companyService;
        private readonly IJobSeekerService jobSeekerService;
        private readonly IJobService jobService;
        private readonly ICityService cityService;
        private readonly IJobPostingService jobPostingService;
        private readonly IRecourseServices recourseServices;

        public JobSeekerController(ICompanyService companyService, IJobSeekerService jobSeekerService, IJobService jobService, ICityService cityService, IJobPostingService jobPostingService, IRecourseServices recourseServices)
        {
            this.companyService = companyService;
            this.jobSeekerService = jobSeekerService;
            this.jobService = jobService;
            this.cityService = cityService;
            this.jobPostingService = jobPostingService;
            this.recourseServices = recourseServices;
        }
        public async Task<IActionResult> Index()
        {
            
            var jobSeekerUsername = HttpContext.Session.GetString("Username");
            var jobSeeker=await jobSeekerService.GetJobSeekerByUsernameAsync(jobSeekerUsername);
            var jobPostings = await jobPostingService.GetJobPostingDisplayResponsesAsync();

            var JobSeekerCity =await cityService.GetCityAsync(jobSeeker.CityId);
            var JobSeekerJob =await jobService.GetJobAsync(jobSeeker.JobId);

            ViewBag.JobSeekerCity = JobSeekerCity.Name;
            ViewBag.JobSeekerJob = JobSeekerJob.Name;

            UserDetailsAndJobPostings userDetailsAndJobPostings = new UserDetailsAndJobPostings();
            userDetailsAndJobPostings.JobSeekerDisplayResponse = jobSeeker;
            userDetailsAndJobPostings.jobPostingDisplayResponses = jobPostings;

            return View(userDetailsAndJobPostings);
        }
        public async Task< IActionResult> JobPostingDetails(int jobPostingId) 
        {
            var selectedJobPosting =await jobPostingService.GetJobPostingAsync(jobPostingId);
            var jobPostingCity =await cityService.GetCityAsync(selectedJobPosting.CityId);
            var jobPostingJob =await jobService.GetJobAsync(selectedJobPosting.JobId);

            selectedJobPosting.City= jobPostingCity;
            selectedJobPosting.Job= jobPostingJob;
            
            return View(selectedJobPosting);
        }
       
        [HttpPost]
        public async Task<IActionResult> CreateNewRecourse(int jobPostingId) 
        {
            
            CreateNewRecourseRequest createNewRecourseRequest = new CreateNewRecourseRequest();

            var jobPosting =await jobPostingService.GetJobPostingAsync(jobPostingId);
            var jobSeekerUsername = HttpContext.Session.GetString("Username");
            var jobSeeker =await jobSeekerService.GetJobSeekerByUsernameAsync(jobSeekerUsername);

            createNewRecourseRequest.RecourseDate = DateTime.Now;
            createNewRecourseRequest.JobPostingId = jobPostingId;
            createNewRecourseRequest.CompanyId = jobPosting.CompanyId;
            createNewRecourseRequest.JobSeekerId = jobSeeker.Id;

            await recourseServices.CreateRecourseAsync(createNewRecourseRequest);
            return RedirectToAction("Index", "JobSeeker");
        }

        public async Task<IActionResult> UpdateUserInfo(int userId) 
        {
            var jobSeeker=await jobSeekerService.GetJobSeekerForUpdateAsync(userId);
            ViewBag.Cities =await cityService.GetAllCitiesAsync();
            ViewBag.Jobs =await jobService.GetAllJobsAsync();

            return View(jobSeeker);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUserInfo(UpdateJobSeekerRequest model)
        {
                model.RoleId = 2;
                await jobSeekerService.UpdateJobSeekerAsync(model);
                return RedirectToAction("Index");
       
        }
        public async Task<IActionResult> Recourses(int jobSeekerId)
        {
           
            var recourses =await recourseServices.GetRecoursesByJobSeekerAsync(jobSeekerId);
           
            return View(recourses);
        }
      
        public async Task<IActionResult> DeleteRecourse(int recourseId)
        {
            await recourseServices.DeleteRecourseAsync(recourseId);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public  IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
