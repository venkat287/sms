using Microsoft.EntityFrameworkCore;
using SMS.Models;

namespace SMS
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<InspectionDetail> Inspections { get; set; }

        public DbSet<InspectionInfo> InspectionInfos { get; set; }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure InspectionDetail as keyless entity
            modelBuilder.Entity<InspectionDetail>().HasNoKey();
            modelBuilder.Entity<InspectionInfo>().HasNoKey();

            modelBuilder.Entity<InspectionDetail>()
                  .Property(e => e.Category)
                  .HasColumnType("TEXT");

            modelBuilder.Entity<InspectionDetail>()
                    .Property(e => e.Comments)
                    .HasColumnType("TEXT");
            // Other configurations...

            base.OnModelCreating(modelBuilder);
        }
    }

}
