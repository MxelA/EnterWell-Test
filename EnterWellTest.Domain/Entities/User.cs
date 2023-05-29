using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EnterWellTest.Domain.Entities
{
    public class User : IdentityUser<int>
    {
        [PersonalData]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        [PersonalData]
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
        public virtual ICollection<UserRole>? UserRoles { get; set; }
        public virtual ICollection<UserClaim>? Claims { get; set; }
        public virtual ICollection<UserToken>? Tokens { get; set; }
        public virtual ICollection<UserLogin>? Logins { get; set; }
        public virtual ICollection<Invoice>? Invoices { get; set; }
    }
}
