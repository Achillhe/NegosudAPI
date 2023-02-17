using Microsoft.AspNetCore.Mvc;

namespace NegosudAPI.Services.FournisseurService
{
    public class FournisseurService : IFournisseurService
    {
        private readonly DataContext _context;

        public FournisseurService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Fournisseur>> AddProvider(Fournisseur fournisseur)
        {
            _context.Fournisseurs.Add(fournisseur);
            await _context.SaveChangesAsync();
            return await _context.Fournisseurs.ToListAsync();
        }

        public async Task<List<Fournisseur>?> DeleteProvider(int Id)
        {
            var fournisseur = await _context.Fournisseurs.FindAsync(Id); ;
            if (fournisseur is null)
                return null;

            _context.Fournisseurs.Remove(fournisseur);
            await _context.SaveChangesAsync();
            return await _context.Fournisseurs.ToListAsync();
        }

        public async Task<List<Fournisseur>> GetAllProviders()
        {
            var fournisseurs = await _context.Fournisseurs.ToListAsync();
            return fournisseurs;
        }

        public async Task<Fournisseur?> GetSingleProvider(int Id)
        {
            var fournisseur = await _context.Fournisseurs.FindAsync(Id);
            if (fournisseur is null)
                return null;

            return fournisseur;
        }

        public async Task<List<Fournisseur>?> UpdateProvider(int Id, Fournisseur request)
        {
            var fournisseur = await _context.Fournisseurs.FindAsync(Id);
            if (fournisseur is null)
                return null;

            fournisseur.Nom = request.Nom;
            fournisseur.Email = request.Email;
            fournisseur.CodePostal = request.CodePostal;
            fournisseur.Pays = request.Pays;
            fournisseur.Tel = request.Tel;
            fournisseur.Siret = request.Siret;

            await _context.SaveChangesAsync();

            return await _context.Fournisseurs.ToListAsync();
        }
    }
}
