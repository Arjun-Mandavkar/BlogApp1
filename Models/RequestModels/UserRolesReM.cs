using BlogApp1.Models.Enums;

namespace BlogApp1.Models.RequestModels
{
    public class UserRolesReM
    {
        public string BlogId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public UserRole[]? Roles { get; set; }
        public RoleAction Action { get; set; } = RoleAction.ASSIGN;
    }
}
