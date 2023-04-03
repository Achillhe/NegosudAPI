using BusinessLayer.Services.SortService;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortController : ControllerBase
    {
        private readonly ISortService _sortService;

        public SortController(ISortService sortService)
        {
            _sortService = sortService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Sort>>> GetAllSorts()
        {
            return await _sortService.GetAllSorts();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Sort>> GetSingleSort(int Id)
        {
            var result = await _sortService.GetSingleSort(Id);
            if (result is null)
                return NotFound("Type non trouvé.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Sort>>> AddSort([FromBody] Sort sort)
        {
            var result = await _sortService.AddSort(sort);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Sort>>> UpdateSort(int Id, Sort request)
        {
            var result = await _sortService.UpdateSort(Id, request);
            if (result is null)
                return NotFound("Type non trouvé.");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Sort>>> DeleteSort(int Id)
        {
            var result = await _sortService.DeleteSort(Id);
            if (result is null)
                return NotFound("Type non trouvé.");

            return Ok(result);
        }
    }
}
