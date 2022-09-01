using Microsoft.EntityFrameworkCore;


namespace EFBreakAway
{
   class BreakAwayContext : DbContext
   {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
       optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BreakAwayDatabase;Trusted_Connection=True;MultipleActiveResultSets=true").Options;
      }
      public DbSet<Destination> Destinations { get; set; }
      public DbSet<Lodging> Lodgings { get; set; }
   }
}