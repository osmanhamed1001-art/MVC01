using GymManagementG04.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementG04.Configurations
{
    public class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser 
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("varchar").HasMaxLength(11);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.ToTable(TB =>
            {
                TB.HasCheckConstraint("CK_Email", "Email like '_%@_%._%'");
                TB.HasCheckConstraint("CK_Phone", "len(Phone)=11 And (Phone like '010%' Or Phone like '011%' Or Phone like '012%' Or Phone like'015%')");
            } );
            builder.ComplexProperty(x=>x.Address);
          


        }
        
    }
}
