using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.API
{
    public class AuthorizeRolesAttribute : AuthorizsAttribute
    {
        public AuthorizeRoleAttribute(params RoleType[] r)
        {
            var roles = r.Select(x => Enum.GetName(typeof(RoleType), x);
            Roles = string.Join(",", roles);
        }
    }
}
