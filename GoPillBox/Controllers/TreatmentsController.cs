using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GoPillBox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentsController : ControllerBase
    {
        private readonly ITreatmentsRepository _treatmentsRepository;

        public TreatmentsController(ITreatmentsRepository treatmentsRepository)
        {
            this._treatmentsRepository = treatmentsRepository;
        }

        // GET: api/<TreatmentsController>
        [HttpGet]
        [ProducesResponseType(typeof(List<Treatment>), 200)]
        public async Task<IActionResult> Get()
        {
            List<Treatment> treatments = await this._treatmentsRepository.ReadAllAsync();
            return Ok(treatments);
        }

        // GET api/<TreatmentsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Treatment), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get(int id)
        {
            Treatment? treatment = await this._treatmentsRepository.ReadAsync(id);
            if (treatment == null)
                return NotFound();
            return Ok(treatment);
        }

        // POST api/<TreatmentsController>
        [HttpPost]
        [ProducesResponseType(typeof(Treatment), 200)]
        public async Task<IActionResult> Post([FromBody] TreatmentView newTreatment)
        {
            Treatment? createdTreatment = await this._treatmentsRepository.CreateAsync(newTreatment);
            if(createdTreatment == null)
                return NotFound();
            return Ok(createdTreatment);
        }

        // PUT api/<TreatmentsController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Treatment), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Put(int id, [FromBody] TreatmentView modifiedTreatment)
        {
            Treatment? updatedTreatment = await this._treatmentsRepository.UpdateAsync(id, modifiedTreatment);
            if (updatedTreatment == null)
                return NotFound();
            return Ok(updatedTreatment);
        }

        // DELETE api/<TreatmentsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Treatment), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            Treatment? deletedTreatment = await this._treatmentsRepository.DeleteAsync(id);
            if (deletedTreatment == null)
                return NotFound();
            return Ok(deletedTreatment);
        }
    }
}
