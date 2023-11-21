using MetroMetrics.Models;
using Microsoft.EntityFrameworkCore;

namespace MetroMetrics.Database
{
    public class AppContextDb : DbContext
    {
        public AppContextDb()
        {

        }

        public DbSet<CountryModel> Countries { get; set; }
        public DbSet<CityModel> Cities { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MetroMetricsDb;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CountryModel>().Property(e => e.CountryId).ValueGeneratedNever();

            modelBuilder.Entity<CityModel>().Property(e => e.CityId).ValueGeneratedNever();
        }

    }
}
