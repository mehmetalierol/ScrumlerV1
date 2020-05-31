using Scrumler.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Scrumler.Dal.Concrete.EntityFramework
{
    public class ScrumlerContext : DbContext
    {
        private IConfiguration _config;

        public ScrumlerContext(IConfiguration config)
        {
            _config = config;
        }

        #region DbSet

        public DbSet<Kullanici> TableKullanici { get; set; }
        public DbSet<KullaniciYetki> TableKullaniciYetki { get; set; }
        public DbSet<Yetki> TableYetki { get; set; }

        #endregion DbSet

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MetsConnection"].ConnectionString);
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
            //optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().HasIndex(p => new { p.KullaniciKodu, p.Parola });
        }
    }
}