using APIxCapas.Interface;
using APIxCapas.Models;
using APIxCapas.Repository;
using APIxCapas.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIxCapas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {        
        private readonly IProductService _products;        

        public ProductController(IProductService product)
        {
            
           _products = product;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {            
            //var products = await _genericRepository.GetAll();
              //  products = 
            return Ok(await _products.GetAll());
        }

               
          
        [HttpGet("id")]
        public async Task<IActionResult> GetByID([FromQuery] int id)
        {
            return Ok(await _products.GetSingle(id));
        }  




    }
}
