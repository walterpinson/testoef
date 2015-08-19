using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using Core.Domain.Models;

namespace Infrastructure.Data.Sql
{
    using System.Data.Entity;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext(string connectionStringName)
            : base($"name={connectionStringName}")
        {
            Database.SetInitializer<ApplicationContext>(null);
        }

        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Map to the appropriate table
            modelBuilder.Entity<Registration>().ToTable("Registration");

            // Ensure that the GUID IDs are autopopulated
            modelBuilder.Entity<Registration>()
                .Property(o => o.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Configure component classes
            modelBuilder.ComplexType<Name>();

            // Perform the custom mapping
            modelBuilder.Types<Registration>().Configure(ctc => ctc.Property(reg => reg.Name.First).HasColumnName("FirstName"));
            modelBuilder.Types<Registration>().Configure(ctc => ctc.Property(reg => reg.Name.Last).HasColumnName("LastName"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
