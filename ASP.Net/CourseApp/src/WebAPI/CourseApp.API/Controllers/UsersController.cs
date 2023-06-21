using CourseApp.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using CourseApp.API.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CourseApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLogin)
        {
            if (ModelState.IsValid)
            {
                var user = userService.validateUser(userLogin.UserName, userLogin.Password);
                if (user != null)
                {
                    Claim[] claims = new Claim[]
                    {
                        new Claim(JwtRegisteredClaimNames.UniqueName,user.Name),
                        new Claim(ClaimTypes.Email,user.Email),
                        new Claim(ClaimTypes.Role,user.Role),
                    };
                    //ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    //ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("BURASI-COK-GIZLI"));
                    var credential = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        issuer:"server",
                        audience:"client",
                        claims:claims,
                        notBefore:DateTime.Now,
                        expires:DateTime.Now.AddMinutes(20),
                        signingCredentials:credential
                        );

                    return Ok(new {token=new JwtSecurityTokenHandler().WriteToken(token)});
                    
                }
                else
                {
                    ModelState.AddModelError("login", "Kullanıcı adı veya şifre hatalı.");
                }
            }
            return BadRequest(ModelState);
        }
    }
}
