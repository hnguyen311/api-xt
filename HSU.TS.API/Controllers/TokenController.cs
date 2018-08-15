using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.DirectoryServices;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HSU.TS.API.Data;
using HSU.TS.API.Data.Interfaces;
using HSU.TS.API.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace HSU.TS.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Token")]
    public class TokenController : Controller
    {
        private IConfiguration _config;
        private IUnitOfWork _uow;
        public static long ToUnixEpochDate(DateTime date) => new DateTimeOffset(date).ToUniversalTime().ToUnixTimeSeconds();
        public TokenController(IConfiguration config, IUnitOfWork uow)
        {
            this._config = config;
            this._uow = uow;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Generate([FromBody]LoginModel login)
        {
            IActionResult response = Unauthorized();
            var user = Authenticate(login);

            if (user != null)
            {
                var tokenString = BuildToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }

        private string BuildToken(UserModel user)
        {
            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.NameId, user.Id),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.FamilyName, user.FamilyName),
                new Claim(JwtRegisteredClaimNames.GivenName, user.GivenName),
                new Claim(ClaimTypes.Role, user.UserRole),
                new Claim(ClaimTypes.Expiration, DateTime.Now.AddMinutes(30).ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
               // new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(DateTime.Now).ToString(), ClaimValueTypes.Integer64)

                };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
              _config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
             // expires: DateTime.Now.AddMinutes(30),
             expires:  DateTime.UtcNow.Add(TimeSpan.FromMinutes(30)),
              signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        private UserModel Authenticate(LoginModel login)
        {
            UserModel user = null;
            if (ModelState.IsValid)
            {
                var tt =_uow.PS_HSU_THONGTIN_TS_Repository.IsAuthenticate(login.Username,login.Password);
                if (tt != null)
                {
                    user = new UserModel
                    {
                        Id = tt?.HSU_SOCMND,
                        FamilyName = tt?.HSU_HOVACHULOT_TS,
                        GivenName = tt?.HSU_TEN_TS,
                        Email = tt?.HSU_EMAIL,
                    };
                }
                else //Admin
                {
                    if (login.Username.Contains("."))
                    {
                        if (AuthenticateAD(login))
                        {
                            user = new UserModel
                            {
                                Id = login.Username,
                                FamilyName = login.Username,
                                GivenName = login.Username,
                                Email = $"{login.Username}@hoasen.edu.vn",
                                UserRole = Para.USERROLE.HSU_TUYENSINH.ToString()
                            };
                        }
                    }
                }

            }
            return user;
        }
        private bool AuthenticateAD(LoginModel login)
        {
            try
            {
                var adServer = _config["ADServer:default"];
                DirectoryEntry entry = new DirectoryEntry($"LDAP://{adServer}", login.Username, login.Password);
                object nativeObject = entry.NativeObject;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public class LoginModel
        {
            [Required]
            public string Username { get; set; }
            [Required]
            public string Password { get; set; }
        }

        private class UserModel
        {
            public string Id { get; set; }
            public string FamilyName { get; set; }
            public string GivenName { get; set; }
            public string FullName
            {
                get
                {
                    return $"{FamilyName} {GivenName}";
                }
            }
            public string Email { get; set; }
            public string UserRole { get; set; } = Para.USERROLE.HSU_STUDENT.ToString();

        }


  
    }
}