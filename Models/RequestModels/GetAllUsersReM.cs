using BlogApp1.Models.Enums;

namespace BlogApp1.Models.RequestModels
{
    public class GetAllUsersReM
    {
        public UserSortBy SortBy { get; set; } = UserSortBy.EMAIL;
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
    }
}
