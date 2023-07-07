using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Survey.Entities;
using SurveyApp.Services;
using System.Security.Claims;

namespace SurveyApp.Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>LoginAsync(string Username, string Password)
        {
            var user = await _userService.ValidateUserAsync(Username, Password);
            if (user != null)
            {
                Claim[] claims = new Claim[]
                {
                        new Claim(ClaimTypes.Name,user.Username),
                        new Claim("ID", user.Id.ToString())
                };
                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
                HttpContext.Session.SetInt32("UserId", user.Id);
                return RedirectToAction("Statistics", "User");
            }
            else
            {
                ModelState.AddModelError("login", "Kullanıcı adı veya şifre hatalı.");
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
        [Authorize]
        public async Task<IActionResult> Statistics()
        {
            int userId=Convert.ToInt32( HttpContext.Session.GetInt32("UserId"));
            var surveys=await _userService.GetSurveysForStatisticsAsync(userId);
            return View(surveys);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
