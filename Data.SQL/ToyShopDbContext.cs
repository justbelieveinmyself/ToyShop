using System.Data.Entity;
namespace Data.SQL
{
    internal class ToyShopDbContext : DbContext
    {
        public DbSet<ToyEntity> Toys { get; set; }
        public DbSet<CheckEntity> Checks { get; set; }
        internal ToyShopDbContext() : base("DbConnectionString")
        {

        }
    }
}