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
        private readonly GoPillBoxDbContext _dbContext;
        private readonly ILoggingService _logger;

        AuthenticationController(GoPillBoxDbContext dbContext, ILoggingService logger) 
        {
            this._dbContext = dbContext;
            this._logger = logger;
        }

        // POST: api/<AuthenticationController>/Authenticate/
        [HttpPost]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(401)]
        public IActionResult Authenticate([FromBody] UserView userCredentials)
        {

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
