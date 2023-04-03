using DataAccessLayer.Models;

namespace BusinessLayer.Services.ProduitService
{
    public interface IProduitService
    {
        Task<List<Produit>> GetAllProducts();
        Task<Produit>? GetSingleProduct(int Id);
        Task<List<Produit>> AddProduct(Produit produit);
        Task<List<Produit>?> UpdateProduct(int Id, Produit request);
        Task<List<Produit>?> DeleteProduct(int Id);
    }
}
