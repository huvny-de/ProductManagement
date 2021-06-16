using Microsoft.EntityFrameworkCore;
using UpLoadPhotoMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpLoadPhotoMVC.DbContexts
{
    public class DbUpLoadPhotoMVC : DbContext
    {

        public DbUpLoadPhotoMVC(DbContextOptions<DbUpLoadPhotoMVC> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        // Seed Data
       
    }
}
