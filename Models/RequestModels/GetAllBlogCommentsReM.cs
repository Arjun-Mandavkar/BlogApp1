using BlogApp1.Models.Enums;

namespace BlogApp1.Models.RequestModels
{
    public class GetAllBlogCommentsReM
    {
        public BlogCommentSortBy SortBy { get; set; } = BlogCommentSortBy.DATE;
        public int BucketSize { get; set; } = 5;
        public int BucketNumber { get; set; } = 1;
    }
}
