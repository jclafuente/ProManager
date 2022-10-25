using ProManager.API.Auth;
using ProManager.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProManager.API.Controllers
{
    /// <summary>
    /// API que permite generar el token de acceso mediante autenticación
    /// </summary>
    [AllowAnonymous]
    public class AccountController : ApiController
    {

        /// <summary>
        /// Metodo encargado de realizar la autenticacion 
        /// </summary>
        /// <param name="loginDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult Login(LoginDTO loginDTO)
        {
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            bool isCredentialValid = (loginDTO.Password == "123456");

            if (isCredentialValid)
            {
                var token = TokenGenerator.GenerateTokenJwt(loginDTO.Username);
                return Ok(token);
            }
            else
            { 
                return Unauthorized(); // status code 401
            }
        }
    }
}
