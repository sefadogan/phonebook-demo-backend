using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sefd.Phonebook.Core.Constants;
using Sefd.Phonebook.Entities.Concretes.Entities;

namespace Sefd.Phonebook.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ContactMapping : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).UseIdentityColumn();
            builder.Property(b => b.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(b => b.LastName).IsRequired().HasMaxLength(50);
            builder.Property(b => b.CompanyName).IsRequired(false).HasMaxLength(100);

            builder.Property(b => b.CreatedDate).HasColumnType(EntityColumnTypes.DATETIME);
            builder.Property(b => b.UpdatedDate).IsRequired(false).HasColumnType(EntityColumnTypes.DATETIME);
            
            builder.HasQueryFilter(p => p.IsDeleted == false);
        }
    }
}
