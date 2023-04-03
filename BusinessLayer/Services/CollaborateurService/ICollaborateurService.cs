using DataAccessLayer.Models;

namespace BusinessLayer.Services.CollaborateurService
{
    public interface ICollaborateurService
    {
        Task<List<Collaborateur>> GetAllCollaboraters();
        Task<Collaborateur>? GetSingleCollaborater(int Id);
        Task<List<Collaborateur>> AddCollaborater(Collaborateur collaborateur);
        Task<List<Collaborateur>?> UpdateCollaborater(int Id, Collaborateur request);
        Task<List<Collaborateur>?> DeleteCollaborater(int Id);
    }
}
