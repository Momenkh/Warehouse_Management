using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Warehouse_Management
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Clients_Product> Clients_Product { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Suppliers_Product> Suppliers_Product { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WH_ProductsList> WH_ProductsList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Client_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_tele)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_mob)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_fax)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Clients_Product)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clients_Product>()
                .Property(e => e.Exit_Permit)
                .IsUnicode(false);

            modelBuilder.Entity<Clients_Product>()
                .Property(e => e.Client_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Clients_Product>()
                .Property(e => e.WH_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Clients_Product>()
                .Property(e => e.Product_Code_exit)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Units)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.WH_ProductsList)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_tele)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_mob)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_fax)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_email)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Suppliers_Product)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Suppliers_Product>()
                .Property(e => e.Entry_Permit)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers_Product>()
                .Property(e => e.Supplier_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers_Product>()
                .Property(e => e.WH_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers_Product>()
                .Property(e => e.Product_Code_entry)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.WH_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.WH_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.WH_Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Clients_Product)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Suppliers_Product)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.WH_ProductsList)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WH_ProductsList>()
                .Property(e => e.Product_Code)
                .IsUnicode(false);

            modelBuilder.Entity<WH_ProductsList>()
                .Property(e => e.WH_Name)
                .IsUnicode(false);
        }
    }
}
