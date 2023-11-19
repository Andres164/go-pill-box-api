using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GoPillBox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMedicationsController : ControllerBase
    {
        private readonly IUserMedicationsRepository _userMedicationsRepository;

        public UserMedicationsController(IUserMedicationsRepository userMedicationsRepository)
        {
            this._userMedicationsRepository = userMedicationsRepository;
        }

        // GET: api/<UserMedicationsController>
        [HttpGet]
        [ProducesResponseType(typeof(List<UserMedication>), 200)]
        public async Task<IActionResult> Get()
        {
            List<UserMedication> userMedications = await this._userMedicationsRepository.ReadAllAsync();
            return Ok(userMedications);
        }

        // GET api/<UserMedicationsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserMedication), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get(int id)
        {
            UserMedication? UserMedication = await this._userMedicationsRepository.ReadAsync(id);
            if (UserMedication == null)
                return NotFound();
            return Ok(UserMedication);
        }

        // POST api/<UserMedicationsController>
        [HttpPost]
        [ProducesResponseType(typeof(UserMedication), 200)]
        public async Task<IActionResult> Post([FromBody] UserMedicationView newUserMedication)
        {
            UserMedication? createdUserMedication = await this._userMedicationsRepository.CreateAsync(newUserMedication);
            if(createdUserMedication == null)
                return NotFound();
            return Ok(createdUserMedication);
        }

        // PUT api/<UserMedicationsController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UserMedication), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Put(int id, [FromBody] UserMedicationView modifiedUserMedications)
        {
            UserMedication? updatedUserMedications = await this._userMedicationsRepository.UpdateAsync(id, modifiedUserMedications);
            if (updatedUserMedications == null)
                return NotFound();
            return Ok(updatedUserMedications);
        }

        // DELETE api/<UserMedicationsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(UserMedication), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            UserMedication? deletedUserMedication = await this._userMedicationsRepository.DeleteAsync(id);
            if (deletedUserMedication == null)
                return NotFound();
            return Ok(deletedUserMedication);
        }
    }
}
