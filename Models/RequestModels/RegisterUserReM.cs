using BlogApp1.Models.Enums;

namespace BlogApp1.Models.RequestModels
{
    public class RegisterUserReM
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
    }

    public class CreateUserReM : RegisterUserReM
    {
        public UserRole[]? Roles { get; set; }
    }

    public class UpdateUserReM : CreateUserReM
    {
        public string Id { get; set; } = string.Empty;
    }
}
