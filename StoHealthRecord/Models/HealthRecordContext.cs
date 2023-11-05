using Microsoft.EntityFrameworkCore;

namespace StoHealthRecord.Models
{
    public class HealthRecordContext:DbContext
    {
        public HealthRecordContext(DbContextOptions<HealthRecordContext> options):base(options)
        {

            
        }

        public virtual DbSet<TB> TBs { get; set; }

    }
}
