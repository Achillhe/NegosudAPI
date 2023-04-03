using DataAccessLayer.Models;

namespace BusinessLayer.Services.FournisseurService;

public interface IFournisseurService
{
    Task<List<Fournisseur>> GetAllProviders();
    Task<Fournisseur>? GetSingleProvider(int Id);
    Task<List<Fournisseur>> AddProvider(Fournisseur fournisseur);
    Task<List<Fournisseur>?> UpdateProvider(int Id, Fournisseur request);
    Task<List<Fournisseur>?> DeleteProvider(int Id);
}
