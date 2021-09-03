using BlueFashionRetailer.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace BlueFashionRetailer.API
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        readonly IAuthService _userService;

        public BasicAuthenticationHandler(IAuthService userService, 
            IOptionsMonitor<AuthenticationSchemeOptions> options, 
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock) : base (options, logger, encoder, clock)
        {
            _userService = userService;
        }
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            string email = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]); // PEGA O AUTHORIZATION DO CABEÇALHO.
                var credentials = Encoding.UTF8.GetString(Convert.FromBase64String(authHeader.Parameter)).Split(":");
                // |-> TRANSFORMANDO O authHeader EM ALGO LEGÍVEL E SEPARADO POR ":"

                email = credentials.FirstOrDefault(); // A PRIMEIRA CREDENCIAL É O EMAIL
                var password = credentials.LastOrDefault(); // A ÚLTIMA CREDENCIAL É A SENHA

                var user = await _userService.GetUser(new IdentityUser() { Email = email, PasswordHash = password });
                if (!user.Succeeded)
                    throw new UnauthorizedAccessException("Credenciais inválidas!");
            }
            catch (Exception e)
            {
                return AuthenticateResult.Fail($"Autenticação falhou: {e.Message}");
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, email)
            };
            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}
