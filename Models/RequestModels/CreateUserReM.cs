using BlogApp1.Models.Enums;

namespace BlogApp1.Models.RequestModels
{
    public class CreateUserReM : RegisterUserReM
    {
        public UserRole[]? Roles { get; set; }
    }
}
