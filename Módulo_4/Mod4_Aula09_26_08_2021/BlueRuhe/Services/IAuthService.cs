using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueRuhe.Services
{
    public interface IAuthService
    {
        public Task<SignInResult> GetUser(IdentityUser identityUser);
        public Task<IdentityResult> Create(IdentityUser identityUser);
    }
}
