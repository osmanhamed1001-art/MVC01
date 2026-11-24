namespace GymManagementG04.Entitys
{
    public class Member:GymUser
    {
        public string? photo { get; set; }

        public ICollection<MemberShip> Plans { get; set; } = default!;

    }
}
