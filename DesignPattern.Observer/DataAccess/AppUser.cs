using Microsoft.AspNetCore.Identity;

namespace DesignPattern.Observer.DataAccess
{
    public class AppUser:IdentityUser<int>
    {
        public string NameSurname { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
    }
}
