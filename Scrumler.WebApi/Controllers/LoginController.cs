using Scrumler.Bll.Abstract;
using Scrumler.Entity.Base;
using Scrumler.Entity.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Scrumler.WebApi.Controllers
{
    public class LoginController : ControllerBase
    {
        #region Variables

        private readonly IConfiguration _config;
        private readonly IKullaniciBL _kullaniciBL;

        #endregion Variables

        #region Constructor

        public LoginController(IConfiguration configuration, IKullaniciBL kullaniciBL)
        {
            _kullaniciBL = kullaniciBL;
            _config = configuration;
        }

        #endregion Constructor

        #region BusinessSection

        [HttpPost("Login")]
        [AllowAnonymous]
        public BllResponse Login([FromBody]DtoLogin loginModel)
        {
            try
            {
                var StatusCode = StatusCodes.Status204NoContent;
                var ResultMessage = "";
                object ResultData = "";

                var user = _kullaniciBL.Login(loginModel);

                if (user != null && user.KullaniciBilgileri != null)
                {
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, user.KullaniciBilgileri.KullaniciKodu.ToString()),
                        new Claim(JwtRegisteredClaimNames.Jti, user.KullaniciBilgileri.KullaniciID.ToString()),
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, "Token");

                    var claimList = new List<Claim>();
                    if (user.KullaniciYetkileri != null)
                    {
                        foreach (var item in user.KullaniciYetkileri)
                        {
                            claimList.Add(new Claim("roles", item.YetkiID.ToString()));
                        }
                    }

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                    _config["Tokens:Issuer"],
                    claimsIdentity.Claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds);

                    var tokenHandler = new { token = new JwtSecurityTokenHandler().WriteToken(token) };

                    var result = new DtoToken
                    {
                        Token = tokenHandler.token,
                        UserDto = user
                    };

                    ResultData = result;
                    ResultMessage = "Token created successfully";
                    StatusCode = StatusCodes.Status200OK;
                }
                else
                {
                    ResultData = null;
                    ResultMessage = "No such user!";
                    StatusCode = StatusCodes.Status406NotAcceptable;
                }

                return new BllResponse
                {
                    Data = ResultData,
                    Message = ResultMessage,
                    StatusCode = StatusCode
                };
            }
            catch (Exception ex)
            {
                return new BllResponse
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        #endregion BusinessSection
    }
}