using System;
using SWLOR.Web.Constants;

namespace SWLOR.Web.Attributes
{
    public class RoleRequiredAttribute: Attribute
    {
        public RoleType[] RolesRequired { get; }

        public RoleRequiredAttribute(params RoleType[] roles)
        {
            RolesRequired = roles;
        }
    }
}
