using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sefd.Phonebook.Core.Constants;
using Sefd.Phonebook.Entities.Concretes.Entities;

namespace Sefd.Phonebook.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ContactInformationMapping : IEntityTypeConfiguration<ContactInformation>
    {
        public void Configure(EntityTypeBuilder<ContactInformation> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).UseIdentityColumn();
            builder.Property(b => b.Phone).IsRequired().HasColumnType(EntityColumnTypes.CHAR_10);
            builder.Property(b => b.Email).IsRequired(false).HasColumnType(EntityColumnTypes.NVARCHAR_320);

            builder.Property(b => b.CreatedDate).HasColumnType(EntityColumnTypes.DATETIME);
            builder.Property(b => b.UpdatedDate).IsRequired(false).HasColumnType(EntityColumnTypes.DATETIME);

            builder.HasQueryFilter(p => p.IsDeleted == false);
        }
    }
}
