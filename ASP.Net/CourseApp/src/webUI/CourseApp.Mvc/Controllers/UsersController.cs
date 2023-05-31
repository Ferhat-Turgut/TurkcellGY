using CourseApp.Mvc.Models;
using CourseApp.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CourseApp.Mvc.Controllers
{
    public class UsersController : Controller
    {
        private  IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(string gidilecekSayfa)
        {
            ViewBag.ReturnUrl = gidilecekSayfa;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLogin, string? gidilecekSayfa)
        {
            if (ModelState.IsValid)
            {
                var user=userService.validateUser(userLogin.UserName,userLogin.Password);
                if (user!=null)
                {
                    Claim[] claims = new Claim[] 
                    {
                        new Claim(ClaimTypes.Name,user.Name),
                        new Claim(ClaimTypes.Email,user.Email),
                        new Claim(ClaimTypes.Role,user.Role),
                    };
                    ClaimsIdentity identity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal= new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);

                    if (!string.IsNullOrEmpty(gidilecekSayfa) && Url.IsLocalUrl(gidilecekSayfa))
                    {
                        return Redirect(gidilecekSayfa);
                    }
                    else
                    {
                        return Redirect("/");
                    }
                }
                else
                {
                    ModelState.AddModelError("login","Kullanıcı adı veya şifre hatalı.");
                }
            }
            return View();
        }
        public async Task<IActionResult> Logout() 
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");

        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
