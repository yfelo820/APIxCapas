using APIxCapas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIxCapas.DB
{
    public class CommerceContext : DbContext
    {
        public CommerceContext(DbContextOptions<CommerceContext> options):base(options)
        {

        }

        public DbSet<Client>  Clients  { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order>   Orders   { get; set; }

    }
}
