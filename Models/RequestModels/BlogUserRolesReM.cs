using BlogApp1.Models.Enums;

namespace BlogApp1.Models.RequestModels
{
    public class BlogUserRolesReM
    {
        public string BlogId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public BlogUserRole[]? Roles { get; set; }
        public RoleAction Action { get; set; } = RoleAction.ASSIGN;
    }
}
