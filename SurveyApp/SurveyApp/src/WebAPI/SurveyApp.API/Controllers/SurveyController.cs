using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survey.Entities;
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

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetSurvey(int id)
        {
            var survey =await _surveyService.GetSurveyAsync(id);
            if (survey == null)
            {
                return NotFound();
            }
            return Ok(survey);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewSurveyRequest createNewSurveyRequest)
        {
            if (ModelState.IsValid)
            {
                
                var lastSurveyId = await _surveyService.CreateSurveyAndReturnIdAsync(createNewSurveyRequest);
                return CreatedAtAction(nameof(GetSurvey), routeValues: new { id = lastSurveyId }, null);

            }
            return BadRequest(ModelState);
        }
    }
}
