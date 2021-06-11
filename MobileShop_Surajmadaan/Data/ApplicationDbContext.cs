using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MobileShop_Surajmadaan.BussinessLayer;

namespace MobileShop_Surajmadaan.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Model> Models { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
