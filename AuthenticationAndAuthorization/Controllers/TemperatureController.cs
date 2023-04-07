using AuthenticationAndAuthorization.Repostitary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAndAuthorization.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TemperatureController : Controller
    {
        private readonly ITemperatureRepositary _Temp;
        public TemperatureController(ITemperatureRepositary _temp)
        {
            this._Temp = _temp;
        }

        [HttpGet]
        [Route("GettempertureCountries")]
        [Authorize(Roles =("arrancars"))]
        
        public async Task< IActionResult> GetTemperatureC()
        {
            try
            {
                var temperature = await _Temp.GetTemperatureCountries();
                return Ok(temperature);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            
            }
          
        }
        [HttpGet]
        [Route("GettempertureState")]
        [Authorize(Roles = ("hokage"))]
        public async Task<IActionResult> GetTemperatureS()
        {
            var temperature = await _Temp.GetTemperatureStates();
            return Ok(temperature);
        }
    }
}
