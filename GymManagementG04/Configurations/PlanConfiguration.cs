using GymManagementG04.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementG04.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(p => p.CreateAt)
                   .HasComputedColumnSql("GetDate()");
            builder.ToTable(TB =>
            {
                TB.HasCheckConstraint("CK_DurationDays", "DurationDays Between 1 And 365");

            });
        }
    }
}
