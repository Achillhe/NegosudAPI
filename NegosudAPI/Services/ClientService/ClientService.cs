namespace NegosudAPI.Services.ClientService
{
    public class ClientService : IClientService
    {
        private readonly DataContext _context;

        public ClientService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Client>> AddClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return await _context.Clients.ToListAsync();
        }

        public async Task<List<Client>?> DeleteClient(int Id)
        {
            var client = await _context.Clients.FindAsync(Id); ;
            if (client is null)
                return null;

            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return await _context.Clients.ToListAsync();
        }

        public async Task<List<Client>> GetAllClients()
        {
            var clients = await _context.Clients.ToListAsync();
            return clients;
        }

        public async Task<Client?> GetSingleClient(int Id)
        {
            var client = await _context.Clients.FindAsync(Id);
            if (client is null)
                return null;

            return client;
        }

        public async Task<List<Client>?> UpdateClient(int Id, Client request)
        {
            var client = await _context.Clients.FindAsync(Id);
            if (client is null)
                return null;

            client.nom = request.nom;
            client.prenom = request.prenom;
            client.tel = request.tel;
            client.email = request.email;
            client.password = request.password;

            await _context.SaveChangesAsync();

            return await _context.Clients.ToListAsync();
        }
    }
}
