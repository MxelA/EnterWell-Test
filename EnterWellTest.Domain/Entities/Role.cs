using Microsoft.AspNetCore.Identity;

namespace EnterWellTest.Domain.Entities
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<UserRole>? Users { get; set; }
        public virtual ICollection<RoleClaim>? Claims { get; set; }
    }
}
