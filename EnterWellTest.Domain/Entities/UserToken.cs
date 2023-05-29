using Microsoft.AspNetCore.Identity;

namespace EnterWellTest.Domain.Entities
{
    public class UserToken : IdentityUserToken<int>
    {
        public virtual User? User { get; set; }
    }
}
