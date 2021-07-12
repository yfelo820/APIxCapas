using APIxCapas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIxCapas.Interface
{
    public interface IProductService
    {
        Task<Product> GetSingle(int id);
        Task<List<Product>> GetAll();

    }
}
