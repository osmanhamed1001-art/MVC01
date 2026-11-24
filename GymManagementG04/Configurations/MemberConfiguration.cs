using GymManagementG04.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementG04.Configurations
{
    public class MemberConfiguration :GymUserConfiguration<Member> ,IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {

            builder.Property(m => m.CreateAt)
                   .HasColumnName("JoinDate")
                   .HasComputedColumnSql("GetDate()");


            base.Configure(builder);
        }

    }
}
