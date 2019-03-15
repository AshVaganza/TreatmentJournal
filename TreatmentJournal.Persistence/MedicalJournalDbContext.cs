using Microsoft.EntityFrameworkCore;
using TreatmentJournal.Domain.Entities;

namespace TreatmentJournal.Persistence
{
    public class MedicalJournalDbContext : DbContext
    {
        public DbSet<Therapist> Therapists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MedicalJournal;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
