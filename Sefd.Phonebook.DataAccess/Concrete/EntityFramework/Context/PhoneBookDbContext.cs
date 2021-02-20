using Microsoft.EntityFrameworkCore;
using Sefd.Phonebook.DataAccess.Concrete.EntityFramework.Mapping;
using Sefd.Phonebook.Entities.Concretes.Entities;

namespace Sefd.Phonebook.DataAccess.Concrete.EntityFramework.Context
{
    public class PhoneBookDbContext : DbContext
    {
        #region Constructors
        public PhoneBookDbContext()
        {
        }

        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }
        #endregion

        #region DbSets
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactInformation> ContactInformations { get; set; }
        #endregion

        #region Override Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=PhoneBookDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactMapping());
            modelBuilder.ApplyConfiguration(new ContactInformationMapping());
        }
        #endregion
    }
}
