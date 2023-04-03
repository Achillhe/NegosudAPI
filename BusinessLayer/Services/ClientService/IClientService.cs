using DataAccessLayer.Models;

namespace BusinessLayer.Services.ClientService
{
    public interface IClientService
    {
        Task<List<Client>> GetAllClients();
        Task<Client>? GetSingleClient(int Id);
        Task<List<Client>> AddClient(Client client);
        Task<List<Client>?> UpdateClient(int Id, Client request);
        Task<List<Client>?> DeleteClient(int Id);
    }
}
