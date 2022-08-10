using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AzureWebHookSample.Attributes
{
    public class BasicAuthenticationHandler:AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,ILoggerFactory logger , 
            UrlEncoder encoder , ISystemClock clock) : base(options,logger,encoder,clock)
        {

        }
        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            Response.Headers.Add("WWW-Authenticate", "Basic");

            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return Task.FromResult(AuthenticateResult.Fail("Autherization Header Missed"));
            }
            var authorizationHeader = Request.Headers["Authorization"].ToString();
            var authorizationRegex = new Regex("Basic (.*)");
            if (!authorizationRegex.IsMatch(authorizationHeader))
            {
                return Task.FromResult(AuthenticateResult.Fail("Authorization Code Not Formatted Properly"));

            }
            var authBase64 = Encoding.UTF8.GetString(Convert.FromBase64String(authorizationRegex.Replace(authorizationHeader, "$1")));

            var authSplit = authBase64.Split(Convert.ToChar(":"), 2);
            var authUserName = authSplit[0];
            var authPassword = authSplit.Length > 1 ? authSplit[1] : throw new Exception("Unable to get password ");

            if (authUserName !="TestUser" || authPassword!="PasswordTest33")
            {
                return Task.FromResult(AuthenticateResult.Fail("The UserName or Password is incorrect"));

            }
            var authenticatedUser = new AuthenticatedUser("BasicAuthentication", true, "TestUser");
            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(authenticatedUser));

            return Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(claimsPrincipal,Scheme.Name)));

        }




    }
}
