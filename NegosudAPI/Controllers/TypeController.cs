using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Services.TypeService;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly ITypeService _typeService;

        public TypeController(ITypeService typeService)
        {
            _typeService = typeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Models.Type>>> GetAllTypes()
        {
            return await _typeService.GetAllTypes();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Models.Type>> GetSingleType(int Id)
        {
            var result = await _typeService.GetSingleType(Id);
            if (result is null)
                return NotFound("Type non trouvé.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Models.Type>>> AddType([FromBody] Models.Type type)
        {
            var result = await _typeService.AddType(type);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Models.Type>>> UpdateType(int Id, Models.Type request)
        {
            var result = await _typeService.UpdateType(Id, request);
            if (result is null)
                return NotFound("Type non trouvé.");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Models.Type>>> DeleteType(int Id)
        {
            var result = await _typeService.DeleteType(Id);
            if (result is null)
                return NotFound("Type non trouvé.");

            return Ok(result);
        }
    }
}
