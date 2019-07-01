using Microsoft.EntityFrameworkCore;
using RESTapi.Data.Entities;
using System;

namespace RESTapi.Data
{
    public class AppContext : DbContext
    {

        /* DbSets */
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Entities.Data> Datas { get; set; }
        public DbSet<ProlongationAmount> ProlongationAmounts { get; set; }
        public DbSet<SubjectRole> SubjectRoles { get; set; }
        public DbSet<TotalAmount> TotalAmounts { get; set; }
        public DbSet<TotalMontlyPayment> TotalMontlyPayments { get; set; }


        public AppContext(DbContextOptions<AppContext> options)
           : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
