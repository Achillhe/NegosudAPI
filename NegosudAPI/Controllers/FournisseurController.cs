using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Services.ClientService;
using NegosudAPI.Services.FournisseurService;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FournisseurController : ControllerBase
    {
        private readonly IFournisseurService _fournisseurService;

        public FournisseurController(IFournisseurService fournisseurService)
        {
            _fournisseurService = fournisseurService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Fournisseur>>> GetAllProviders()
        {
            return await _fournisseurService.GetAllProviders();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Fournisseur>> GetSingleProvider(int Id)
        {
            var result = await _fournisseurService.GetSingleProvider(Id);
            if (result is null)
                return NotFound("Fournisseur non trouvé.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Fournisseur>>> AddProvider([FromBody] Fournisseur fournisseur)
        {
            var result = await _fournisseurService.AddProvider(fournisseur);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Fournisseur>>> UpdateProvider(int Id, Fournisseur request)
        {
            var result = await _fournisseurService.UpdateProvider(Id, request);
            if (result is null)
                return NotFound("Fournisseur non trouvé.");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Fournisseur>>> DeleteProvider(int Id)
        {
            var result = await _fournisseurService.DeleteProvider(Id);
            if (result is null)
                return NotFound("Fournisseur non trouvé.");

            return Ok(result);
        }
    }
}
