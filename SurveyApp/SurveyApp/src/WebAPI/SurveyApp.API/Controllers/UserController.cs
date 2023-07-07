using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using SurveyApp.API.Models;
using SurveyApp.DataTransferObjects.Requests;
using SurveyApp.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;



namespace SurveyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginViewModel userLogin)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.ValidateUserAsync(userLogin.UserName, userLogin.Password);
                
                if (user != null)
                {
                    Claim[] claims = new Claim[]
                    {

                        new Claim(ClaimTypes.Name, user.Id.ToString()),
                        
                    };
                    

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("BURASI-COK-GIZLI"));
                    var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        issuer: "server",
                        audience: "client",
                        claims: claims,
                        notBefore: DateTime.Now,
                        expires: DateTime.Now.AddMinutes(20),
                        signingCredentials: credential
                        );

                    return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });

                }
                else
                {
                    ModelState.AddModelError("login", "Kullanıcı adı veya şifre hatalı.");
                }
            }
            return BadRequest(ModelState);
        }

        [HttpPost("create")]
        public async Task<ActionResult> Create(CreateNewUserRequest createNewUserRequest)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.IsUserExistAsync(createNewUserRequest.Username);
                if (user == false)
                {
                    await _userService.CreateNewUserAsync(createNewUserRequest);
                    return Ok("Kayıt Başarılı.");
                }
                else
                {
                    ModelState.AddModelError("register", "Kullanıcı adı başka biri tarafından kullanılıyor. Lütfen başka bir kullanıcı adı girin!");
                }
            }
            else
            {
                ModelState.AddModelError("register", "Kullanıcı adı veya şifreyi doğru bir şekilde giriniz!");
            }
            return BadRequest(ModelState);
        }

    }
}
