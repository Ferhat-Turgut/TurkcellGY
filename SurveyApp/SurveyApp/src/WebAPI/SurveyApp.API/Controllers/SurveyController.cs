using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using SurveyApp.DataTransferObjects.Requests;
using SurveyApp.Services;

namespace SurveyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly ISurveyService _surveyService;

        public SurveyController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        

        [HttpPost("create")]
        [Authorize]
        public async Task<IActionResult> CreateAsync(CreateNewSurveyRequest createNewSurveyRequest)
        {
            if (ModelState.IsValid)
            {
                
                var lastSurveyId = await _surveyService.CreateSurveyAndReturnIdAsync(createNewSurveyRequest);
                var returnUrl = $"https://localhost:7101/AnswerSurvey/AnswerTheSurvey/{lastSurveyId}";
                return Ok(new { returnUrl });

            }
            return BadRequest(ModelState);
        }
    }
}
