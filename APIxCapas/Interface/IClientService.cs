using APIxCapas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIxCapas.Interface
{
    public interface IClientService
    {
        Task<Client> GetSingle(int id);
        Task<List<Client>> GetAll();
    }
}
