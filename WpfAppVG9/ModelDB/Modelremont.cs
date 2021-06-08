using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WpfAppVG9.ModelDB
{
    public partial class Modelremont : DbContext
    {
        public Modelremont()
            : base("name=Modelremont")
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Компания> Компания { get; set; }
        public virtual DbSet<Покупатель> Покупатель { get; set; }
        public virtual DbSet<Ремонт> Ремонт { get; set; }
        public virtual DbSet<Товар> Товар { get; set; }
        public virtual DbSet<Филиал> Филиал { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.Users)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Компания>()
                .Property(e => e.Fax)
                .IsFixedLength();

            modelBuilder.Entity<Компания>()
                .Property(e => e.PhoneCompany)
                .IsFixedLength();

            modelBuilder.Entity<Компания>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Компания>()
                .Property(e => e.Web)
                .IsFixedLength();

            modelBuilder.Entity<Покупатель>()
                .Property(e => e.Customer)
                .IsFixedLength();

            modelBuilder.Entity<Покупатель>()
                .Property(e => e.AddressCust)
                .IsFixedLength();

            modelBuilder.Entity<Ремонт>()
                .Property(e => e.Fax)
                .IsFixedLength();

            modelBuilder.Entity<Ремонт>()
                .Property(e => e.GoodsID)
                .IsFixedLength();

            modelBuilder.Entity<Ремонт>()
                .Property(e => e.CostRepair)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ремонт>()
                .Property(e => e.Comment)
                .IsFixedLength();

            modelBuilder.Entity<Товар>()
                .Property(e => e.GoodsID)
                .IsFixedLength();

            modelBuilder.Entity<Товар>()
                .Property(e => e.Goods)
                .IsFixedLength();

            modelBuilder.Entity<Товар>()
                .Property(e => e.Categoty)
                .IsFixedLength();

            modelBuilder.Entity<Товар>()
                .Property(e => e.Country)
                .IsFixedLength();

            modelBuilder.Entity<Товар>()
                .Property(e => e.Company)
                .IsFixedLength();

            modelBuilder.Entity<Товар>()
                .Property(e => e.INNcompany)
                .IsFixedLength();

            modelBuilder.Entity<Товар>()
                .Property(e => e.AddressComp)
                .IsFixedLength();

            modelBuilder.Entity<Товар>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Филиал>()
                .Property(e => e.Filial)
                .IsFixedLength();

            modelBuilder.Entity<Филиал>()
                .Property(e => e.InnFilial)
                .IsFixedLength();

            modelBuilder.Entity<Филиал>()
                .Property(e => e.Chief)
                .IsFixedLength();

            modelBuilder.Entity<Филиал>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Филиал>()
                .Property(e => e.Phone)
                .IsFixedLength();
        }
    }
}
