using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ToDoCRUDRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
      private IConfiguration _Configuration;

      public AuthController(IConfiguration configuration)
      {
        _Configuration = configuration;
      }

      [HttpPost("token")]
      public ActionResult GetToken()
      {
        //symmetric security key
        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Configuration.GetValue<string>("SecurityKey")));

        //signing credentials
        var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

        //create token
        var token = new JwtSecurityToken(
          issuer: "ToDo.security",
          audience: "readers",
          expires: DateTime.Now.AddHours(1),
          signingCredentials: signingCredentials
        );

        return Ok(new JwtSecurityTokenHandler().WriteToken(token));
      }
    }
}