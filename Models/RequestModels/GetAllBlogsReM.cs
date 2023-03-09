using BlogApp1.Models.Enums;

namespace BlogApp1.Models.RequestModels
{
    public class GetAllBlogsReM
    {
        public BlogSortBy SortBy { get; set; } = BlogSortBy.DATE;
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
    }
}
