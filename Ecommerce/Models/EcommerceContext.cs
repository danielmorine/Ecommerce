﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ecommerce.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext()  : base("DefaultConnection")
        {
            
        }

        //DESABILITAR CASCATAS

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


        public System.Data.Entity.DbSet<Ecommerce.Models.Departments> Departments { get; set; }

        public System.Data.Entity.DbSet<Ecommerce.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<Ecommerce.Models.Company> Companies { get; set; }
    }
}