using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Extensions
{
    public static class ControllerExtensions
    {
        public static string GetUserId(this Controller controller) =>
                    controller.HttpContext.User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;

        public static string GetCurrentUserRole(this Controller controller) =>
            controller.HttpContext.User.Claims.First(c => c.Type == ClaimTypes.Role).Value;

        public static bool CurrentUserIsAdmin(this Controller controller)
        {
            var role =   controller.HttpContext.User.Claims.First(c => c.Type == ClaimTypes.Role).Value;
            return role.Equals(Para.USERROLE.HSU_TUYENSINH.ToString());
        }
           
      
    }
}
