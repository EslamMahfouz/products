﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Products.EDM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProductsEntities : DbContext
    {
        public ProductsEntities()
            : base("name=ProductsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<PurchasePayment> PurchasePayments { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<SalePayment> SalePayments { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
