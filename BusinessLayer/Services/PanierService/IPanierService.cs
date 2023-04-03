using DataAccessLayer.Models;

namespace BusinessLayer.Services.PanierService
{
    public interface IPanierService
    {
        Task<Panier> AddProduit(int clientId, int produitId, int quantite);
    }
}
