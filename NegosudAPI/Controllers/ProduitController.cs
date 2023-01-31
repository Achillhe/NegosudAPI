using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Services.ClientService;
using NegosudAPI.Services.ProduitService;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly IProduitService _produitService;

        public ProduitController(IProduitService produitService)
        {
            _produitService = produitService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Produit>>> GetAllProducts()
        {
            return await _produitService.GetAllProducts();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Produit>> GetSingleProduct(int Id)
        {
            var result = await _produitService.GetSingleProduct(Id);
            if (result is null)
                return NotFound("Produit non trouvé.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Produit>>> AddProduct([FromBody] Produit produit)
        {
            var result = await _produitService.AddProduct(produit);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Produit>>> UpdateProduct(int Id, Produit request)
        {
            var result = await _produitService.UpdateProduct(Id, request);
            if (result is null)
                return NotFound("Produit non trouvé.");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Produit>>> DeleteProduct(int Id)
        {
            var result = await _produitService.DeleteProduct(Id);
            if (result is null)
                return NotFound("Produit non trouvé.");

            return Ok(result);
        }
    }
}
