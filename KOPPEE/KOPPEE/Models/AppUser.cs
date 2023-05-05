using Microsoft.AspNetCore.Identity;

namespace KOPPEE.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsRemember { get; set; }
        public bool IsDeactive { get; set; }
    }
}
