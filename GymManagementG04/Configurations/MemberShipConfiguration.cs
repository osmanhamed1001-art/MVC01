using GymManagementG04.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementG04.Configurations
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.Property(M=>M.CreateAt)
                   .HasComputedColumnSql("GetDate()");

            builder.HasOne(MS => MS.Plan)
                .WithMany(MS => MS.Members)
                .HasForeignKey(MS => MS.PlanId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ms => ms.Member)
                .WithMany(ms => ms.Plans)
                .HasForeignKey(ms => ms.MemberId);
        }
    }
}
