using Microsoft.EntityFrameworkCore;

namespace NetExtensions.Infra.RelayApiBuilder.RelayApiEntities
{
    public class RelayApiContext : DbContext
    {
        public RelayApiContext()
        {
        }

        public RelayApiContext(DbContextOptions<RelayApiContext> options)
            : base(options)
        {
        }

        public DbSet<ResourceConfigData> ResourceConfigData { get; set; }
    }
}