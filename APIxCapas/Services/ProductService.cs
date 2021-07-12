using APIxCapas.Interface;
using APIxCapas.Models;
using APIxCapas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIxCapas.Services
{
    public class ProductService : IProductService
    {
        private readonly ICommerceRepository<Product> _products;        

        public ProductService(ICommerceRepository<Product> product)
        {
                 _products   = product;              
        }


        public async Task<List<Product>> GetAll()
        {
            var products = await _products.GetAll();
            return products.ToList();
        }

        public async Task<Product> GetSingle(int id)
        {
            var product = await _products.Get(id);
            return product;
        }
    }
}
