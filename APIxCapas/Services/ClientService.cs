using APIxCapas.Interface;
using APIxCapas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIxCapas.Services
{
    public class ClientService : IClientService
    {
        private readonly ICommerceRepository<Client> _clients;

        public ClientService(ICommerceRepository<Client> clients)
        {
            _clients = clients;
        }


        public async Task<List<Client>> GetAll()
        {
            var products = await _clients.GetAll();
            return products.ToList();
        }

        public async Task<Client> GetSingle(int id)
        {
            var product = await _clients.Get(id);
            return product;
        }


    }
}
