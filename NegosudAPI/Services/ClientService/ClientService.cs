using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

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
            if (await _context.Clients.AnyAsync(c => c.Email == client.Email))
            {
                throw new Exception("Cet e-mail est déjà enregistré.");
            }
            if (client.MotDePasse != client.ConfirmationMotDePasse)
            {
                throw new Exception("Les mots de passe ne correspondent pas.");
            }
            client.MotDePasse = BCrypt.Net.BCrypt.HashPassword(client.MotDePasse);
            client.ConfirmationMotDePasse = BCrypt.Net.BCrypt.HashPassword(client.ConfirmationMotDePasse);
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

            client.Nom = request.Nom;
            client.Prenom = request.Prenom;
            client.Tel = request.Tel;
            client.Email = request.Email;
            client.MotDePasse = request.MotDePasse;
            client.ConfirmationMotDePasse = request.ConfirmationMotDePasse;

            await _context.SaveChangesAsync();

            return await _context.Clients.ToListAsync();
        }
    }
}
