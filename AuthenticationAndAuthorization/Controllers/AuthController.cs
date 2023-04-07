using AuthenticationAndAuthorization.Repostitary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAndAuthorization.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserReposiatry _user;
        private readonly ITokenHandlers token;

        public AuthController(IUserReposiatry _user,ITokenHandlers _token)
        {
            this._user = _user;
            token = _token;
        }
        [HttpPost]
        public async Task<IActionResult> LoginAsync(Models.DTO.LoginRequestDto loginrequest)
        {
            var user =await _user.Authenticate(loginrequest.username,loginrequest.password);
            if(user!=null)
            {
                // Generate a jwt token
               var _token= await  token.CreateTokenAsync(user);
                return Ok(_token);
                
            }
            return BadRequest("Username Or Password Is Incorrect");
        }
    }
}
