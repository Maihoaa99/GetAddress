using Microsoft.EntityFrameworkCore;

namespace WebsiteTMDT60.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<City> Citys { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Commune> Communes { get; set; }

        private const string connectionString = @"
            Data Source=DESKTOP-0TRDL0Q,1433;
            Initial Catalog=websiteTMDT;
            User ID=sa;Password=123456;
            Trusted_Connection=False;
            MultipleActiveResultSets=true;
            TrustServerCertificate=True;
            encrypt=false";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
