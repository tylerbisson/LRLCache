using Microsoft.EntityFrameworkCore;

namespace RecordsApi.Models
{
    public class ArtistContext : DbContext
    {
        public ArtistContext(DbContextOptions<ArtistContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> ArtistItems { get; set; }
    }
}