using GymManagementG04.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementG04.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(S => S.CreateAt)
                   .HasComputedColumnSql("GetDate()");

            builder.ToTable(TB =>
            {
                TB.HasCheckConstraint("CK_Capacity", "Capacity Between 1 And 25");
                TB.HasCheckConstraint("CK_EndDate", "EndDate > StartDate"); 
            });
            builder.HasOne(s=>s.Trainer)
                .WithMany(s=>s.Sessions)
                .HasForeignKey(s=>s.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
