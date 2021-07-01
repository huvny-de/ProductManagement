using DataServiceAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataServiceAPI.Dbcontexts
{
    public class DbCustomer : DbContext
    {
        public DbCustomer(DbContextOptions<DbCustomer> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

    }
}