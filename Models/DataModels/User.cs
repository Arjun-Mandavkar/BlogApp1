using Microsoft.AspNetCore.Identity;

namespace BlogApp1.Models.DataModels
{
    public class User: IdentityUser
    {
        public string Name { get; set; } = string.Empty;
        public string Roles { get; set; } = string.Empty;
    }
}
