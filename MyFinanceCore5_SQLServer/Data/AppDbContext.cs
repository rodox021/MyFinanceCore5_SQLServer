using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFinanceCore5_SQLServer.Models.Entity;

namespace MyFinanceCore5_SQLServer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<CardUser> CardUsers { get; set; }
        public DbSet<Input> Inputs { get; set; }
        public DbSet<TypeInput> TypeInputs{ get; set; }
        public DbSet<InstallmentTypeInput> InstallmentTypeInputs { get; set; }
        public DbSet<TypePayment> TypePayments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<InstallmentBuy> InstallmentBuys { get; set; }
        public DbSet<PictureIcon> PictureIcons { get; set; }

    }
}
