﻿using ErpProject.DTO;
using System.Security.Principal;

namespace WebApplication5.Helpers
{
    public interface IAuthenticationHelper
    {
        public bool AuthenticatePrincipal(UserLoginDto userLogin);

        public string GenerateJwt(UserLoginDto userLogin);
    }
}
