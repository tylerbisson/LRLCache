using Microsoft.EntityFrameworkCore;
using RecordsApi.Models;

namespace RecordsApi.Data
{
    public class RecordsApiContext : DbContext
    {
        public RecordsApiContext(DbContextOptions<RecordsApiContext> options)
            : base(options)
        {
        }

        public DbSet<Record> Record { get; set; }

        public DbSet<Artist> Artist { get; set; }
    }
}