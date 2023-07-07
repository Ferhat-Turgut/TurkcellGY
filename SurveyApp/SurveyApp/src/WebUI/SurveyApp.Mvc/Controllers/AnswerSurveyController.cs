using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Survey.Entities;
using SurveyApp.DataTransferObjects.Requests;
using SurveyApp.Services;

namespace SurveyApp.Mvc.Controllers
{
    public class AnswerSurveyController : Controller
    {
        private readonly ISurveyService _surveyService;
        private readonly IAnswerService _answerService;

        public AnswerSurveyController(ISurveyService surveyService, IAnswerService answerService)
        {
            _surveyService = surveyService;
            _answerService = answerService;
        }

        public async Task<IActionResult> AnswerTheSurvey(int id)
        {
            var survey = await _surveyService.GetSurveyAsync(id);
            return View(survey);
        }
        [HttpPost]
        public async Task<IActionResult> AnswerTheSurvey(CreateNewAnswerRequest createNewAnswerRequest)
        {
            await _answerService.CreateNewAnswerAsync(createNewAnswerRequest);
            return RedirectToAction("Index","Home");
        }
    }
}
