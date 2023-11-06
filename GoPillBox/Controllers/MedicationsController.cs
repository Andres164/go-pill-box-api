using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GoPillBox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationsController : ControllerBase
    {
        private readonly IMedicationsRepository _medicationsRepository;

        public MedicationsController(IMedicationsRepository medicationsRepository)
        {
            this._medicationsRepository = medicationsRepository;
        }

        // GET: api/<MedicationsController>
        [HttpGet]
        [ProducesResponseType(typeof(List<Medication>), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get()
        {
            List<Medication> medications = await this._medicationsRepository.ReadAllAsync();
            return Ok(medications);
        }

        // GET api/<MedicationsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Medication), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get(int id)
        {
            Medication? medication = await this._medicationsRepository.ReadAsync(id);
            if (medication == null)
                return NotFound();
            return Ok(medication);
        }

        // POST api/<MedicationsController>
        [HttpPost]
        [ProducesResponseType(typeof(Medication), 200)]
        public async Task<IActionResult> Post([FromBody] MedicationView newMedication)
        {
            Medication? createdMedication = await this._medicationsRepository.CreateAsync(newMedication);
            if (createdMedication == null)
                return StatusCode(500, "Error creating medication");
            return Ok(createdMedication);
        }

        // PUT api/<MedicationsController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Medication), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Put(int id, [FromBody] MedicationView modifiedMedication)
        {
            Medication? updatedMedication = await this._medicationsRepository.UpdateAsync(id, modifiedMedication);
            if (updatedMedication == null)
                return NotFound();
            return Ok(updatedMedication);
        }

        // DELETE api/<MedicationsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Medication), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            Medication? deletedMedication = await this._medicationsRepository.DeleteAsync(id);
            if (deletedMedication == null)
                return NotFound();
            return Ok(deletedMedication);
        }
    }
}
