using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace CourseApp.API.Security
{
    public class BasicHandler:AuthenticationHandler<BasicOption>
    {
        public BasicHandler(IOptionsMonitor<BasicOption> optionsMonitor,ILoggerFactory logger,UrlEncoder encoder,ISystemClock systemClock)
            :base(optionsMonitor,logger,encoder,systemClock)
        {

        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            //1.Gelen request içinde authorization header bilgisi var mı?
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }
            //2.Authorization doğru formatta mı?
            if (!AuthenticationHeaderValue.TryParse(Request.Headers["Authorization"],out AuthenticationHeaderValue headerValue))
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }
            //3.Authorization 'Basic' mi?
            if (headerValue.Scheme!="Basic")
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }

            var base64Bytes = Convert.FromBase64String(headerValue.Parameter);
            var decoded=Encoding.UTF8.GetString(base64Bytes);
            var username = decoded.Split(':')[0];
            var password= decoded.Split(":")[1];

            if (username!="ft3065" || password!="123")
            {
                return Task.FromResult(AuthenticateResult.Fail("Kullanıcı adı veya şifre hatalı!"));
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Name,username)
            };

            var identity=new ClaimsIdentity(claims,Scheme.Name);
            var principal=new ClaimsPrincipal(identity);
            AuthenticationTicket ticket = new AuthenticationTicket(principal,Scheme.Name);
            return Task.FromResult(AuthenticateResult.Success(ticket));
        }
    }
}
