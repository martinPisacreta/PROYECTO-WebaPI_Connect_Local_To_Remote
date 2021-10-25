using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Proyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {

        private readonly IConfiguration configuration;


        public class Login
        {
            public string email { get; set; }
            public string password { get; set; }
        }

        public class Usuario
        {

            public int IdUsuario { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Email { get; set; }
        }

        public AccountsController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // POST: api/Accounts/authenticate
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> authenticate(Login login)
        {

            //este usuario no existe en la base de datos , es un usuario para poder acceder a los controllers
            //todos los controllers de la web api tienen autenticacion
            if (login.email == "encendido_alsina_consulta@hotmail.com" && login.password == "encendidoAlsina123456ABC")
            {


                var usuario = new Usuario()
                {
                    // Id del Usuario en el Sistema de Información (BD)
                    IdUsuario = 12345678,
                    Nombre = "Encendido",
                    Apellido = "Alsina",
                    Email = "encendido_alsina_consulta@hotmail.com",
                };

                if (usuario != null)
                {
                    return Ok(new { token = GenerarTokenJWT(usuario) });
                }
                else
                {
                    return Unauthorized();
                }
            }
            else
            {
                return Unauthorized();
            }
        }

        // GENERAMOS EL TOKEN CON LA INFORMACIÓN DEL USUARIO
        private string GenerarTokenJWT(Usuario Usuario)
        {
            // CREAMOS EL HEADER //
            var _symmetricSecurityKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(configuration["Jwt:Key"])
                );
            var _signingCredentials = new SigningCredentials(
                    _symmetricSecurityKey, SecurityAlgorithms.HmacSha256
                );
            var _Header = new JwtHeader(_signingCredentials);

            // CREAMOS LOS CLAIMS //
            var _Claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, Usuario.IdUsuario.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim("Nombre", Usuario.Nombre),
                new Claim("Apellido", Usuario.Apellido),
                new Claim("Email", Usuario.Email)
            };

            // CREAMOS EL PAYLOAD //
            var _Payload = new JwtPayload(
                    issuer: configuration["Jwt:Issuer"],
                    audience: configuration["Jwt:Audience"],
                    claims: _Claims,
                    notBefore: DateTime.UtcNow,
                    // Exipra a la 24 horas.
                    expires: DateTime.UtcNow.AddHours(24)
                );

            // GENERAMOS EL TOKEN //
            var _Token = new JwtSecurityToken(
                    _Header,
                    _Payload
                );

            return new JwtSecurityTokenHandler().WriteToken(_Token);
        }
    }
}
