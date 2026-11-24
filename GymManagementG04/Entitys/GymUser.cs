using GymManagementG04.Entitys.Enums;

namespace GymManagementG04.Entitys
{
    public abstract class GymUser:BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public DateOnly DateOfBrith { get; set; } 
        public Gender Gender  { get; set; }
        public Address Address { get; set; } = default!;
        


    }
}
