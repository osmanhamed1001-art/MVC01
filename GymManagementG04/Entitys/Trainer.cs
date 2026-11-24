using GymManagementG04.Entitys.Enums;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace GymManagementG04.Entitys
{
    public class Trainer:GymUser
    {
        public DateTime HirDate { get; set; }
        public Specialities Specialities { get; set; }

        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
