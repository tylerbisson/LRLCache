using Microsoft.EntityFrameworkCore;

namespace RecordsApi.Models
{
    public class RecordContext : DbContext
    {
        public RecordContext(DbContextOptions<RecordContext> options)
            : base(options)
        {
        }

        public DbSet<Record> RecordItems { get; set; }
    }
}