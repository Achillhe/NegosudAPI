using BusinessLayer.Services.CollaborateurService;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaborateurController : ControllerBase
    {
        private readonly ICollaborateurService _collaborateurService;

        public CollaborateurController(ICollaborateurService collaborateurService)
        {
            _collaborateurService = collaborateurService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Collaborateur>>> GetAllCollaboraters()
        {
            return await _collaborateurService.GetAllCollaboraters();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Collaborateur>> GetSingleCollaborater(int Id)
        {
            var result = await _collaborateurService.GetSingleCollaborater(Id);
            if (result is null)
                return NotFound("Collaborateur non trouvé.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Collaborateur>>> AddCollaborater([FromBody] Collaborateur collaborateur)
        {
            var result = await _collaborateurService.AddCollaborater(collaborateur);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Collaborateur>>> UpdateCollaborater(int Id, Collaborateur request)
        {
            var result = await _collaborateurService.UpdateCollaborater(Id, request);
            if (result is null)
                return NotFound("Collaborateur non trouvé.");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Collaborateur>>> DeleteCollaborater(int Id)
        {
            var result = await _collaborateurService.DeleteCollaborater(Id);
            if (result is null)
                return NotFound("Collaborateur non trouvé.");

            return Ok(result);
        }
    }
}
