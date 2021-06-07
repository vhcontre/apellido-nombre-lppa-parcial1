using Entities.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Domain.Data
{
    public class AfiliadoDbContext : DbContext
    {
        public AfiliadoDbContext()
        : base("DefaultConnection") 
        {
        }
        public DbSet<Afiliado> Afiliados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}