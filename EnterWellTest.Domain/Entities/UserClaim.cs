using Microsoft.AspNetCore.Identity;

namespace EnterWellTest.Domain.Entities
{
    public class UserClaim : IdentityUserClaim<int>
    {
        public virtual User? User { get; set; }
    }
}
