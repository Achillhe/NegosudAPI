using BusinessLayer.Services.ClientService;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Client>>> GetAllClients()
        {
            return await _clientService.GetAllClients();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Client>> GetSingleClient(int Id)
        {
            var result = await _clientService.GetSingleClient(Id);
            if (result is null)
                return NotFound("Client non trouvé.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Client>>> AddClient([FromBody] Client client)
        {
            var result = await _clientService.AddClient(client);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Client>>> UpdateClient(int Id, Client request)
        {
            var result = await _clientService.UpdateClient(Id, request);
            if (result is null)
                return NotFound("Client non trouvé.");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Client>>> DeleteClient(int Id)
        {
            var result = await _clientService.DeleteClient(Id);
            if (result is null)
                return NotFound("Client non trouvé.");

            return Ok(result);
        }
    }
}
