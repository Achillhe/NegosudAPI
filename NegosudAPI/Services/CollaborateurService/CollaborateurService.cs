using NegosudAPI.Models;

namespace NegosudAPI.Services.CollaborateurService
{
    public class CollaborateurService : ICollaborateurService
    {
        private readonly DataContext _context;

        public CollaborateurService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Collaborateur>> AddCollaborater(Collaborateur collaborateur)
        {
            _context.Collaborateurs.Add(collaborateur);
            await _context.SaveChangesAsync();
            return await _context.Collaborateurs.ToListAsync();
        }

        public async Task<List<Collaborateur>?> DeleteCollaborater(int Id)
        {
            var collaborateur = await _context.Collaborateurs.FindAsync(Id); ;
            if (collaborateur is null)
                return null;

            _context.Collaborateurs.Remove(collaborateur);
            await _context.SaveChangesAsync();
            return await _context.Collaborateurs.ToListAsync();
        }

        public async Task<List<Collaborateur>> GetAllCollaboraters()
        {
            var collaborateurs = await _context.Collaborateurs.ToListAsync();
            return collaborateurs;
        }

        public async Task<Collaborateur?> GetSingleCollaborater(int Id)
        {
            var collaborateur = await _context.Collaborateurs.FindAsync(Id);
            if (collaborateur is null)
                return null;

            return collaborateur;
        }

        public async Task<List<Collaborateur>?> UpdateCollaborater(int Id, Collaborateur request)
        {
            var collaborateur = await _context.Collaborateurs.FindAsync(Id);
            if (collaborateur is null)
                return null;

            collaborateur.Nom = request.Nom;
            collaborateur.Prenom = request.Prenom;
            collaborateur.Email = request.Email;
            collaborateur.Password = request.Password;
            collaborateur.Role = request.Role;

            await _context.SaveChangesAsync();

            return await _context.Collaborateurs.ToListAsync();
        }
    }
}
