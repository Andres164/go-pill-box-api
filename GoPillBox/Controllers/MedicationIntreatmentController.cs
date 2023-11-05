using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoPillBox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationIntreatmentController : ControllerBase
    {
        private readonly IMedicationInTreatmentRepository _medicationInTreatmentRepo;

        public MedicationIntreatmentController(IMedicationInTreatmentRepository medicationInTreatmentRepo)
        {
            this._medicationInTreatmentRepo = medicationInTreatmentRepo;
        }

        // GET: api/<MedicationIntreatmentController>
        [HttpGet]
        [ProducesResponseType(typeof(List<MedicationInTreatment>), 200)]
        public async Task<IActionResult> Get()
        {
            List<MedicationInTreatment> medicationInTreatments = await this._medicationInTreatmentRepo.ReadAllAsync();
            return Ok(medicationInTreatments);
        }

        // GET api/<MedicationIntreatmentController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MedicationInTreatment), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get(int id)
        {
            MedicationInTreatment? medicationInTreatment = await this._medicationInTreatmentRepo.ReadAsync(id);
            if (medicationInTreatment == null)
                return NotFound();
            return Ok(medicationInTreatment);
        }

        // POST api/<MedicationIntreatmentController>
        [HttpPost]
        [ProducesResponseType(typeof(MedicationInTreatment), 200)]
        public async Task<IActionResult> Post([FromBody] MedicationInTreatmentRequest newMedicationIntreatment)
        {
            MedicationInTreatment? createdMedicationInTreatment = await this._medicationInTreatmentRepo.CreateAsync(newMedicationIntreatment);
            if(createdMedicationInTreatment == null)
                return NotFound();
            return Ok(createdMedicationInTreatment);
        }

        // PUT api/<MedicationIntreatmentController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(MedicationInTreatment), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Put(int id, [FromBody] MedicationInTreatmentRequest modifiedMedicationInTreatment)
        {
            MedicationInTreatment? updatedMedicationInTreatment = await this._medicationInTreatmentRepo.UpdateAsync(id, modifiedMedicationInTreatment);
            if (updatedMedicationInTreatment == null)
                return NotFound();
            return Ok(updatedMedicationInTreatment);
        }

        // DELETE api/<MedicationIntreatmentController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(MedicationInTreatment), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            MedicationInTreatment? deletedMedicationInTreatment = await this._medicationInTreatmentRepo.DeleteAsync(id);
            if (deletedMedicationInTreatment == null)
                return NotFound();
            return Ok(deletedMedicationInTreatment);
        }
    }
}
