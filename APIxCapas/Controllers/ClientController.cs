using APIxCapas.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIxCapas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clients;

        public ClientController(IClientService clients)
        {

            _clients = clients;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var products = await _genericRepository.GetAll();
            //  products = 
            return Ok(await _clients.GetAll());
        }


        [HttpGet("id")]
        public async Task<IActionResult> GetByID([FromQuery] int id, [FromQuery] string address)
        {
            var clients = await _clients.GetAll();
            clients = clients.Where(b => b.ID == id && b.Address == address).ToList();

            return Ok(clients);
        }
    }
}
