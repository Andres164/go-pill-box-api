using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GoPillBox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            this._usersRepository = usersRepository;
        }

        // GET: api/<UsersController>
        [HttpGet]
        [ProducesResponseType(typeof(List<User>), 200)]
        public async Task<IActionResult> Get()
        {
            List<User> users = await this._usersRepository.ReadAllAsync();
            return Ok(users);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get(int id)
        {
            User? user = await this._usersRepository.ReadAsync(id);
            if(user == null)
                return NotFound();
            return Ok(user);
        }

        // POST api/<UsersController>
        [HttpPost]
        [ProducesResponseType(typeof(User), 200)]
        public async Task<IActionResult> Post([FromBody] UserView newUser)
        {
            User? createdUser = await this._usersRepository.CreateAsync(newUser);
            if (createdUser == null)
                return StatusCode(500, "Error creating new user");
            return Ok(createdUser);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Put(int id, [FromBody] UserView modifiedUser)
        {
            User? updatedUser = await this._usersRepository.UpdateAsync(id, modifiedUser);
            if (updatedUser == null)
                return NotFound();
            return Ok(updatedUser);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            User? deletedUser = await this._usersRepository.DeleteAsync(id);
            if(deletedUser == null)
                return NotFound();
            return Ok(deletedUser);
        }
    }
}
