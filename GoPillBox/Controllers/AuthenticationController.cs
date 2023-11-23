using GoPillBox.Database;
using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Services;
using Microsoft.AspNetCore.Mvc;

namespace GoPillBox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserAuthenticationService _userAuthenticationService;

        public AuthenticationController(UserAuthenticationService userAuthenticationService) 
        {
            this._userAuthenticationService = userAuthenticationService;
        }

        // POST: api/<AuthenticationController>/Authenticate/
        [HttpPost]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Authenticate([FromBody] UserView userCredentials)
        {
            bool areCredentialsValid = await this._userAuthenticationService.AreCredentialsValid(userCredentials);
            if (!areCredentialsValid)
                return Unauthorized();
            return Ok(userCredentials);
        }

        // GET: api/<AuthenticationController>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        public IActionResult CheckIfAuthenticated()
        {
            return Ok();
        }
    }
}
